USE [ProductDB]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 3/24/2025 10:03:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[Price] [decimal](10, 2) NOT NULL,
	[Description] [nvarchar](500) NULL,
	[CreatedDate] [datetime] NULL,
 CONSTRAINT [PK__Products__3214EC07ACE4F28D] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([Id], [Name], [Price], [Description], [CreatedDate]) VALUES (2, N'Glaxy Z flip', CAST(30000.00 AS Decimal(10, 2)), N'smart phone by SamSaung', CAST(N'2025-03-21T17:35:51.947' AS DateTime))
INSERT [dbo].[Products] ([Id], [Name], [Price], [Description], [CreatedDate]) VALUES (3, N'iPhone 16', CAST(8999.00 AS Decimal(10, 2)), N'smart phone by Apple', CAST(N'2025-03-21T17:39:39.203' AS DateTime))
INSERT [dbo].[Products] ([Id], [Name], [Price], [Description], [CreatedDate]) VALUES (5, N'Oppo 12', CAST(100.00 AS Decimal(10, 2)), N'china phone', CAST(N'2025-03-21T18:16:45.513' AS DateTime))
INSERT [dbo].[Products] ([Id], [Name], [Price], [Description], [CreatedDate]) VALUES (6, N'Vivo 360', CAST(200.00 AS Decimal(10, 2)), N'china phone', CAST(N'2025-03-21T18:18:44.883' AS DateTime))
INSERT [dbo].[Products] ([Id], [Name], [Price], [Description], [CreatedDate]) VALUES (9, N'testing phone 1', CAST(200.00 AS Decimal(10, 2)), NULL, CAST(N'2025-03-24T10:00:16.760' AS DateTime))
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
