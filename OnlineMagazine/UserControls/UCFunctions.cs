using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OnlineMag
{
    /// <summary>
    /// Класс с функциями для UserControl-ов
    /// </summary>
    class UCFunctions
    {
        /// <summary>
        /// Функция со стака которая делит одномерный массив в массивы 
        /// размером <paramref name="chunk_size"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        private static List<List<T>> Split<T>(List<T> source, int chunk_size)
        {
            return source
                .Select((x, i) => new { Index = i, Value = x })
                .GroupBy(x => x.Index / chunk_size)
                .Select(x => x.Select(v => v.Value).ToList())
                .ToList();
        }

        /// <summary>
        /// Переписанная функция чтения из базы.
        /// </summary>
        /// <param name="FormName">Имя нужной формы</param>
        /// <returns>Лист контролов</returns>
        public static List<UserControl> ReadFromDB(string FormName,string parentName = "")
        {
            if (parentName == "")
            {
                parentName = FormName;
            }
            List<string> ListDB = SQLClass.Select(
                "SELECT form, x, y, name, Params, id, Dock FROM block WHERE form = '" + FormName + "' AND Parent = '" + parentName + "'");

            List<UserControl> ListOfControls = new List<UserControl>();

            foreach (List<string> Row in Split(ListDB, 7))
            {


                #region Вспомогательные переменные для того чтобы не писать Row[...]
                int x = Convert.ToInt32(Row[1]);
                int y = Convert.ToInt32(Row[2]);
                DockStyle d = DockStyle.None;
                string id = Row[5];
                string form = "";
                try
                {
                    form = Row[0];
                }
                catch (Exception)
                {
                    throw new NullReferenceException("form = null");
                }
                
                string name = "";
                try
                {
                    name = Row[3];
                }
                catch (Exception)
                {
                    throw new NullReferenceException("name = null");
                }

                List<string> Params = new List<string>();
                try
                {
                    Params = Row[4].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                }
                catch (Exception)
                {
                    throw new NullReferenceException("Params = null");
                }
                try
                {
                    switch (Row[6])
                    {
                        case "Top":
                            d = DockStyle.Top;
                            break;
                        case "Right":
                            d = DockStyle.Right;
                            break;
                        case "Left":
                            d = DockStyle.Left;
                            break;
                        case "Fill":
                            d = DockStyle.Fill;
                            break;
                        case "Bottom":
                            d = DockStyle.Bottom;
                            break;
                    }
                }
                catch (Exception)
                {
                    d = DockStyle.None;
                    //throw new NullReferenceException("name = null");
                }
                #endregion


                switch (name)
                {
                    case "AdsUserControl":
                        AdsUserControl NewAds = new AdsUserControl(Params)
                        {
                            Location = new Point(x, y),
                            Tag = id,
                            Dock = d,
                            Name = "UCref"
                        };
                        ListOfControls.Add(NewAds);
                        break;
                    case "ArticleDetailsUserControl":
                        ArticleDetailsUserControl NewDetails = new ArticleDetailsUserControl(Params)
                        {
                            Location = new Point(x, y),
                            Tag = id,
                            Dock = d,
                            Name = "UCref"
                        };
                        ListOfControls.Add(NewDetails);
                        break;
                    case "ArticlePreviewUserControl":
                        ArticlePreviewUserControl NewPreview = new ArticlePreviewUserControl(Params)
                        {
                            Location = new Point(x, y),
                            Tag = id,
                            Dock = d,
                            Name = "UCref"
                        };
                        ListOfControls.Add(NewPreview);
                        break;
                    case "AuthenticationUserControl":
                        AuthenticationUserControl NewAuth = new AuthenticationUserControl(Params)
                        {
                            Location = new Point(x, y),
                            Tag = id,
                            Dock = d,
                            Name = "UCref"
                        };
                        ListOfControls.Add(NewAuth);
                        break;
                    case "CategoriesUserControl":
                        CategoriesUserControl NewCateg = new CategoriesUserControl(Params)
                        {
                            Location = new Point(x, y),
                            Tag = id,
                            Dock = d,
                            Name = "UCref"
                        };
                        ListOfControls.Add(NewCateg);
                        break;
                    case "UserControlAutorsList":
                        UserControlAutorsList NewAuthorList = new UserControlAutorsList(Params)
                        {
                            Location = new Point(x, y),
                            Tag = id,
                            Dock = d,
                            Name = "UCref"
                        };
                        ListOfControls.Add(NewAuthorList);
                        break;
                    case "UserControlMainAuthor":
                        UserControlMainAuthor NewMainAuthor = new UserControlMainAuthor(Params)
                        {
                            Location = new Point(x, y),
                            Tag = id,
                            Dock = d,
                            Name = "UCref"
                        };
                        ListOfControls.Add(NewMainAuthor);
                        break;
                    case "UserControlSearch":
                        UserControlSearch NewSearch = new UserControlSearch(Params)
                        {
                            Location = new Point(x, y),
                            Tag = id,
                            Dock = d,
                            Name = "UCref"
                        };
                        ListOfControls.Add(NewSearch);
                        break;
                    case "PodborkiUserControl":
                        PodborkiUserControl NewCateg12 = new PodborkiUserControl()
                        {
                            Location = new Point(x, y),
                            Tag = id,
                            Dock = d,
                            Name = "UCref"
                        };
                        ListOfControls.Add(NewCateg12);
                        break;
                    default:
                        throw new Exception(string.Format("'{0}' это неправильное название блока", name));
                }
            }

            return ListOfControls;
        }

        public static void AddUC(Control cont)
        {
            List<UserControl> ss= ReadFromDB(cont.FindForm().Name, cont.Name);
            foreach(UserControl qwe in ss)
            {
                cont.Controls.Add(qwe);
            }

            foreach (Control C in cont.Controls)
            {
                if (C.GetType().Name == "Panel" || C.GetType().Name == "TableLayoutPanel")
                {
                    AddUC(C);
                }
            }
        }

    }
}
