If Object_Id('Usuario') Is Null 
BEGIN
  CREATE TABLE Usuario
  (
   Id INT  PRIMARY KEY,
   Nome VARCHAR(80),
   Endereco VARCHAR(100),
   Telefone VARCHAR(20)
  )
END
GO

