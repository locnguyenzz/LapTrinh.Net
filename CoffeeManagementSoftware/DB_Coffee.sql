USE [DB_Coffee]
GO
/****** Object:  Table [dbo].[area]    Script Date: 10/17/2019 9:42:51 PM ******/
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
/****** Object:  Table [dbo].[convert]    Script Date: 10/17/2019 9:42:51 PM ******/
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
/****** Object:  Table [dbo].[detail_receipt]    Script Date: 10/17/2019 9:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detail_receipt](
	[ID] [int] NOT NULL,
	[ID_RECEIPT] [int] NOT NULL,
	[ID_ITEM] [int] NOT NULL,
	[ID_TABLE] [int] NULL,
	[NUMBER] [int] NOT NULL,
	[STATUS] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[detail_receipt_import]    Script Date: 10/17/2019 9:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detail_receipt_import](
	[ID] [int] NOT NULL,
	[ID_RECEIPT_IMPORT] [int] NULL,
	[ID_ITEM] [int] NULL,
	[NUMBER] [int] NOT NULL,
	[STATUS] [int] NULL,
 CONSTRAINT [PK_detail_receipt_import] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[grant_right]    Script Date: 10/17/2019 9:42:51 PM ******/
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
/****** Object:  Table [dbo].[group_user]    Script Date: 10/17/2019 9:42:51 PM ******/
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
/****** Object:  Table [dbo].[item]    Script Date: 10/17/2019 9:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[item](
	[ID] [int] NOT NULL,
	[NAME_ITEM] [nvarchar](250) NULL,
	[UNIT] [nvarchar](50) NULL,
	[ID_TYPE_ITEM] [int] NULL,
	[ID_PRODUCER] [int] NULL,
	[ID_PRICE] [int] NULL,
	[DEADLINE] [date] NULL,
	[DETAIL] [text] NULL,
	[STATUS] [int] NULL,
 CONSTRAINT [PK_item] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[price]    Script Date: 10/17/2019 9:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[price](
	[ID] [int] NOT NULL,
	[PRICE] [float] NULL,
	[TYPE] [int] NULL,
	[CREATE_AT] [datetime] NULL,
	[STATUS] [int] NULL,
 CONSTRAINT [PK_price] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[producer]    Script Date: 10/17/2019 9:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[producer](
	[ID] [int] NOT NULL,
	[CODE_PRODUCER] [varchar](50) NULL,
	[NAME_PRODUCER] [nvarchar](100) NULL,
	[ADDRESS] [nvarchar](100) NULL,
	[PHONE] [char](10) NULL,
	[EMAIL] [varchar](100) NULL,
	[WEBSITE] [varchar](500) NULL,
	[STATUS] [nchar](10) NULL,
 CONSTRAINT [PK_producer] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[profile]    Script Date: 10/17/2019 9:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[profile](
	[ID] [int] NOT NULL,
	[ID_USER] [int] NOT NULL,
	[IDENTIFICATION] [varchar](12) NULL,
	[LAST_NAME] [nvarchar](50) NULL,
	[FIRST_NAME] [nvarchar](50) NULL,
	[PHONE] [char](10) NULL,
	[ADDRESS] [nvarchar](50) NULL,
	[SEX] [nvarchar](5) NULL,
 CONSTRAINT [PK_profile] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[profile_customer]    Script Date: 10/17/2019 9:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[profile_customer](
	[ID] [int] NOT NULL,
	[ID_PROFILE] [int] NOT NULL,
	[ID_TYPE_CUSTOMER] [int] NULL,
	[SCORE] [int] NULL,
	[STATUS] [int] NULL,
 CONSTRAINT [PK_profile_customer] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[profile_staff]    Script Date: 10/17/2019 9:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[profile_staff](
	[ID] [int] NOT NULL,
	[ID_PROFILE] [int] NOT NULL,
	[POSITION] [nvarchar](50) NULL,
	[STATUS] [int] NULL,
 CONSTRAINT [PK_profile_staff] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[receipt]    Script Date: 10/17/2019 9:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[receipt](
	[ID] [int] NOT NULL,
	[CODE_RECEIPT] [varchar](50) NOT NULL,
	[ID_USER_STAFF] [int] NOT NULL,
	[ID_USER_CUSTOMER] [int] NOT NULL,
	[CREATE_AT] [date] NOT NULL,
	[SUM_MONEY] [float] NULL,
	[STATUS] [int] NULL,
 CONSTRAINT [PK_receipt] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[receipt_import]    Script Date: 10/17/2019 9:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[receipt_import](
	[ID] [int] NOT NULL,
	[CODE_IMPORT] [varchar](50) NULL,
	[ID_SUPPLIER] [int] NULL,
	[ID_USER] [int] NULL,
	[CREATE_AT] [date] NULL,
	[SUM_MONEY] [float] NULL,
	[STATUS] [int] NULL,
 CONSTRAINT [PK_receipt_import] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[screen]    Script Date: 10/17/2019 9:42:51 PM ******/
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
/****** Object:  Table [dbo].[supplier]    Script Date: 10/17/2019 9:42:51 PM ******/
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
/****** Object:  Table [dbo].[table]    Script Date: 10/17/2019 9:42:51 PM ******/
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
/****** Object:  Table [dbo].[timekeeping]    Script Date: 10/17/2019 9:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[timekeeping](
	[ID] [int] NOT NULL,
	[ID_USER] [int] NOT NULL,
	[DATE] [date] NOT NULL,
	[SHIFT] [int] NOT NULL,
	[STATUS] [int] NOT NULL,
 CONSTRAINT [PK_timekeeping] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[type_customer]    Script Date: 10/17/2019 9:42:51 PM ******/
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
/****** Object:  Table [dbo].[type_item]    Script Date: 10/17/2019 9:42:51 PM ******/
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
/****** Object:  Table [dbo].[user]    Script Date: 10/17/2019 9:42:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[user](
	[ID] [int] NOT NULL,
	[USER_NAME] [varchar](50) NOT NULL,
	[PASSWORD] [varchar](50) NOT NULL,
	[STATUS] [int] NULL,
 CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[user_group_user]    Script Date: 10/17/2019 9:42:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user_group_user](
	[ID_USER] [int] NOT NULL,
	[ID_GROUP] [int] NOT NULL,
	[STATUS] [int] NULL,
 CONSTRAINT [PK_user_group_user] PRIMARY KEY CLUSTERED 
(
	[ID_USER] ASC,
	[ID_GROUP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
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
ALTER TABLE [dbo].[item]  WITH CHECK ADD  CONSTRAINT [FK_item_price] FOREIGN KEY([ID_PRICE])
REFERENCES [dbo].[price] ([ID])
GO
ALTER TABLE [dbo].[item] CHECK CONSTRAINT [FK_item_price]
GO
ALTER TABLE [dbo].[item]  WITH CHECK ADD  CONSTRAINT [FK_item_producer] FOREIGN KEY([ID_PRODUCER])
REFERENCES [dbo].[producer] ([ID])
GO
ALTER TABLE [dbo].[item] CHECK CONSTRAINT [FK_item_producer]
GO
ALTER TABLE [dbo].[item]  WITH CHECK ADD  CONSTRAINT [FK_item_type_item] FOREIGN KEY([ID_TYPE_ITEM])
REFERENCES [dbo].[type_item] ([ID])
GO
ALTER TABLE [dbo].[item] CHECK CONSTRAINT [FK_item_type_item]
GO
ALTER TABLE [dbo].[profile]  WITH CHECK ADD  CONSTRAINT [FK_profile_user] FOREIGN KEY([ID_USER])
REFERENCES [dbo].[user] ([ID])
GO
ALTER TABLE [dbo].[profile] CHECK CONSTRAINT [FK_profile_user]
GO
ALTER TABLE [dbo].[profile_customer]  WITH CHECK ADD  CONSTRAINT [FK_profile_customer_profile] FOREIGN KEY([ID_PROFILE])
REFERENCES [dbo].[profile] ([ID])
GO
ALTER TABLE [dbo].[profile_customer] CHECK CONSTRAINT [FK_profile_customer_profile]
GO
ALTER TABLE [dbo].[profile_customer]  WITH CHECK ADD  CONSTRAINT [FK_profile_customer_type_customer] FOREIGN KEY([ID_TYPE_CUSTOMER])
REFERENCES [dbo].[type_customer] ([ID])
GO
ALTER TABLE [dbo].[profile_customer] CHECK CONSTRAINT [FK_profile_customer_type_customer]
GO
ALTER TABLE [dbo].[profile_staff]  WITH CHECK ADD  CONSTRAINT [FK_profile_staff_profile] FOREIGN KEY([ID_PROFILE])
REFERENCES [dbo].[profile] ([ID])
GO
ALTER TABLE [dbo].[profile_staff] CHECK CONSTRAINT [FK_profile_staff_profile]
GO
ALTER TABLE [dbo].[receipt]  WITH CHECK ADD  CONSTRAINT [FK_receipt_user] FOREIGN KEY([ID_USER_STAFF])
REFERENCES [dbo].[user] ([ID])
GO
ALTER TABLE [dbo].[receipt] CHECK CONSTRAINT [FK_receipt_user]
GO
ALTER TABLE [dbo].[receipt]  WITH CHECK ADD  CONSTRAINT [FK_receipt_user1] FOREIGN KEY([ID_USER_CUSTOMER])
REFERENCES [dbo].[user] ([ID])
GO
ALTER TABLE [dbo].[receipt] CHECK CONSTRAINT [FK_receipt_user1]
GO
ALTER TABLE [dbo].[receipt_import]  WITH CHECK ADD  CONSTRAINT [FK_receipt_import_supplier] FOREIGN KEY([ID_SUPPLIER])
REFERENCES [dbo].[supplier] ([ID])
GO
ALTER TABLE [dbo].[receipt_import] CHECK CONSTRAINT [FK_receipt_import_supplier]
GO
ALTER TABLE [dbo].[receipt_import]  WITH CHECK ADD  CONSTRAINT [FK_receipt_import_user] FOREIGN KEY([ID_USER])
REFERENCES [dbo].[user] ([ID])
GO
ALTER TABLE [dbo].[receipt_import] CHECK CONSTRAINT [FK_receipt_import_user]
GO
ALTER TABLE [dbo].[table]  WITH CHECK ADD  CONSTRAINT [FK_table_area] FOREIGN KEY([ID_AREA])
REFERENCES [dbo].[area] ([ID])
GO
ALTER TABLE [dbo].[table] CHECK CONSTRAINT [FK_table_area]
GO
ALTER TABLE [dbo].[timekeeping]  WITH CHECK ADD  CONSTRAINT [FK_timekeeping_user] FOREIGN KEY([ID_USER])
REFERENCES [dbo].[user] ([ID])
GO
ALTER TABLE [dbo].[timekeeping] CHECK CONSTRAINT [FK_timekeeping_user]
GO
ALTER TABLE [dbo].[user_group_user]  WITH CHECK ADD  CONSTRAINT [FK_user_group_user_group_user] FOREIGN KEY([ID_GROUP])
REFERENCES [dbo].[group_user] ([ID])
GO
ALTER TABLE [dbo].[user_group_user] CHECK CONSTRAINT [FK_user_group_user_group_user]
GO
ALTER TABLE [dbo].[user_group_user]  WITH CHECK ADD  CONSTRAINT [FK_user_group_user_user] FOREIGN KEY([ID_USER])
REFERENCES [dbo].[user] ([ID])
GO
ALTER TABLE [dbo].[user_group_user] CHECK CONSTRAINT [FK_user_group_user_user]
GO
