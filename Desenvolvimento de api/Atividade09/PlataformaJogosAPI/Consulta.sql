CREATE table categoria(
Id INT Identity(1,1) PRIMARY KEY,
Nome NVARCHAR(50),
Descricao NVARCHAR(50),
);
GO

CREATE table estudio(
Id INT Identity(1,1) PRIMARY KEY,
Nome NVARCHAR(50),
Pais NVARCHAR(50),

);
GO

CREATE table usuario(
Id INT Identity(1,1) PRIMARY KEY,
Email NVARCHAR(50),
Senha NVARCHAR(50)
);
GO