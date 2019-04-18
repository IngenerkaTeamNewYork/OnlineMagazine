﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public class Menus
    {
        public static void InitAddUserControls(ref ContextMenuStrip menu)
        {
            //Список типов UserControl-ов
            List<Type> forms = new List<Type>();
            foreach (Assembly asm in AppDomain.CurrentDomain.GetAssemblies())
            {
                forms.AddRange(from t in asm.GetTypes() where t.IsSubclassOf(typeof(UserControl)) select t);
            }

            foreach (Type File in forms)
            {
                menu.Items.Add(File.Name);
                int ItemPos = menu.Items.Count - 1;
                switch (File.Name)
                {
                    case "AdsUserControl":
                        menu.Items[ItemPos].Click += AdsUserControl.AddNewBlock;
                        break;
                    case "ArticlePreviewUserControl":
                        menu.Items[ItemPos].Click += ArticlePreviewUserControl.AddNewBlock;
                        break;
                    case "ArticleDetailsUserControl":
                        menu.Items[ItemPos].Click += ArticleDetailsUserControl.AddNewBlock;
                        break;
                    case "AuthenticationUserControl":
                        menu.Items[ItemPos].Click += AuthenticationUserControl.AddNewBlock;
                        break;
                    case "CategoriesUserControl":
                        menu.Items[ItemPos].Click += CategoriesUserControl.AddNewBlock;
                        break;
                    case "UserControlAutorsList":
                        menu.Items[ItemPos].Click += UserControlAutorsList.AddNewBlock;
                        break;
                    case "UserControlMainAuthor":
                        menu.Items[ItemPos].Click += UserControlMainAuthor.AddNewBlock;
                        break;
                    case "UserControlSearch":
                        menu.Items[ItemPos].Click += UserControlSearch.AddNewBlock;
                        break;
                }
            }
        }


        /// <summary>
        /// Функция указания текущих параметров перед показом формы UCParameters.
        /// </summary>
        public static void SetUCParametersToCurrent(object sender, EventArgs e)
        {
            UserControl pb = (UserControl)((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl;
            List<string> dnonil = new List<string>();

            switch (pb.Name)
            {
                case "AdsUserControl":
                    AdsUserControl pb1 = (AdsUserControl)pb;
                    dnonil.Add(pb1.amount.ToString());
                    dnonil.Add(pb1.progal.ToString());
                    break;
                case "ArticleDetailsUserControl":
                    ArticleDetailsUserControl pb2 = (ArticleDetailsUserControl)pb;
                    dnonil.Add(pb2.ListOfArticles[0]);
                    break;
                case "ArticlePreviewUserControl":
                    ArticlePreviewUserControl pb3 = (ArticlePreviewUserControl)pb;
                    dnonil.Add(pb3.Article);
                    dnonil.Add("5");
                    break;
                case "CategoriesUserControl":
                    CategoriesUserControl pb4 = (CategoriesUserControl)pb;
                    if (pb4.asd.Count>2)
                    {
                        dnonil.Add(pb4.asd[0]);
                        dnonil.Add(pb4.asd[1]);
                    }
                    break;
                case "UserControlAutorsList":
                    UserControlAutorsList pb5 = (UserControlAutorsList)pb;
                    dnonil.Add(pb5.asd[0]);
                    dnonil.Add(pb5.asd[1]);
                    dnonil.Add(pb5.asd[2]);
                    break;
                case "UserControlMainAuthor":
                    UserControlMainAuthor pb6 = (UserControlMainAuthor)pb;
                    dnonil.AddRange(pb6.par);
                    break;
                case "UserControlSearch":
                    UserControlSearch pb7 = (UserControlSearch)pb;
                    dnonil.Add(" ");
                    break;
                case "AuthenticationUserControl":
                    AuthenticationUserControl pb8 = (AuthenticationUserControl)pb;
                    dnonil.Add("");
                    break;
            }

            UCParameters p = new UCParameters(pb.GetType().ToString(), dnonil);
            p.UCSize = pb.Size;
            p.UCLocation = pb.Location;

            p.ShowDialog();
            pb.Size = p.UCSize;
            pb.Location = p.UCLocation;
            if (pb.Name == "UserControlMainAuthor")
            {
                UserControlMainAuthor pb33 = (UserControlMainAuthor)pb;
                pb33.par = new List<string>() { p.UserName };
                dnonil = pb33.par;
                pb33.Init(pb33.par);
            }
            else if (pb.Name == "CategoriesUserControl")
            {
                CategoriesUserControl pb2 = (CategoriesUserControl)pb;
                pb2.asd = p.ParamsList;
                dnonil = p.ParamsList;
                CategoriesUserControl.RefreshUC(pb2, Convert.ToInt32(pb2.asd[0]));
            }

            else if (pb.Name == "UserControlAutorsList")
            {
                UserControlAutorsList pb2 = (UserControlAutorsList)pb;
                pb2.asd.Clear();
                pb2.asd = p.ParamsList;
                pb2.authorsList = SQLClass.Select("SELECT `UserName` FROM `Authors` LIMIT 0," + p.Amount);
                pb2.UserControlAutorsList_Load(null, null);
                if (pb2.asd[2] == "")
                {
                    pb2.asd[2] = "0";
                }
                dnonil = pb2.asd;
            }

            else if (pb.Name == "ArticlePreviewUserControl")
            {
                ArticlePreviewUserControl pb2 = (ArticlePreviewUserControl)pb;

                pb2.Article = p.ParamsList[0];
                pb2.linkLabel1.Text = pb2.Article;
                pb2.asd = p.ParamsList;
                dnonil = pb2.asd;               

                try
                {
                    List<string> kart = SQLClass.Select("SELECT `Picture` FROM `Articles1` WHERE `Header` = '" + pb2.Article + "'");
                    pb2.pictureBox1.Load(kart[0]);

                    List<string> likes = SQLClass.Select("SELECT `LikesCount`, `DisCount` FROM `Likes` WHERE `Article` = '" + pb2.Article + "'");
                    pb2.LikeCount.Text = likes[0];
                    pb2.DisLikeCount.Text = likes[1];
                    pb2.like = Convert.ToInt32(likes[0]);
                    pb2.dislike = Convert.ToInt32(likes[1]);
                }
                catch
                {
                    pb2.pictureBox1.Image = null;
                }
            }
            else if (pb.Name == "ArticleDetailsUserControl")
            {
                ArticleDetailsUserControl pb2 = (ArticleDetailsUserControl)pb;
                pb2.ListOfArticles.Clear();

                pb2.ListOfArticles = p.ParamsList;
                pb2.ArticleLabel.Text = p.ParamsList[0];
                List<string> kart = SQLClass.Select("SELECT Picture, IFNULL(Text,'Ничего'), IFNULL(Author,'Никто')  FROM Articles1 WHERE Header = '" + pb2.ArticleLabel.Text + "'");
                if (kart.Count > 2)
                {
                    try
                    {
                        pb2.ArticlePicture.Load(kart[0]);
                    }
                    catch
                    {
                        pb2.ArticlePicture.Image = null;
                    }

                    pb2.ArticleTextLabel.Text = kart[1];
                    pb2.AuthorsNameLabel.Text = kart[2];                    
                }

                dnonil = pb2.ListOfArticles;
            } 
            else if (pb.Name == "AdsUserControl")
            {
                AdsUserControl pb2 = (AdsUserControl)pb;
                pb2.ParamsAds = p.ParamsList;
                pb2.amount = p.Amount;
                pb2.progal = p.DistanceBetween;
                pb2.refreshADS();
                dnonil = pb2.ParamsAds;
            }
            else if (pb.Name == "UserControlAutorsList")
            {
                UserControlAutorsList pb2 = (UserControlAutorsList)pb;
                pb2.asd = p.ParamsList;
                dnonil = p.ParamsList;
            }

            #region Сохранение в БД
            string param3 = "";
            foreach (string pr in dnonil)
            {
                param3 += pr + ",";
            }
            SQLClass.Update("UPDATE block SET" +
                " Params = '" + param3 +
                "' WHERE id = '" + pb.Tag + "'");
            SQLClass.Update("UPDATE block SET" +
                " x = " + pb.Location.X.ToString() + "," +
                " y = " + pb.Location.Y.ToString() +
                " WHERE id = '" + pb.Tag + "'");
            #endregion
        }


        public static void AddDeleteMenu(object sender)
        {
            //((UserControl)sender).ContextMenuStrip = BlockForm.DeleteMenuStrip;
        }

        /// <summary>
        /// Функция сохранения юзерконтрола на форму и базу.
        /// </summary>
        public static void SaveUserControl(object sender, EventArgs e)
        {
            UserControl pb = (UserControl)((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl;
            string FormName = pb.FindForm().Name;
            MessageBox.Show(pb.Location.X.ToString());
            SQLClass.Insert("INSERT INTO `block`(`form`,`Parent`, `x`, `y`, `name`) VALUES ('" + FormName + "','" + pb.Parent.Name + "'," + pb.Location.X + ", " + pb.Location.Y + ",'" + pb.Name + "')");
        }


        /// <summary>
        /// Добавление информации о блоке в БД
        /// </summary>
        public static void InsertBlockToDB(object sender, UserControl a1, string par)
        {
            Control c = ((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl;
            c.Controls.Add(a1);
            //Program.CONTROLY.Add(a1);
            SQLClass.Insert("INSERT INTO block(form,Parent,x,y,name,Params) VALUES ('" +
                c.FindForm().Name + "', '" + c.Name + "', '" + a1.Location.X + "','" + a1.Location.Y + "','" + a1.Name + "','" + par + "')");

            List<String> str = SQLClass.Select("SELECT MAX(id) FROM block");
            a1.Tag = str[0];
        }

        /// <summary>
        /// Функция удаления юзерконтрола из формы и базы.
        /// </summary>
        public static void DeleteUserControl(object sender, EventArgs e)
        {
            UserControl pb = (UserControl)((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl;
            pb.Visible = false;
            SQLClass.Delete("DELETE FROM `block` WHERE `name` = '" + pb.Name + "' AND form = '" + pb.FindForm().Name + "'");
        }
    }
}