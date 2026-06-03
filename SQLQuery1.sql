CREATE TABLE YoklamaOturumlari
(

    OturumId INT PRIMARY KEY IDENTITY(1,1),
    DersId INT NOT NULL,
    BaslangicZamani DATETIME NOT NULL,
    YoklamaKodu NVARCHAR(50),
    AktifMi BIT NOT NULL,
    Enlem FLOAT NOT NULL,
    Boylam FLOAT NOT NULL,
    KonumYaricapi INT NOT NULL
);

CREATE TABLE YoklamaKayitleri
(

  KayitId INT PRIMARY KEY IDENTITY(1,1),
  OgrenciId INT NOT NULL,
  OturumId INT NOT NULL,
  Durum NVARCHAR(50),
  OgrenciEnlem FLOAT NOT NULL,
  OgrenciBoylam FLOAT NOT NULL

);