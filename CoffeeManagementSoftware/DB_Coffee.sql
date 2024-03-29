USE [DB_Coffee]
GO
/****** Object:  Table [dbo].[account]    Script Date: 12/1/2019 10:11:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[account](
	[ID] [int] NOT NULL,
	[USERNAME] [varchar](50) NULL,
	[PASSWORD] [varchar](50) NULL,
	[STATUS] [int] NULL,
 CONSTRAINT [PK_account] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[area]    Script Date: 12/1/2019 10:11:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[area](
	[ID] [int] NOT NULL,
	[NAME_AREA] [nvarchar](50) NULL,
	[STATUS] [int] NULL,
 CONSTRAINT [PK_area] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[convert]    Script Date: 12/1/2019 10:11:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[convert](
	[ID] [int] NOT NULL,
	[NAME_UNIT_BEFORE] [nvarchar](50) NULL,
	[NUMBER_BEFORE] [float] NULL,
	[NAME_UNIT_AFTER] [nvarchar](50) NULL,
	[NUMBER_AFTER] [float] NULL,
	[STATUS] [int] NULL,
 CONSTRAINT [PK_convert] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[detail_receipt]    Script Date: 12/1/2019 10:11:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detail_receipt](
	[ID_RECEIPT] [int] NOT NULL,
	[ID_ITEM] [int] NOT NULL,
	[ID_TABLE] [int] NULL,
	[NUMBER] [int] NOT NULL,
	[STATUS] [int] NOT NULL,
 CONSTRAINT [PK_detail_receipt_1] PRIMARY KEY CLUSTERED 
(
	[ID_RECEIPT] ASC,
	[ID_ITEM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[detail_receipt_import]    Script Date: 12/1/2019 10:11:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detail_receipt_import](
	[ID_RECEIPT_IMPORT] [int] NOT NULL,
	[ID_ITEM] [int] NOT NULL,
	[NUMBER] [int] NOT NULL,
	[STATUS] [int] NULL,
 CONSTRAINT [PK_detail_receipt_import_1] PRIMARY KEY CLUSTERED 
(
	[ID_RECEIPT_IMPORT] ASC,
	[ID_ITEM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[grant_right]    Script Date: 12/1/2019 10:11:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[grant_right](
	[ID_GROUP] [int] NOT NULL,
	[ID_SCREEN] [varchar](5) NOT NULL,
	[ROLE] [bit] NULL,
 CONSTRAINT [PK_grant_right] PRIMARY KEY CLUSTERED 
(
	[ID_GROUP] ASC,
	[ID_SCREEN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[group_user]    Script Date: 12/1/2019 10:11:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[group_user](
	[ID] [int] NOT NULL,
	[NAME_GROUP] [nvarchar](50) NULL,
	[STATUS] [int] NULL,
 CONSTRAINT [PK_group_user] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[inventory]    Script Date: 12/1/2019 10:11:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[inventory](
	[ID] [int] NOT NULL,
	[ID_ITEM] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[item]    Script Date: 12/1/2019 10:11:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[item](
	[ID] [int] NOT NULL,
	[NAME_ITEM] [nvarchar](250) NULL,
	[UNIT] [nvarchar](50) NULL,
	[PRICE_SELL] [float] NULL,
	[PRICE_PURCHASE] [float] NULL,
	[ID_TYPE_ITEM] [int] NULL,
	[NUMBER] [int] NULL,
	[STATUS] [int] NULL,
 CONSTRAINT [PK_item] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[profile]    Script Date: 12/1/2019 10:11:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[profile](
	[ID] [int] NOT NULL,
	[ID_ACCOUNT] [int] NULL,
	[ID_TYPE_CUSTOMER] [int] NULL,
	[IDENTIFICATION] [varchar](12) NULL,
	[LAST_NAME] [nvarchar](50) NULL,
	[FIRST_NAME] [nvarchar](50) NULL,
	[PHONE] [char](10) NULL,
	[ADDRESS] [nvarchar](50) NULL,
	[SEX] [nvarchar](5) NULL,
	[EMAIL] [nvarchar](50) NULL,
 CONSTRAINT [PK_profile] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[profile_staff]    Script Date: 12/1/2019 10:11:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[profile_staff](
	[ID] [int] NOT NULL,
	[ID_TIMEKEEPING] [int] NULL,
	[NAME_STAFF] [nvarchar](50) NULL,
	[STATUS] [int] NULL,
 CONSTRAINT [PK_profile_staff] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[receipt]    Script Date: 12/1/2019 10:11:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[receipt](
	[ID] [int] NOT NULL,
	[ID_ACCOUNT] [int] NOT NULL,
	[CREATE_AT] [date] NOT NULL,
	[SUM_MONEY] [float] NULL,
	[STATUS] [int] NULL,
 CONSTRAINT [PK_receipt] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[receipt_import]    Script Date: 12/1/2019 10:11:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[receipt_import](
	[ID] [int] NOT NULL,
	[ID_SUPPLIER] [int] NULL,
	[ID_ACCOUNT] [int] NULL,
	[CREATE_AT] [date] NULL,
	[SUM_MONEY] [float] NULL,
	[STATUS] [int] NULL,
 CONSTRAINT [PK_receipt_import] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[screen]    Script Date: 12/1/2019 10:11:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[screen](
	[ID] [varchar](5) NOT NULL,
	[NAME_SCREEN] [nvarchar](50) NULL,
	[STATUS] [int] NULL,
 CONSTRAINT [PK_screen] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[supplier]    Script Date: 12/1/2019 10:11:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[supplier](
	[ID] [int] NOT NULL,
	[NAME] [varchar](500) NULL,
	[ADDRESS] [varchar](250) NULL,
	[PHONE] [char](10) NULL,
	[EMAIL] [varchar](100) NULL,
	[STATUS] [int] NULL,
 CONSTRAINT [PK_supplier] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[table]    Script Date: 12/1/2019 10:11:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[table](
	[ID] [int] NOT NULL,
	[ID_AREA] [int] NULL,
	[NAME_TABLE] [nvarchar](50) NULL,
	[STATUS] [int] NULL,
 CONSTRAINT [PK_table] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[timekeeping]    Script Date: 12/1/2019 10:11:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[timekeeping](
	[ID] [int] NOT NULL,
	[ID_ACCOUNT] [int] NULL,
	[SHIFT] [nvarchar](50) NULL,
	[STATUS] [int] NULL,
 CONSTRAINT [PK_timekeeping] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[type_customer]    Script Date: 12/1/2019 10:11:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[type_customer](
	[ID] [int] NOT NULL,
	[NAME_TYPE] [nvarchar](50) NULL,
	[STATUS] [int] NULL,
 CONSTRAINT [PK_type_customer] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[type_item]    Script Date: 12/1/2019 10:11:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[type_item](
	[ID] [int] NOT NULL,
	[NAME_TYPE] [nvarchar](100) NULL,
	[STATUS] [nchar](10) NULL,
 CONSTRAINT [PK_type_item] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[user_group_user]    Script Date: 12/1/2019 10:11:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user_group_user](
	[ID_ACCOUNT] [int] NOT NULL,
	[ID_GROUP] [int] NOT NULL,
	[STATUS] [int] NULL,
 CONSTRAINT [PK_user_group_user] PRIMARY KEY CLUSTERED 
(
	[ID_ACCOUNT] ASC,
	[ID_GROUP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[account] ([ID], [USERNAME], [PASSWORD], [STATUS]) VALUES (1, N'admin', N'123', 1)
INSERT [dbo].[account] ([ID], [USERNAME], [PASSWORD], [STATUS]) VALUES (2, N'user', N'123', 1)
INSERT [dbo].[area] ([ID], [NAME_AREA], [STATUS]) VALUES (1, N'Tan Phu', 1)
INSERT [dbo].[area] ([ID], [NAME_AREA], [STATUS]) VALUES (2, N'Binh Thanh', 1)
INSERT [dbo].[grant_right] ([ID_GROUP], [ID_SCREEN], [ROLE]) VALUES (1, N'T111', 0)
INSERT [dbo].[grant_right] ([ID_GROUP], [ID_SCREEN], [ROLE]) VALUES (1, N'T112', 0)
INSERT [dbo].[grant_right] ([ID_GROUP], [ID_SCREEN], [ROLE]) VALUES (1, N'T113', 0)
INSERT [dbo].[grant_right] ([ID_GROUP], [ID_SCREEN], [ROLE]) VALUES (1, N'T13', 0)
INSERT [dbo].[grant_right] ([ID_GROUP], [ID_SCREEN], [ROLE]) VALUES (1, N'T14', 0)
INSERT [dbo].[grant_right] ([ID_GROUP], [ID_SCREEN], [ROLE]) VALUES (1, N'T21', 1)
INSERT [dbo].[grant_right] ([ID_GROUP], [ID_SCREEN], [ROLE]) VALUES (1, N'T23', 1)
INSERT [dbo].[grant_right] ([ID_GROUP], [ID_SCREEN], [ROLE]) VALUES (1, N'T24', 1)
INSERT [dbo].[grant_right] ([ID_GROUP], [ID_SCREEN], [ROLE]) VALUES (1, N'T25', 1)
INSERT [dbo].[grant_right] ([ID_GROUP], [ID_SCREEN], [ROLE]) VALUES (1, N'T26', 1)
INSERT [dbo].[grant_right] ([ID_GROUP], [ID_SCREEN], [ROLE]) VALUES (1, N'T27', 1)
INSERT [dbo].[grant_right] ([ID_GROUP], [ID_SCREEN], [ROLE]) VALUES (1, N'T28', 1)
INSERT [dbo].[grant_right] ([ID_GROUP], [ID_SCREEN], [ROLE]) VALUES (1, N'T29', 1)
INSERT [dbo].[grant_right] ([ID_GROUP], [ID_SCREEN], [ROLE]) VALUES (1, N'T291', 1)
INSERT [dbo].[grant_right] ([ID_GROUP], [ID_SCREEN], [ROLE]) VALUES (2, N'T111', 1)
INSERT [dbo].[grant_right] ([ID_GROUP], [ID_SCREEN], [ROLE]) VALUES (2, N'T112', 1)
INSERT [dbo].[grant_right] ([ID_GROUP], [ID_SCREEN], [ROLE]) VALUES (2, N'T113', 1)
INSERT [dbo].[grant_right] ([ID_GROUP], [ID_SCREEN], [ROLE]) VALUES (2, N'T13', 1)
INSERT [dbo].[grant_right] ([ID_GROUP], [ID_SCREEN], [ROLE]) VALUES (2, N'T14', 1)
INSERT [dbo].[grant_right] ([ID_GROUP], [ID_SCREEN], [ROLE]) VALUES (2, N'T21', 0)
INSERT [dbo].[grant_right] ([ID_GROUP], [ID_SCREEN], [ROLE]) VALUES (2, N'T23', 0)
INSERT [dbo].[grant_right] ([ID_GROUP], [ID_SCREEN], [ROLE]) VALUES (2, N'T24', 0)
INSERT [dbo].[grant_right] ([ID_GROUP], [ID_SCREEN], [ROLE]) VALUES (2, N'T25', 0)
INSERT [dbo].[grant_right] ([ID_GROUP], [ID_SCREEN], [ROLE]) VALUES (2, N'T26', 0)
INSERT [dbo].[grant_right] ([ID_GROUP], [ID_SCREEN], [ROLE]) VALUES (2, N'T27', 0)
INSERT [dbo].[grant_right] ([ID_GROUP], [ID_SCREEN], [ROLE]) VALUES (2, N'T28', 0)
INSERT [dbo].[grant_right] ([ID_GROUP], [ID_SCREEN], [ROLE]) VALUES (2, N'T29', 0)
INSERT [dbo].[grant_right] ([ID_GROUP], [ID_SCREEN], [ROLE]) VALUES (2, N'T291', 0)
INSERT [dbo].[group_user] ([ID], [NAME_GROUP], [STATUS]) VALUES (1, N'Bán Hàng', 1)
INSERT [dbo].[group_user] ([ID], [NAME_GROUP], [STATUS]) VALUES (2, N'Quản Lý', 1)
INSERT [dbo].[inventory] ([ID], [ID_ITEM]) VALUES (1, 1)
INSERT [dbo].[item] ([ID], [NAME_ITEM], [UNIT], [PRICE_SELL], [PRICE_PURCHASE], [ID_TYPE_ITEM], [NUMBER], [STATUS]) VALUES (1, N'b33', N'Ly', 12, 10, 1, 0, 1)
INSERT [dbo].[item] ([ID], [NAME_ITEM], [UNIT], [PRICE_SELL], [PRICE_PURCHASE], [ID_TYPE_ITEM], [NUMBER], [STATUS]) VALUES (2, N'b34', N'Ly', 17, 10, 1, 0, 1)
INSERT [dbo].[item] ([ID], [NAME_ITEM], [UNIT], [PRICE_SELL], [PRICE_PURCHASE], [ID_TYPE_ITEM], [NUMBER], [STATUS]) VALUES (3, N'B54', N'Chai', 12, 10, 3, 0, 1)
INSERT [dbo].[item] ([ID], [NAME_ITEM], [UNIT], [PRICE_SELL], [PRICE_PURCHASE], [ID_TYPE_ITEM], [NUMBER], [STATUS]) VALUES (4, N'Bia', N'Chai', 12, 10, 3, 0, 1)
INSERT [dbo].[profile] ([ID], [ID_ACCOUNT], [ID_TYPE_CUSTOMER], [IDENTIFICATION], [LAST_NAME], [FIRST_NAME], [PHONE], [ADDRESS], [SEX], [EMAIL]) VALUES (1, NULL, 2, NULL, N'Nguyen', N'Loc', N'0326646287', N'ada', NULL, N'ada@gmail.com')
INSERT [dbo].[profile] ([ID], [ID_ACCOUNT], [ID_TYPE_CUSTOMER], [IDENTIFICATION], [LAST_NAME], [FIRST_NAME], [PHONE], [ADDRESS], [SEX], [EMAIL]) VALUES (2, NULL, 1, NULL, N'Nguyen', N'Quu', N'0000000000', N'adaasd', NULL, N'adaadasda@gmail.com')
INSERT [dbo].[profile] ([ID], [ID_ACCOUNT], [ID_TYPE_CUSTOMER], [IDENTIFICATION], [LAST_NAME], [FIRST_NAME], [PHONE], [ADDRESS], [SEX], [EMAIL]) VALUES (3, NULL, 2, NULL, N'Nguyen', N'Hieu', N'0326646287', N'ada', NULL, N'ada@gmail.com')
INSERT [dbo].[profile_staff] ([ID], [ID_TIMEKEEPING], [NAME_STAFF], [STATUS]) VALUES (1, 1, N'Nguyen Van A', 1)
INSERT [dbo].[profile_staff] ([ID], [ID_TIMEKEEPING], [NAME_STAFF], [STATUS]) VALUES (2, 2, N'Nguyen Van A', 1)
INSERT [dbo].[profile_staff] ([ID], [ID_TIMEKEEPING], [NAME_STAFF], [STATUS]) VALUES (3, 1, N'Nguyen Van B', 1)
INSERT [dbo].[profile_staff] ([ID], [ID_TIMEKEEPING], [NAME_STAFF], [STATUS]) VALUES (4, 1, N'Nguyen Van C', 1)
INSERT [dbo].[screen] ([ID], [NAME_SCREEN], [STATUS]) VALUES (N'T111', N'Tạo mới CSDL', 1)
INSERT [dbo].[screen] ([ID], [NAME_SCREEN], [STATUS]) VALUES (N'T112', N'Sao lưu CSDL', 1)
INSERT [dbo].[screen] ([ID], [NAME_SCREEN], [STATUS]) VALUES (N'T113', N'Phục hồi CSDL', 1)
INSERT [dbo].[screen] ([ID], [NAME_SCREEN], [STATUS]) VALUES (N'T13', N'Phân Nhóm Người Dùng', 1)
INSERT [dbo].[screen] ([ID], [NAME_SCREEN], [STATUS]) VALUES (N'T14', N'Phân Quyền Nhóm Người Dùng', 1)
INSERT [dbo].[screen] ([ID], [NAME_SCREEN], [STATUS]) VALUES (N'T21', N'Danh mục khách hàng', 1)
INSERT [dbo].[screen] ([ID], [NAME_SCREEN], [STATUS]) VALUES (N'T23', N'Danh mục mặt hàng', 1)
INSERT [dbo].[screen] ([ID], [NAME_SCREEN], [STATUS]) VALUES (N'T24', N'Danh mục bàn, ghế', 1)
INSERT [dbo].[screen] ([ID], [NAME_SCREEN], [STATUS]) VALUES (N'T25', N'Sử dụng dịch vụ', 1)
INSERT [dbo].[screen] ([ID], [NAME_SCREEN], [STATUS]) VALUES (N'T26', N'Quản lý bán hàng', 1)
INSERT [dbo].[screen] ([ID], [NAME_SCREEN], [STATUS]) VALUES (N'T27', N'Kiểm soát hóa đơn', 1)
INSERT [dbo].[screen] ([ID], [NAME_SCREEN], [STATUS]) VALUES (N'T28', N'Lưu vết hoạt động', 1)
INSERT [dbo].[screen] ([ID], [NAME_SCREEN], [STATUS]) VALUES (N'T29', N'Thống kê doanh thu', 1)
INSERT [dbo].[screen] ([ID], [NAME_SCREEN], [STATUS]) VALUES (N'T291', N'Thống kê ăn, uống', 1)
INSERT [dbo].[supplier] ([ID], [NAME], [ADDRESS], [PHONE], [EMAIL], [STATUS]) VALUES (1, N'Quoc', N'ABC', N'0326646287', N'quoc@gmail.com', 1)
INSERT [dbo].[supplier] ([ID], [NAME], [ADDRESS], [PHONE], [EMAIL], [STATUS]) VALUES (2, N'a', N'ad', N'0000000000', N'a@gmail.com', 1)
INSERT [dbo].[table] ([ID], [ID_AREA], [NAME_TABLE], [STATUS]) VALUES (1, 1, N'Ban 1', 1)
INSERT [dbo].[table] ([ID], [ID_AREA], [NAME_TABLE], [STATUS]) VALUES (2, 1, N'Ban 2', 1)
INSERT [dbo].[table] ([ID], [ID_AREA], [NAME_TABLE], [STATUS]) VALUES (3, 1, N'Ban 3', 1)
INSERT [dbo].[timekeeping] ([ID], [ID_ACCOUNT], [SHIFT], [STATUS]) VALUES (1, 1, N'Sang', 1)
INSERT [dbo].[timekeeping] ([ID], [ID_ACCOUNT], [SHIFT], [STATUS]) VALUES (2, 1, N'Chieu', 1)
INSERT [dbo].[type_customer] ([ID], [NAME_TYPE], [STATUS]) VALUES (1, N'Đồng', 1)
INSERT [dbo].[type_customer] ([ID], [NAME_TYPE], [STATUS]) VALUES (2, N'Bác', 1)
INSERT [dbo].[type_customer] ([ID], [NAME_TYPE], [STATUS]) VALUES (3, N'Vàng', 1)
INSERT [dbo].[type_item] ([ID], [NAME_TYPE], [STATUS]) VALUES (1, N'Cafe-da', N'1         ')
INSERT [dbo].[type_item] ([ID], [NAME_TYPE], [STATUS]) VALUES (2, N'Cafe-Sua', N'1         ')
INSERT [dbo].[type_item] ([ID], [NAME_TYPE], [STATUS]) VALUES (3, N'Cacao', N'1         ')
INSERT [dbo].[type_item] ([ID], [NAME_TYPE], [STATUS]) VALUES (4, N'Sua', N'1         ')
INSERT [dbo].[type_item] ([ID], [NAME_TYPE], [STATUS]) VALUES (5, N'Gao', N'1         ')
INSERT [dbo].[type_item] ([ID], [NAME_TYPE], [STATUS]) VALUES (6, N'Da', N'1         ')
INSERT [dbo].[user_group_user] ([ID_ACCOUNT], [ID_GROUP], [STATUS]) VALUES (1, 1, 1)
INSERT [dbo].[user_group_user] ([ID_ACCOUNT], [ID_GROUP], [STATUS]) VALUES (1, 2, 1)
ALTER TABLE [dbo].[detail_receipt]  WITH CHECK ADD  CONSTRAINT [FK_detail_receipt_item] FOREIGN KEY([ID_ITEM])
REFERENCES [dbo].[item] ([ID])
GO
ALTER TABLE [dbo].[detail_receipt] CHECK CONSTRAINT [FK_detail_receipt_item]
GO
ALTER TABLE [dbo].[detail_receipt]  WITH CHECK ADD  CONSTRAINT [FK_detail_receipt_receipt] FOREIGN KEY([ID_RECEIPT])
REFERENCES [dbo].[receipt] ([ID])
GO
ALTER TABLE [dbo].[detail_receipt] CHECK CONSTRAINT [FK_detail_receipt_receipt]
GO
ALTER TABLE [dbo].[detail_receipt]  WITH CHECK ADD  CONSTRAINT [FK_detail_receipt_table] FOREIGN KEY([ID_ITEM])
REFERENCES [dbo].[table] ([ID])
GO
ALTER TABLE [dbo].[detail_receipt] CHECK CONSTRAINT [FK_detail_receipt_table]
GO
ALTER TABLE [dbo].[detail_receipt_import]  WITH CHECK ADD  CONSTRAINT [FK_detail_receipt_import_item] FOREIGN KEY([ID_ITEM])
REFERENCES [dbo].[item] ([ID])
GO
ALTER TABLE [dbo].[detail_receipt_import] CHECK CONSTRAINT [FK_detail_receipt_import_item]
GO
ALTER TABLE [dbo].[detail_receipt_import]  WITH CHECK ADD  CONSTRAINT [FK_detail_receipt_import_receipt_import] FOREIGN KEY([ID_RECEIPT_IMPORT])
REFERENCES [dbo].[receipt_import] ([ID])
GO
ALTER TABLE [dbo].[detail_receipt_import] CHECK CONSTRAINT [FK_detail_receipt_import_receipt_import]
GO
ALTER TABLE [dbo].[grant_right]  WITH CHECK ADD  CONSTRAINT [FK_grant_right_group_user] FOREIGN KEY([ID_GROUP])
REFERENCES [dbo].[group_user] ([ID])
GO
ALTER TABLE [dbo].[grant_right] CHECK CONSTRAINT [FK_grant_right_group_user]
GO
ALTER TABLE [dbo].[grant_right]  WITH CHECK ADD  CONSTRAINT [FK_grant_right_screen] FOREIGN KEY([ID_SCREEN])
REFERENCES [dbo].[screen] ([ID])
GO
ALTER TABLE [dbo].[grant_right] CHECK CONSTRAINT [FK_grant_right_screen]
GO
ALTER TABLE [dbo].[inventory]  WITH CHECK ADD  CONSTRAINT [FK_inventory_item] FOREIGN KEY([ID_ITEM])
REFERENCES [dbo].[item] ([ID])
GO
ALTER TABLE [dbo].[inventory] CHECK CONSTRAINT [FK_inventory_item]
GO
ALTER TABLE [dbo].[item]  WITH CHECK ADD  CONSTRAINT [FK_item_type_item] FOREIGN KEY([ID_TYPE_ITEM])
REFERENCES [dbo].[type_item] ([ID])
GO
ALTER TABLE [dbo].[item] CHECK CONSTRAINT [FK_item_type_item]
GO
ALTER TABLE [dbo].[profile]  WITH CHECK ADD  CONSTRAINT [FK_profile_account] FOREIGN KEY([ID_ACCOUNT])
REFERENCES [dbo].[account] ([ID])
GO
ALTER TABLE [dbo].[profile] CHECK CONSTRAINT [FK_profile_account]
GO
ALTER TABLE [dbo].[profile]  WITH CHECK ADD  CONSTRAINT [FK_profile_type_customer] FOREIGN KEY([ID_TYPE_CUSTOMER])
REFERENCES [dbo].[type_customer] ([ID])
GO
ALTER TABLE [dbo].[profile] CHECK CONSTRAINT [FK_profile_type_customer]
GO
ALTER TABLE [dbo].[profile_staff]  WITH CHECK ADD  CONSTRAINT [FK_profile_staff_timekeeping] FOREIGN KEY([ID_TIMEKEEPING])
REFERENCES [dbo].[timekeeping] ([ID])
GO
ALTER TABLE [dbo].[profile_staff] CHECK CONSTRAINT [FK_profile_staff_timekeeping]
GO
ALTER TABLE [dbo].[receipt]  WITH CHECK ADD  CONSTRAINT [FK_receipt_account] FOREIGN KEY([ID_ACCOUNT])
REFERENCES [dbo].[account] ([ID])
GO
ALTER TABLE [dbo].[receipt] CHECK CONSTRAINT [FK_receipt_account]
GO
ALTER TABLE [dbo].[receipt_import]  WITH CHECK ADD  CONSTRAINT [FK_receipt_import_account] FOREIGN KEY([ID_ACCOUNT])
REFERENCES [dbo].[account] ([ID])
GO
ALTER TABLE [dbo].[receipt_import] CHECK CONSTRAINT [FK_receipt_import_account]
GO
ALTER TABLE [dbo].[receipt_import]  WITH CHECK ADD  CONSTRAINT [FK_receipt_import_supplier] FOREIGN KEY([ID_SUPPLIER])
REFERENCES [dbo].[supplier] ([ID])
GO
ALTER TABLE [dbo].[receipt_import] CHECK CONSTRAINT [FK_receipt_import_supplier]
GO
ALTER TABLE [dbo].[table]  WITH CHECK ADD  CONSTRAINT [FK_table_area] FOREIGN KEY([ID_AREA])
REFERENCES [dbo].[area] ([ID])
GO
ALTER TABLE [dbo].[table] CHECK CONSTRAINT [FK_table_area]
GO
ALTER TABLE [dbo].[timekeeping]  WITH CHECK ADD  CONSTRAINT [FK_timekeeping_account] FOREIGN KEY([ID_ACCOUNT])
REFERENCES [dbo].[account] ([ID])
GO
ALTER TABLE [dbo].[timekeeping] CHECK CONSTRAINT [FK_timekeeping_account]
GO
ALTER TABLE [dbo].[user_group_user]  WITH CHECK ADD  CONSTRAINT [FK_user_group_user_account] FOREIGN KEY([ID_ACCOUNT])
REFERENCES [dbo].[account] ([ID])
GO
ALTER TABLE [dbo].[user_group_user] CHECK CONSTRAINT [FK_user_group_user_account]
GO
ALTER TABLE [dbo].[user_group_user]  WITH CHECK ADD  CONSTRAINT [FK_user_group_user_group_user] FOREIGN KEY([ID_GROUP])
REFERENCES [dbo].[group_user] ([ID])
GO
ALTER TABLE [dbo].[user_group_user] CHECK CONSTRAINT [FK_user_group_user_group_user]
GO
