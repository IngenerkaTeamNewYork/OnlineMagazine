-- phpMyAdmin SQL Dump
-- version 4.7.7
-- https://www.phpmyadmin.net/
--
-- Хост: localhost
-- Время создания: Окт 04 2018 г., 19:20
-- Версия сервера: 10.2.12-MariaDB
-- Версия PHP: 7.0.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `id7146253_onlinemag`
--

-- --------------------------------------------------------

--
-- Структура таблицы `Advertisment`
--

CREATE TABLE `Advertisment` (
  `Text` varchar(2000) COLLATE utf8_unicode_ci NOT NULL,
  `Pic` varchar(500) COLLATE utf8_unicode_ci NOT NULL,
  `Date_From` varchar(30) COLLATE utf8_unicode_ci NOT NULL,
  `Data_to` varchar(30) COLLATE utf8_unicode_ci NOT NULL,
  `id` int(11) NOT NULL DEFAULT 0,
  `Новая` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Дамп данных таблицы `Advertisment`
--

INSERT INTO `Advertisment` (`Text`, `Pic`, `Date_From`, `Data_to`, `id`, `Новая`) VALUES
('о-то здесь не так', 'ссылка', '12.12.2012', '12.07.2018', 1, 1),
('что-то здесь так', 'ссылка', '12.12.2032', '12.01.2038', 2, 0),
('что-то здесь хорошо', 'ссылка', '12.12.2016', '12.07.2018', 3, 1),
('что-то здесь не хорошо', 'ссылка', '12.12.2013', '12.07.2018', 4, 0),
('что-то здесь не так плохо', 'ссылка', '12.12.1999', '12.07.2018', 5, 0);

-- --------------------------------------------------------

--
-- Структура таблицы `Articles`
--

CREATE TABLE `Articles` (
  `Header` varchar(500) COLLATE utf8_unicode_ci NOT NULL,
  `Text` text COLLATE utf8_unicode_ci NOT NULL,
  `Author` varchar(60) COLLATE utf8_unicode_ci NOT NULL,
  `Picture` blob DEFAULT NULL,
  `Artic_ID` int(11) NOT NULL,
  `Category` varchar(60) COLLATE utf8_unicode_ci NOT NULL,
  `new` int(11) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Дамп данных таблицы `Articles`
--

INSERT INTO `Articles` (`Header`, `Text`, `Author`, `Picture`, `Artic_ID`, `Category`, `new`) VALUES
('Кличко укусил Дружко', 'Известный Кличко укусил известного Дружко во время матча \"Динамо Киев\" - \"Таганрогский строитель\". Пострадавший доставлен в больницу. Проверять это я, конечно, не буду', 'Хламидомонада', NULL, 0, '', 1),
('Котята и вода', 'Я топлю котят\nКотята - наше все\nКогда котят хотят\nХотят котят и все', 'Хламидомонада', NULL, 1, 'Животные', 0),
('Обычный программист из Ульяновска получает Нобелевскую премию', 'Обычный программист из Ульяновска получает Нобелевскую премию. Даниил Николаев взломал шведский сервер и назначил себе нобелевскую премию по программированию. Хотя такой номинации не было.\nНо никто не заметил, ибо все спали', 'Кличко', NULL, 4, 'Великие люди', 1),
('Олечка Бузова', 'Ольга Бузова взорвала Интернет!\nВесь интернет взорван Бузовой, чье туловище лопнуло от песни \"мало половин\"', 'Олечка Бузова', NULL, 2, 'Животные', 1),
('Цыгане', 'Начали считать за население Земли', 'Цыгане', NULL, 3, 'Животные', 1);

-- --------------------------------------------------------

--
-- Структура таблицы `Authors`
--

CREATE TABLE `Authors` (
  `UserName` varchar(60) COLLATE utf8_unicode_ci NOT NULL,
  `Views` int(11) NOT NULL,
  `Likes` int(11) NOT NULL,
  `Dislikes` int(11) NOT NULL,
  `Articles` int(11) NOT NULL,
  `Информация об авторе` varchar(1564) COLLATE utf8_unicode_ci NOT NULL,
  `Заблокирован` tinyint(1) NOT NULL,
  `Pic` blob NOT NULL,
  `ban` int(11) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Дамп данных таблицы `Authors`
--

INSERT INTO `Authors` (`UserName`, `Views`, `Likes`, `Dislikes`, `Articles`, `Информация об авторе`, `Заблокирован`, `Pic`, `ban`) VALUES
('Еж', 55, 785, 4367, 798, 'денроеувргне', 1, '', 0),
('Кот', 987, 74, 7672, 7486, 'ждлоыквое', 0, '', 1),
('нозавр', 58, 75, 725, 548, 'анашщаш', 0, '', 0),
('Хламидомонада', 848, 76, 73, 59, 'шавдпмиышзупиезукминуые4п', 1, '', 0),
('Я_Автор', 78678, 7863, 786, 789, 'увенуну46е', 0, '', 0);

-- --------------------------------------------------------

--
-- Структура таблицы `Balance`
--

CREATE TABLE `Balance` (
  `Author` text COLLATE utf8_unicode_ci NOT NULL,
  `Summa` int(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Дамп данных таблицы `Balance`
--

INSERT INTO `Balance` (`Author`, `Summa`) VALUES
('Цыгане', 0),
('Кличко', 20),
('Михаил Сергеевич', 6969),
('Ахмед Петрович', 500);

-- --------------------------------------------------------

--
-- Структура таблицы `Categories`
--

CREATE TABLE `Categories` (
  `Name` varchar(60) COLLATE utf8_unicode_ci NOT NULL,
  `Picture` blob DEFAULT NULL,
  `Coteg_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Дамп данных таблицы `Categories`
--

INSERT INTO `Categories` (`Name`, `Picture`, `Coteg_ID`) VALUES
('Животные', NULL, 0),
('Юмор', NULL, 0);

-- --------------------------------------------------------

--
-- Структура таблицы `Colection`
--

CREATE TABLE `Colection` (
  `id_art` int(11) NOT NULL,
  `Coll_text` varchar(60) COLLATE utf8_unicode_ci NOT NULL
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
  `Article` varchar(60) COLLATE utf8_unicode_ci NOT NULL,
  `Author` varchar(60) COLLATE utf8_unicode_ci NOT NULL,
  `Category` varchar(60) COLLATE utf8_unicode_ci NOT NULL,
  `LikesCount` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Дамп данных таблицы `Likes`
--

INSERT INTO `Likes` (`Article`, `Author`, `Category`, `LikesCount`) VALUES
('Зачем нужна бумажка?', 'Михаил Сергеевич', 'Программирование', 17),
('Я нюхаю потные носки', 'Цыгане', 'Животные', 100000000),
('Как сделать C4 в домашних условиях?', 'Ахмед Петрович', 'Военная техеника и оружие', 11),
('Как возбудить кота?', 'Валерьянка ', 'Животные', 69);

-- --------------------------------------------------------

--
-- Структура таблицы `Polzovateli`
--

CREATE TABLE `Polzovateli` (
  `Login` text COLLATE utf8_unicode_ci NOT NULL,
  `Parol` text COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Дамп данных таблицы `Polzovateli`
--

INSERT INTO `Polzovateli` (`Login`, `Parol`) VALUES
('vbi', 'fgiulw'),
('rvgiysdabjcv', 'wefhvweiyfb'),
('viywsvufgw', 'fgiwy082'),
('dsafiuwetui', '832y443t8g'),
('79234yifb3', '441548448');

-- --------------------------------------------------------

--
-- Структура таблицы `Promo_categories_Link`
--

CREATE TABLE `Promo_categories_Link` (
  `ID_PROMO` int(11) NOT NULL,
  `ID_CATEGORY` varchar(60) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Дамп данных таблицы `Promo_categories_Link`
--

INSERT INTO `Promo_categories_Link` (`ID_PROMO`, `ID_CATEGORY`) VALUES
(1, 'Животные'),
(1, 'Бизнес');

-- --------------------------------------------------------

--
-- Структура таблицы `read_of_articles`
--

CREATE TABLE `read_of_articles` (
  `name_of_article` varchar(60) COLLATE utf8_unicode_ci NOT NULL,
  `reader` varchar(80) COLLATE utf8_unicode_ci NOT NULL,
  `dt` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Дамп данных таблицы `read_of_articles`
--

INSERT INTO `read_of_articles` (`name_of_article`, `reader`, `dt`) VALUES
('Да здравствует Ад и Химия!', 'Еж', '2018-10-01'),
('Жизнь - боль', 'Нозавр', '2018-10-03'),
('Хочу себе дракона', 'Бенедикт Камбербетч', '2018-10-03');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `Advertisment`
--
ALTER TABLE `Advertisment`
  ADD UNIQUE KEY `id` (`id`);

--
-- Индексы таблицы `Articles`
--
ALTER TABLE `Articles`
  ADD UNIQUE KEY `Header` (`Header`,`Artic_ID`);

--
-- Индексы таблицы `Authors`
--
ALTER TABLE `Authors`
  ADD PRIMARY KEY (`UserName`),
  ADD UNIQUE KEY `UserName` (`UserName`);

--
-- Индексы таблицы `Categories`
--
ALTER TABLE `Categories`
  ADD UNIQUE KEY `Name` (`Name`,`Coteg_ID`);

--
-- Индексы таблицы `read_of_articles`
--
ALTER TABLE `read_of_articles`
  ADD UNIQUE KEY `name_of_article` (`name_of_article`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
