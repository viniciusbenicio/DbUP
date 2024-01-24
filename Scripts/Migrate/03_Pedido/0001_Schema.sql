If Object_Id('Pedido') Is Null 
BEGIN
  CREATE TABLE Pedido
  (
   Id INT  PRIMARY KEY,
   Item VARCHAR(50),
   Quantidade INT,
   Preco INT,
   IdUsuario INT,
   CONSTRAINT FK_Pedido_Usuario FOREIGN KEY (IdUsuario)  REFERENCES Usuario (Id)
  
   
  )
END
GO