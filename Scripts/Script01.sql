USE conselho
GO

If Object_Id('TB_Teste') Is Null 
BEGIN
  CREATE TABLE TB_Teste (
  ID INT
)
END