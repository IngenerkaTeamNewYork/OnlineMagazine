-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Ноя 15 2018 г., 20:34
-- Версия сервера: 8.0.13
-- Версия PHP: 7.2.10-0ubuntu0.18.04.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `ingenerka`
--

-- --------------------------------------------------------

--
-- Структура таблицы `Advertisment`
--

CREATE TABLE `Advertisment` (
  `Text` varchar(2000) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `Pic` varchar(500) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `Date_From` varchar(30) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `Data_to` varchar(30) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `id` int(11) NOT NULL DEFAULT '0',
  `new` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Дамп данных таблицы `Advertisment`
--

INSERT INTO `Advertisment` (`Text`, `Pic`, `Date_From`, `Data_to`, `id`, `new`) VALUES
('http://www.cyberforum.ru/windows-forms/thread2004323.html', 'http://www.calorizator.ru/sites/default/files/imagecache/recipes_full/recipe/26281.jpg', '12.01.2018', '15.01.2019', 1, 0),
('что-то здесь так', 'http://mir-krup.ru.opt-images.1c-bitrix-cdn.ru/upload/iblock/f45/f45c3b44bc01eb564704c64171e20e62.jpg?148465767882950', '12.12.2032', '12.01.2038', 2, 0),
('что-то здесь хорошо', 'https://1000.menu/img/user_foto/15899/2_1390510056.jpg', '12.12.2016', '12.03.2003', 3, 1),
('http://www.cyberforum.ru/windows-forms/thread2004323.html', 'https://nashzeleniymir.ru/wp-content/uploads/2016/04/%D0%9C%D1%8B%D1%88%D1%8C-%D1%84%D0%BE%D1%82%D0%BE.jpg', '12.12.1999', '12.12.2018', 4, 0),
('https://kakzarabativat.ru/wp-content/uploads/2017/01/Chto-takoe-reklama-prostymi-slovami.jpg', 'https://kakzarabativat.ru/wp-content/uploads/2017/01/Chto-takoe-reklama-prostymi-slovami.jpg', '12.10.2008', '12.12.2020', 5, 1),
('Highway', '', '13.10.2018', '20.10.2018', 6, 1),
('Highway to Hell', '', '13.10.2018', '20.12.2018', 7, 0),
('https://images.samsung.com/is/image/samsung/ru-feature-galaxy-a7-a750-123710063?$FB_TYPE_A_JPG$', 'https://images.samsung.com/is/image/samsung/ru-feature-galaxy-a7-a750-123710063?$FB_TYPE_A_JPG$', '13.10.2018', '21.12.2018', 8, 0);

-- --------------------------------------------------------

--
-- Структура таблицы `Articles1`
--

CREATE TABLE `Articles1` (
  `Header` varchar(500) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `Text` text CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `Author` varchar(60) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `Picture` varchar(600) COLLATE utf8_unicode_ci DEFAULT NULL,
  `Artic_ID` int(11) NOT NULL,
  `Category` varchar(60) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `new` int(11) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Дамп данных таблицы `Articles1`
--

INSERT INTO `Articles1` (`Header`, `Text`, `Author`, `Picture`, `Artic_ID`, `Category`, `new`) VALUES
('Война и мир', 'Война на Украине\r\nУ панды постарадало левое очко', 'Еж', 'http://www.radionetplus.ru/uploads/posts/2013-05/1369460621_panda-26.jpg', 19, '', 0),
('Гречка', 'ddddddddddddddddddddddddddddddd', 'quwinner', 'https://www.youtube.com/watch?v=6Y-WfLIlGEc', 5, 'dddd', 0),
('Дайте денег', 'Мечтаю включить монетизацию, но как это сделаешь, когда у тебя несчастных 21 подписчик на ютубе и 16 на дзене\r\n\r\nПодписывайтесь\r\n\r\nЯ хороший\r\n\r\nСсылка на мой канал\r\nhttps://www.youtube.com/channel/UCXrEYagwlOF-fL35wePHFQA', 'ПрПрПр', '', 11, 'Вымогательство', 0),
('Ежи тоже люди', 'Ежи Дудек например', 'Еж', 'http://i.piccy.info/i9/a764e192de84a984f9651f8c01e3b3bd/1409389009/231396/792893/yv1.jpg', 15, 'Животные', 0),
('Если твой рост мерится штангенциркулем, у тебя проблемы', 'Да, да', 'Еж', 'https://cdn.vseinstrumenti.ru/images/goods/ruchnoy-instrument/izmeritelnyj/787871/461x415/1140161.jpg', 16, 'Юмор', 0),
('как мне жить', '', 'ww', NULL, 7, '', 0),
('Кличко укусил Дружко', 'Известный Кличко укусил известного Дружко во время матча \"Динамо Киев\" - \"Таганрогский строитель\". Пострадавший доставлен в больницу. Проверять это я, конечно, не буду', 'Хламидомонада', 'http://www.calorizator.ru/sites/default/files/imagecache/recipes_full/recipe/26281.jpg', 0, '', 0),
('Конор - телефон, которого побил Хабиб', 'А Хабиб - не телефон. У телефона уши не сломаны', 'Еж', '', 17, 'Юмор', 0),
('Котята и вода', 'Я топлю котят\nКотята - наше все\nКогда котят хотят\nХотят котят и все', 'Хламидомонада', NULL, 1, 'Животные', 0),
('Мебель', 'Где-то там', 'Еж', '', 18, '', 0),
('Обычный программист из Ульяновска получает Нобелевскую премию', 'Обычный программист из Ульяновска получает Нобелевскую премию. Даниил Николаев взломал шведский сервер и назначил себе нобелевскую премию по программированию. Хотя такой номинации не было.\nНо никто не заметил, ибо все спали', 'Кличко', 'https://i.mycdn.me/image?id=525179057664&plc=WEB&tkn=*4Tb4qIzywr8ZBj1ye0pNConH5Rc&fn=sqr_288', 4, 'Великие люди', 1),
('Олечка Бузова', 'Ольга Бузова взорвала Интернет!\nВесь интернет взорван Бузовой, чье туловище лопнуло от песни \"мало половин\"', 'Олечка Бузова', NULL, 2, 'Животные', 0),
('Повышение цен на сало в Украине', 'Резкиий рост повышения цен на сало шокировал Украинцев ', 'Xox love', 'https://edaplus.info/food_pictures/fat.jpg', 12, 'Украiна', 1),
('Поговорим о сале', 'Непростая, но очень интересная тема', '123', 'https://edaplus.info/food_pictures/fat.jpg', 14, '13131', 1),
('проверка', 'проверка', 'проверка', NULL, 10, '', 1),
('Программисты из Ульяновска сбежали из зоопарка', ' ', 'Николаев', 'https://i.mycdn.me/image?id=525179057664&plc=WEB&tkn=*4Tb4qIzywr8ZBj1ye0pNConH5Rc&fn=sqr_288', 6, 'Юмор', 1),
('Украина', 'салосалосалосалосалосалосалосалосалосалосалосалосалосалосалосалосаломсаломсалосалосалосалосалосалосалосалосалосалосалосалосалосаломсалосалосалосалосалосалосалосалосалосалосалосалосалосалосаломсаломсалосалосалосалосалосалосалосалосалосалосалосалосалосаломсалосалосалосалосалосалосалосалосалосалосалосалосалосалосаломсалосалосалосалосалосалосалосалосалосалосалосалосалосалосаломсалосалосалосалосалосалосалосалосалосалосалосалосалосалосаломсаломмммммммсалосалосалосалосалосалосалосалосалосалосалосалосалосаломсалосалосалосалосалосалосалосалосалосалосалосалосалосалосаломсалосалосалосалосалосалосалосалосалосалосалосалосалосалосаломсалосалосалосалосалосалосалосалосалосалосалосалосалосалосаломсалосалосалосалосалосалосалосалосалосалосалосалосалосалосаломсалосалосалосалосалосалосалосалосалосалосалосалосалосалосаломсаломмсалосалосалосалосалосалосалосалосалосалосалосалосалосаломсалосалосалосалосалосалосалосалосалосалосалосалосалосалосаломсалосалосалосалосалосалосалосалосалосалосалосалосалосалосаломсалосалосалосалосалосалосалосалосалосалосалосаломсало', 'Xox love', 'https://edaplus.info/food_pictures/fat.jpg', 13, 'Полiтiка', 1),
('Цыгане', 'Начали считать за население Земли', 'Цыгане', NULL, 3, 'Животные', 0);

-- --------------------------------------------------------

--
-- Структура таблицы `Authors`
--

CREATE TABLE `Authors` (
  `UserName` varchar(60) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `Views` int(11) NOT NULL DEFAULT '0',
  `Likes` int(11) NOT NULL DEFAULT '0',
  `Dislikes` int(11) NOT NULL DEFAULT '0',
  `Articles` int(11) NOT NULL DEFAULT '0',
  `Information_about_author` varchar(1564) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `locked` tinyint(1) NOT NULL DEFAULT '0',
  `Pic` varchar(600) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL DEFAULT '0',
  `ban` int(11) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci ROW_FORMAT=COMPACT;

--
-- Дамп данных таблицы `Authors`
--

INSERT INTO `Authors` (`UserName`, `Views`, `Likes`, `Dislikes`, `Articles`, `Information_about_author`, `locked`, `Pic`, `ban`) VALUES
('ergug', 0, 0, 0, 0, 'tjukii', 0, 'https://cs.pikabu.ru/post_img/2013/07/05/7/1373021060_1764022602.gif', 0),
('Данил', 0, 0, 0, 0, 'sarfgrfb', 0, 'https://cs.pikabu.ru/post_img/2013/07/05/7/1373021060_1764022602.gif', 0),
('Еж', 55, 785, 4367, 798, 'Колюч, ем насекомых', 1, 'http://news.rambler.ru/img/2017/12/20104533.986924.467.jpeg', 0),
('Жуков', 0, 0, 0, 0, 'Не Георгий Константинович, но тоже...', 0, 'https://i.pinimg.com/originals/c2/28/be/c228be07a7d413275131bbcc324007f7.gif', 0),
('Кот', 987, 74, 7672, 7486, 'ждлоыквое', 0, 'https://cf.reversegif.ru/gif_source/ZekEjLd7iHqg.gif', 1),
('нозавр', 58, 75, 725, 548, 'анашщаш', 0, 'https://cf.reversegif.ru/gif_source/X74xatSD96dE.gif', 0),
('Рибонуклеиновая кислота', 7868, 786, 786, 546, 'ненавижу биологию\r\nи людей', 0, 'http://multator.ru/preview/ellwjpro10n5', 0),
('Хламидомонада', 848, 76, 73, 59, 'шавдпмиышзупиезукминуые4п', 1, 'https://cf.reversegif.ru/gif_reverse/Q75puY9VLlEk.gif', 0),
('Я_Автор', 78678, 7863, 786, 789, 'увенуну46е', 0, 'http://68.media.tumblr.com/1a8f70a64e5743e0dd6ff5fa579e63db/tumblr_o1ogv2eDFc1rp0vkjo1_500.gif', 0);

-- --------------------------------------------------------

--
-- Структура таблицы `Balance`
--

CREATE TABLE `Balance` (
  `Author` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `Summa` int(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Дамп данных таблицы `Balance`
--

INSERT INTO `Balance` (`Author`, `Summa`) VALUES
('sddg', 45),
('sdfsf', 4),
('Ахмед Петрович', 500),
('Кличко', 20),
('Михаил Сергеевич', 6969),
('Цыгане', 0);

-- --------------------------------------------------------

--
-- Структура таблицы `Categories`
--

CREATE TABLE `Categories` (
  `Name` varchar(60) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `Picture` blob,
  `Coteg_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Дамп данных таблицы `Categories`
--

INSERT INTO `Categories` (`Name`, `Picture`, `Coteg_ID`) VALUES
('Животные', NULL, 0),
('Рисование', 0x61, 1),
('Стиль', 0x61, 0),
('Хроника', 0x61, 0),
('что-то', 0x61, 0),
('Юмор', 0x61, 1);

-- --------------------------------------------------------

--
-- Структура таблицы `Colection`
--

CREATE TABLE `Colection` (
  `id_art` int(11) NOT NULL,
  `Coll_text` varchar(60) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Дамп данных таблицы `Colection`
--

INSERT INTO `Colection` (`id_art`, `Coll_text`) VALUES
(1, 'Фигня всякая'),
(2, 'Фигня особая');

-- --------------------------------------------------------

--
-- Структура таблицы `Likes`
--

CREATE TABLE `Likes` (
  `Article` varchar(60) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `Author` varchar(60) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `Category` varchar(60) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `LikesCount` int(11) NOT NULL,
  `DisCount` int(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Дамп данных таблицы `Likes`
--

INSERT INTO `Likes` (`Article`, `Author`, `Category`, `LikesCount`, `DisCount`) VALUES
('Война и мир', 'Еж', 'Животные', 5, 1),
('Ежи тоже люди', 'Еж', 'Животные', 2, 1),
('Зачем нужна бумажка?', 'Михаил Сергеевич', 'Программирование', 17, 0),
('Как возбудить кота?', 'Валерьянка ', 'Животные', 69, 0),
('Как сделать C4 в домашних условиях?', 'Ахмед Петрович', 'Военная техеника и оружие', 11, 0),
('Кличко укусил Дружко', 'Хламидомонада', 'Животные', 7, 0),
('Программисты из Ульяновска сбежали из зоопарка', 'Николаев', 'Юмор', 1, 1),
('Я нюхаю потные носки', 'Цыгане', 'Животные', 100000000, 0);

-- --------------------------------------------------------

--
-- Структура таблицы `Polzovateli`
--

CREATE TABLE `Polzovateli` (
  `Login` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `Parol` text CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `ban` tinyint(1) NOT NULL,
  `aboutme` text CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `admin` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Дамп данных таблицы `Polzovateli`
--

INSERT INTO `Polzovateli` (`Login`, `Parol`, `ban`, `aboutme`, `admin`) VALUES
('12345', '12345', 0, 'дложоод', 0),
('aaa', 'aaaaaa', 0, 'asdas', 1),
('ergug', '123', 0, 'tjukii', 0),
('Данил', '1234', 0, '', 0),
('Еж', 'Еж', 0, 'Колюч, ем насекомых', 0),
('Жуков', 'Жуков', 0, 'Не такой как все. Что бы это не значило', 0),
('Кот', 'Кот', 0, 'ждлоыквое', 0),
('нозавр', '789', 0, 'анашщаш', 0),
('Рибонуклеиновая кислота', '789', 0, 'ненавижу биологию\r\nи людей', 0),
('Хламидомонада', '848', 0, 'шавдпмиышзупиезукминуые4п', 0),
('Я_Автор', '456', 0, 'увенуну46е', 0);

-- --------------------------------------------------------

--
-- Структура таблицы `Promo_categories_Link`
--

CREATE TABLE `Promo_categories_Link` (
  `ID_PROMO` int(11) NOT NULL,
  `ID_CATEGORY` text CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Дамп данных таблицы `Promo_categories_Link`
--

INSERT INTO `Promo_categories_Link` (`ID_PROMO`, `ID_CATEGORY`) VALUES
(1, 'Животные'),
(2, 'Бизнес');

-- --------------------------------------------------------

--
-- Структура таблицы `read_of_articles`
--

CREATE TABLE `read_of_articles` (
  `name_of_article` varchar(60) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `reader` varchar(80) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `dt` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Дамп данных таблицы `read_of_articles`
--

INSERT INTO `read_of_articles` (`name_of_article`, `reader`, `dt`) VALUES
('Гречка', 'NONAME', '2018-11-11'),
('Да здравствует Ад и Химия!', 'Еж', '2018-10-01'),
('Ежи тоже люди', 'Еж', '2018-11-11'),
('Жизнь - боль', 'Нозавр', '2018-10-03'),
('Хочу себе дракона', 'Бенедикт Камбербетч', '2018-10-03'),
('Ежи тоже люди', 'NONAME', '2018-11-11'),
('Ежи тоже люди', 'NONAME', '2018-11-11'),
('Ежи тоже люди', 'NONAME', '2018-11-11'),
('Ежи тоже люди', 'NONAME', '2018-11-11'),
('Война и мир', 'NONAME', '2018-11-12'),
('Кличко укусил Дружко', 'NONAME', '2018-11-14'),
('Олечка Бузова', 'NONAME', '2018-11-14'),
('Кличко укусил Дружко', '12345', '2018-11-14'),
('Кличко укусил Дружко', '12345', '2018-11-14'),
('Кличко укусил Дружко', '12345', '2018-11-14'),
('Кличко укусил Дружко', 'NONAME', '2018-11-14'),
('Кличко укусил Дружко', 'NONAME', '2018-11-14'),
('Ежи тоже люди', 'NONAME', '2018-11-14'),
('Цыгане', 'NONAME', '2018-11-14'),
('Кличко укусил Дружко', 'NONAME', '2018-11-14'),
('Война и мир', '12345', '2018-11-14'),
('Если твой рост мерится штангенциркулем, у тебя проблемы', 'NONAME', '2018-11-14'),
('Олечка Бузова', 'NONAME', '2018-11-14'),
('Гречка', 'NONAME', '2018-11-15'),
('как мне жить', 'NONAME', '2018-11-15'),
('Кличко укусил Дружко', 'NONAME', '2018-11-15'),
('Котята и вода', 'NONAME', '2018-11-15'),
('Дайте денег', 'NONAME', '2018-11-15');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `Advertisment`
--
ALTER TABLE `Advertisment`
  ADD UNIQUE KEY `id` (`id`);

--
-- Индексы таблицы `Articles1`
--
ALTER TABLE `Articles1`
  ADD UNIQUE KEY `Header` (`Header`,`Artic_ID`);

--
-- Индексы таблицы `Authors`
--
ALTER TABLE `Authors`
  ADD PRIMARY KEY (`UserName`),
  ADD UNIQUE KEY `UserName` (`UserName`);

--
-- Индексы таблицы `Balance`
--
ALTER TABLE `Balance`
  ADD UNIQUE KEY `Author` (`Author`);

--
-- Индексы таблицы `Categories`
--
ALTER TABLE `Categories`
  ADD UNIQUE KEY `Name` (`Name`,`Coteg_ID`);

--
-- Индексы таблицы `Colection`
--
ALTER TABLE `Colection`
  ADD PRIMARY KEY (`id_art`),
  ADD UNIQUE KEY `id_art` (`id_art`);

--
-- Индексы таблицы `Likes`
--
ALTER TABLE `Likes`
  ADD UNIQUE KEY `Article` (`Article`);

--
-- Индексы таблицы `Polzovateli`
--
ALTER TABLE `Polzovateli`
  ADD UNIQUE KEY `Login` (`Login`);

--
-- Индексы таблицы `Promo_categories_Link`
--
ALTER TABLE `Promo_categories_Link`
  ADD UNIQUE KEY `ID_PROMO` (`ID_PROMO`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
