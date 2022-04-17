CREATE PROC UserAdd
@U_ID int,
@Username varchar(50),
@Password varchar(50)
AS
   INSERT INTO SignUp(Username,Password)
   VALUES (@Username,@Password)

   