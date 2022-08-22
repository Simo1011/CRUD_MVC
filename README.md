# CRUD_MVC
MVC CRUD Operations Using Entity Framework Core
![image](https://user-images.githubusercontent.com/26320160/185974113-e47c64d9-2117-446b-aeec-6e88121cecb4.png)
![image](https://user-images.githubusercontent.com/26320160/185974307-975f5292-768c-4b5b-9707-1cf53f5c73bb.png)

SQl Script for the table :

CREATE TABLE [dbo].[Gadgets](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [varchar](max) NULL,
	[Brand] [varchar](max) NULL,
	[Cost] [decimal](18, 0) NOT NULL,
	[ImageName] [varchar](1024) NULL,
	[Type] [varchar](128) NULL)
