ALTER TABLE dbo.YoklamaOturumlari
ADD CONSTRAINT FK_YoklamaOturumlari_Dersler
FOREIGN KEY (DersId) REFERENCES dbo.Dersler(Id);

ALTER TABLE dbo.YoklamaKayitleri
ADD CONSTRAINT FK_YoklamaKayitleri_Ogrenciler
FOREIGN KEY (OgrenciId) REFERENCES dbo.Ogrenciler(Id);

ALTER TABLE dbo.YoklamaKayitleri
ADD CONSTRAINT FK_YoklamaKayitleri_YoklamaOturumlari
FOREIGN KEY (OturumId) REFERENCES dbo.YoklamaOturumlari(OturumId);