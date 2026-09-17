USE Automoveis;
GO

;WITH EstoqueNumerado AS
(
	SELECT
		Id,
		Tipo,
		ROW_NUMBER() OVER (PARTITION BY Tipo ORDER BY Id) AS NumeroFoto
	FROM dbo.Estoque
	WHERE Tipo IN (1, 2)
)
UPDATE Estoque
SET Foto = CASE EstoqueNumerado.Tipo
	WHEN 1 THEN N'C:\Users\Back\Documents\DEVBACKEND\Banco de Dados\Aula06\Cars\Fotos\Carros\Carro'
		+ CONVERT(nvarchar(10), EstoqueNumerado.NumeroFoto) + N'.jpg'
	WHEN 2 THEN N'C:\Users\Back\Documents\DEVBACKEND\Banco de Dados\Aula06\Cars\Fotos\Motos\Moto'
		+ CONVERT(nvarchar(10), EstoqueNumerado.NumeroFoto) + N'.jpg'
END
FROM dbo.Estoque AS Estoque
INNER JOIN EstoqueNumerado
	ON Estoque.Id = EstoqueNumerado.Id;
GO
