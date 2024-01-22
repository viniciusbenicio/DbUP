CREATE OR ALTER Procedure GetUsuario
(
   @UsuarioID  INT
)
AS
BEGIN 

 SELECT * FROM tb_teste
   WHERE id = @UsuarioID 
END