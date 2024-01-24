If Not Exists (Select 1 From Pedido (Nolock) Where Item = 'Iphone') 
Begin
	
	INSERT INTO Pedido VALUES (1,'Iphone',1,10,1);
End
GO