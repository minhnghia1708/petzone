USE [accountlogin]
GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 1/6/2022 10:29:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[UserName] [varchar](20) NOT NULL,
	[Password] [varchar](20) NULL,
 CONSTRAINT [PK_NguoiDung] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[Sp_Account_Login]    Script Date: 1/6/2022 10:29:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_Account_Login] 
	-- Add the parameters for the stored procedure here
	@UserName varchar(20),
	@Password varchar(20)
AS
BEGIN
	declare @count int
	declare @res bit
	select @count = count (*) from NguoiDung where UserName = @UserName and Password = @Password
	if @count > 0 
		set @res = 1
	else
		set @res = 0
	select @res
END
GO
