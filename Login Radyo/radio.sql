-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 02 Oca 2023, 13:29:48
-- Sunucu sürümü: 10.4.27-MariaDB
-- PHP Sürümü: 8.1.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `radio`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `haberler`
--

CREATE TABLE `haberler` (
  `id` int(11) NOT NULL,
  `baslik` text NOT NULL,
  `haber` text NOT NULL,
  `resim` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `haberler`
--

INSERT INTO `haberler` (`id`, `baslik`, `haber`, `resim`) VALUES
(1, 'BALIKESİR ', 'BALIKESİR ŞAMPİYON', 'https://www.trtspor.com.tr/resimler/150000/150027.jpg');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `iletisim`
--

CREATE TABLE `iletisim` (
  `id` int(11) NOT NULL,
  `baslik` varchar(255) NOT NULL DEFAULT 'Baslik Yok',
  `mesaj` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `iletisim`
--

INSERT INTO `iletisim` (`id`, `baslik`, `mesaj`) VALUES
(10, 'Baslik Yok', '12345'),
(11, 'adami trex', 'bu bir mesajdir'),
(12, 'adamsın', 'asdasdasdasd'),
(13, 'MERHABA', 'ÇOK GÜZEL UYGULAMA OLMUŞ ELİNİZE SAĞLIK.'),
(14, 'dwedwe', 'wedwdw');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `login`
--

CREATE TABLE `login` (
  `id` int(11) NOT NULL,
  `kullanici_adi` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `ad_soyad` varchar(255) NOT NULL,
  `yetki` int(11) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `login`
--

INSERT INTO `login` (`id`, `kullanici_adi`, `password`, `ad_soyad`, `yetki`) VALUES
(6, 'mulkanadamdir', '123', 'mulkan', 1),
(7, 'mamii1', '123', 'mamii', 0),
(8, 'mami7711', '1234', 'muhammedaync', 1);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `yonetici`
--

CREATE TABLE `yonetici` (
  `id` int(11) NOT NULL,
  `kadi` varchar(255) NOT NULL,
  `sifre` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Tablo döküm verisi `yonetici`
--

INSERT INTO `yonetici` (`id`, `kadi`, `sifre`) VALUES
(1, 'mulk', '123');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `haberler`
--
ALTER TABLE `haberler`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `iletisim`
--
ALTER TABLE `iletisim`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `yonetici`
--
ALTER TABLE `yonetici`
  ADD PRIMARY KEY (`id`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `haberler`
--
ALTER TABLE `haberler`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Tablo için AUTO_INCREMENT değeri `iletisim`
--
ALTER TABLE `iletisim`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- Tablo için AUTO_INCREMENT değeri `login`
--
ALTER TABLE `login`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- Tablo için AUTO_INCREMENT değeri `yonetici`
--
ALTER TABLE `yonetici`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
