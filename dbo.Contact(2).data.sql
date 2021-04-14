SET IDENTITY_INSERT [dbo].[Contact] ON
INSERT INTO [dbo].[Contact] ([ContactId], [FirstName], [LastName], [MobileNum], [Email], [Address], [Notes], [DateOfBirth]) VALUES (1, N'Greta', N'Ivanauskaite', N'07403599535', N'greta.ivan@gmail.com', N'London', NULL, NULL)
INSERT INTO [dbo].[Contact] ([ContactId], [FirstName], [LastName], [MobileNum], [Email], [Address], [Notes], [DateOfBirth]) VALUES (2, N'Victoria', N'B', NULL, NULL, NULL, NULL, NULL)
INSERT INTO [dbo].[Contact] ([ContactId], [FirstName], [LastName], [MobileNum], [Email], [Address], [Notes], [DateOfBirth]) VALUES (3, N'James', N'Wilson', N'07591546548', N'j.wilsone@yahoo.com', N'NYC', N'no notes', N'1980-10-25')
INSERT INTO [dbo].[Contact] ([ContactId], [FirstName], [LastName], [MobileNum], [Email], [Address], [Notes], [DateOfBirth]) VALUES (4, N'Aron', N'Akens', N'012569874654', N'aron.akens@yahoo.com', NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Contact] OFF
