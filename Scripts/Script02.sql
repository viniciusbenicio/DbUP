USE conselho
GO


If Object_Id('tb_update_nova') Is Null 
BEGIN
CREATE TABLE tb_update_nova (
  ID INT
)
END

GO