If Not Exists (Select 1 From Usuario (Nolock) Where Nome = 'vinicius') 
Begin
	
	INSERT INTO Usuario VALUES (2,'vinicius','A','121212');
End
GO