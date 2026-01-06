USE [AGPLucasG]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 2025-11-29 19:49:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NomeCliente] [nvarchar](max) NULL,
	[Referencia] [nvarchar](max) NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON 
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (192, N'Alfreds Futterkiste', N'12209 - Berlin Alemanha')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (193, N'Ana Trujillo Emparedados y helados', N'05021 - México D.F. México')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (194, N'Antonio Moreno Taquería', N'05023 - México D.F. México')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (195, N'Around the Horn', N'WA1 1DP - London RU')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (196, N'Berglunds snabbköp', N'S-958 22 - Luleå Suécia')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (197, N'Blauer See Delikatessen', N'68306 - Mannheim Alemanha')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (198, N'Blondel père et fils', N'67000 - Strasbourg França')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (199, N'Bólido Comidas preparadas', N'28023 - Madrid Espanha')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (200, N'Bon app''', N'13008 - Marseille França')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (201, N'Bottom-Dollar Markets', N'T2F 8M4 - Tsawassen Canadá')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (202, N'B''s Beverages', N'EC2 5NT - London RU')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (203, N'Cactus Comidas para llevar', N'1010 - Buenos Aires Argentina')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (204, N'Centro comercial Moctezuma', N'05022 - México D.F. Mexico')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (205, N'Chop-suey Chinese', N'3012 - Bern Suíça')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (206, N'Comércio Mineiro', N'05432-043 - São Paulo Brasil')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (207, N'Consolidated Holdings', N'WX1 6LT - London RU')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (208, N'Drachenblut Delikatessen', N'52066 - Aachen Alemanha')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (209, N'Du monde entier', N'44000 - Nantes França')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (210, N'Eastern Connection', N'WX3 6FW - London RU')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (211, N'Ernst Handel', N'8010 - Graz Áustria')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (212, N'Familia Arquibaldo', N'05442-030 - São Paulo Brasil')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (213, N'FISSA Fabrica Inter. Salchichas S.A.', N'28034 - Madrid Espanha')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (214, N'Folies gourmandes', N'59000 - Lille França')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (215, N'Folk och fä HB', N'S-844 67 - Bräcke Suécia')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (216, N'Frankenversand', N'80805 - München Alemanha')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (217, N'France restauration', N'44000 - Nantes França')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (218, N'Franchi S.p.A.', N'10100 - Torino Itália')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (219, N'Furia Bacalhau e Frutos do Mar', N'1675 - Lisboa Portugal')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (220, N'Galería del gastrónomo', N'08022 - Barcelona Espanha')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (221, N'Godos Cocina Típica', N'41101 - Sevilla Espanha')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (222, N'Gourmet Lanchonetes', N'04876-786 - Campinas Brasil')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (223, N'Great Lakes Food Market', N'97403 - Eugene EUA')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (224, N'GROSELLA-Restaurante', N'1081 - Caracas Venezuela')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (225, N'Hanari Carnes', N'05454-876 - Rio de Janeiro Brasil')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (226, N'HILARIÓN-Abastos', N'5022 - San Cristóbal Venezuela')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (227, N'Hungry Coyote Import Store', N'97827 - Elgin EUA')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (228, N'Hungry Owl All-Night Grocers', N' - Cork Irlanda')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (229, N'Island Trading', N'PO31 7PJ - Cowes RU')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (230, N'Königlich Essen', N'14776 - Brandenburg Alemanha')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (231, N'La corne d''abondance', N'78000 - Versailles França')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (232, N'La maison d''Asie', N'31000 - Toulouse França')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (233, N'Laughing Bacchus Wine Cellars', N'V3F 2K1 - Vancouver Canadá')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (234, N'Lazy K Kountry Store', N'99362 - Walla Walla EUA')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (235, N'Lehmanns Marktstand', N'60528 - Frankfurt a.M.  Alemanha')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (236, N'Let''s Stop N Shop', N'94117 - São Francisco EUA')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (237, N'LILA-Supermercado', N'3508 - Barquisimeto Venezuela')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (238, N'LINO-Delicateses', N'4980 - I. de Margarita Venezuela')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (239, N'Lonesome Pine Restaurant', N'97219 - Portland EUA')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (240, N'Magazzini Alimentari Riuniti', N'24100 - Bergamo Itália')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (241, N'Maison Dewey', N'B-1180 - Bruxelles Bélgica')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (242, N'Mère Paillarde', N'H1J 1C3 - Montréal Canadá')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (243, N'Morgenstern Gesundkost', N'04179 - Leipzig Alemanha')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (244, N'North/South', N'SW7 1RZ - London RU')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (245, N'Océano Atlántico Ltda.', N'1010 - Buenos Aires Argentina')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (246, N'Old World Delicatessen', N'99508 - Anchorage EUA')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (247, N'Ottilies Käseladen', N'50739 - Köln Alemanha')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (248, N'Paris spécialités', N'75012 - Paris França')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (249, N'Pericles Comidas clásicas', N'05033 - México D.F. México')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (250, N'Piccolo und mehr', N'5020 - Salzburg Áustria')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (251, N'Princesa Isabel Vinhos', N'1756 - Lisboa Portugal')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (252, N'Que Delícia', N'02389-673 - Rio de Janeiro Brasil')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (253, N'Queen Cozinha', N'05487-020 - São Paulo Brasil')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (254, N'QUICK-Stop', N'01307 - Cunewalde Alemanha')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (255, N'Rancho grande', N'1010 - Buenos Aires Argentina')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (256, N'Rattlesnake Canyon Grocery', N'87110 - Albuquerque EUA')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (257, N'Reggiani Caseifici', N'42100 - Reggio Emilia Itália')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (258, N'Ricardo Adocicados', N'02389-890 - Rio de Janeiro Brasil')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (259, N'Richter Supermarkt', N'1203 - Genève Suíça')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (260, N'Romero y tomillo', N'28001 - Madrid Espanha')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (261, N'Santé Gourmet', N'4110 - Stavern Noruega')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (262, N'Save-a-lot Markets', N'83720 - Boise EUA')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (263, N'Seven Seas Imports', N'OX15 4NB - London RU')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (264, N'Simons bistro', N'1734 - København Dinamarca')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (265, N'Spécialités du monde', N'75016 - Paris França')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (266, N'Split Rail Beer & Ale', N'82520 - Lander EUA')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (267, N'Suprêmes délices', N'B-6000 - Charleroi Bélgica')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (268, N'The Big Cheese', N'97201 - Portland EUA')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (269, N'The Cracker Box', N'59801 - Butte EUA')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (270, N'Toms Spezialitäten', N'44087 - Münster Alemanha')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (271, N'Tortuga Restaurante', N'05033 - México D.F. México')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (272, N'Tradição Hipermercados', N'05634-030 - São Paulo Brasil')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (273, N'Trail''s Head Gourmet Provisioners', N'98034 - Kirkland EUA')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (274, N'Vaffeljernet', N'8200 - Århus Dinamarca')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (275, N'Victuailles en stock', N'69004 - Lion França')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (276, N'Vins et alcools Chevalier', N'51100 - Reims França')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (277, N'Die Wandernde Kuh', N'70563 - Stuttgart Alemanha')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (278, N'Wartian Herkku', N'90110 - Oulu Finlândia')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (279, N'Wellington Importadora', N'08737-363 - Resende Brasil')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (280, N'White Clover Markets', N'98128 - Seattle EUA')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (281, N'Wilman Kala', N'21240 - Helsinki Finlândia')
GO
INSERT [dbo].[Clientes] ([Id], [NomeCliente], [Referencia]) VALUES (282, N'Wolski  Zajazd', N'01-012 - Warszawa Polónia')
GO
SET IDENTITY_INSERT [dbo].[Clientes] OFF
GO
