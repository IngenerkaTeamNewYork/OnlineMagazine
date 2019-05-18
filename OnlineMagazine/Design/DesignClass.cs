﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineMag
{
    public class DesignClass
    {
        #region Формы

        /// <summary>
        /// Фоновая картинка формы
        /// </summary>
        public static Image FORM_BACKGROUND_IMG;

        //public static int nomer_konfig_image;

        public static Color FORM_COLOR;
        /// <summary>
        /// Курсор
        /// </summary>
        public static Cursor FORM_CURSOR;
        /// <summary>
        /// Контекстное меню форм
        /// </summary>
        public static ContextMenuStrip FORM_MENU;

        public static FlatStyle FLAT_OF_BUTTON;
        #endregion

        #region Кнопки

        /// <summary>
        /// Фоновая картинка кнопки
        /// </summary>
        public static Image BUTTON_BACKGROUND_IMG;
        /// <summary>
        /// Контекстное меню кнопки
        /// </summary>
        public static ContextMenuStrip BUTTON_MENU;
        /// <summary>
        /// Цвет текста кнопки
        /// </summary>
        public static Color BUTTON_TEXT_COLOR;
        public static Color BUTTON_COLOR;
        public static ContentAlignment BUTTONIMAGE_ALLINE = ContentAlignment.TopLeft;
        public static Font BUTTON_FONT;
        public static String BUTTON_BACKGROUND_IMG_ADRESS;
        #endregion

        #region etc

        /// <summary>
        /// Расстояние между картинками
        /// </summary>
        public static int LENGTH;

        public static Color LABEL_TEXT_COLOR;
        public static Color LABEL_COLOR;


        #endregion

        #region Панели
        /// <summary>
        /// Цвет панели
        /// </summary>
        public static Color PANEL_COLOR;
        /// <summary>
        /// Картинка панели
        /// </summary>
        public static Image PANEL_BACKGROUND_IMG;
        /// <summary>
        /// Адрес картинки панели
        /// </summary>
        public static String PANEL_BACKGROUND_ADDRESS;
        /// <summary>
        /// Прозрачность панели
        /// </summary>
        public static bool PANEL_TRANSPARENCY;
        public static int PANEL_LENGTH;
        /// <summary>
        /// Контекстное меню пикчербоксов
        /// </summary>
        public static ContextMenuStrip PICTURE_SAVE_MENU;
        /// <summary>
        /// Контекстное меню панелей
        /// </summary>
        public static ContextMenuStrip PANEL_MENU;
        /// <summary>
        /// Номер последней картинки (чтобы несколько скриншотов сохранять)
        /// </summary>
        public static int PictureSaveIndex = 0;
        #endregion

        #region Label
        public static string NAME_FONT_OF_LABEL;
        public static int SIZE_FONT_OF_LABEL;
        public static bool LABEL_AUTO_SIZE = true;
        public static ContentAlignment LABEL_TEXT_ALIGN;// = System.Drawing.ContentAlignment.MiddleCenter;
        public static Font FONT_OF_LABEL;
        public static ContextMenuStrip LABEL_MENU;
        #endregion


        public static void AddContextMenuStrip(Control form)
        {
            foreach(Control cont in form.Controls)
            {
                switch (cont.GetType().Name)
                {
                    case "Panel":
                        AddContextMenuStrip(cont);
                        break;
                    case "Label":
                        cont.ContextMenuStrip = Program.LabelControlCMS;
                        break;
                    case "TableLayoutPanel":
                        AddContextMenuStrip(cont);
                        break;

                    case "Flat":
                        break;
                }
            }
        }
    }

    
}
