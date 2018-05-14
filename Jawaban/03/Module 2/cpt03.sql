USE [cpt03]
GO
/****** Object:  Table [dbo].[Class]    Script Date: 16/05/2017 17.08.44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Class](
	[ClassName] [varchar](5) NOT NULL,
	[Grade] [int] NULL,
 CONSTRAINT [PK_Class] PRIMARY KEY CLUSTERED 
(
	[ClassName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetailClass]    Script Date: 16/05/2017 17.08.44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetailClass](
	[DetailClassId] [int] IDENTITY(1,1) NOT NULL,
	[ClassName] [varchar](5) NULL,
	[StudentId] [varchar](8) NULL,
 CONSTRAINT [PK_DetailClass$] PRIMARY KEY CLUSTERED 
(
	[DetailClassId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetailSchedule]    Script Date: 16/05/2017 17.08.44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetailSchedule](
	[DetailId] [int] IDENTITY(1,1) NOT NULL,
	[ScheduleId] [int] NULL,
	[SubjectId] [char](5) NULL,
	[TeacherId] [char](5) NULL,
	[Day] [varchar](10) NULL,
	[ShiftId] [int] NULL,
 CONSTRAINT [PK_DetailSchedule$] PRIMARY KEY CLUSTERED 
(
	[DetailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetailScore]    Script Date: 16/05/2017 17.08.44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetailScore](
	[ScoreDetailID] [int] IDENTITY(1,1) NOT NULL,
	[StudentID] [varchar](8) NOT NULL,
	[DetailID] [int] NOT NULL,
	[Assignment] [int] NULL,
	[MidExam] [int] NULL,
	[FinalExam] [int] NULL,
 CONSTRAINT [PK_DetailScore] PRIMARY KEY CLUSTERED 
(
	[ScoreDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Expertise]    Script Date: 16/05/2017 17.08.44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Expertise](
	[ExpertiseID] [int] IDENTITY(1,1) NOT NULL,
	[TeacherID] [varchar](8) NULL,
	[SubjectID] [char](5) NULL,
 CONSTRAINT [PK_Expertise] PRIMARY KEY CLUSTERED 
(
	[ExpertiseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HeaderSchedule]    Script Date: 16/05/2017 17.08.44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HeaderSchedule](
	[ScheduleId] [int] IDENTITY(1,1) NOT NULL,
	[ClassName] [varchar](5) NULL,
	[Finalize] [int] NULL,
 CONSTRAINT [PK_HeaderSchedule$] PRIMARY KEY CLUSTERED 
(
	[ScheduleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Shift]    Script Date: 16/05/2017 17.08.44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shift](
	[ShiftId] [int] NOT NULL,
	[Time] [char](13) NULL,
 CONSTRAINT [PK_Shift$] PRIMARY KEY CLUSTERED 
(
	[ShiftId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 16/05/2017 17.08.44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[StudentId] [varchar](8) NOT NULL,
	[Name] [varchar](50) NULL,
	[Address] [varchar](150) NULL,
	[Gender] [varchar](7) NULL,
	[DateofBirth] [date] NULL,
	[PhoneNumber] [varchar](12) NULL,
	[Photo] [varchar](100) NULL,
 CONSTRAINT [PK_Student$] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subject]    Script Date: 16/05/2017 17.08.44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subject](
	[SubjectId] [char](5) NOT NULL,
	[Name] [varchar](50) NULL,
	[Assignment] [int] NULL,
	[MidExam] [int] NULL,
	[FinalExam] [int] NULL,
	[Shift] [int] NULL,
	[ForGrade] [int] NULL,
 CONSTRAINT [PK_Subject$] PRIMARY KEY CLUSTERED 
(
	[SubjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teacher]    Script Date: 16/05/2017 17.08.44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teacher](
	[TeacherId] [varchar](8) NOT NULL,
	[Name] [varchar](50) NULL,
	[PhoneNumber] [varchar](12) NULL,
	[DateofBirth] [date] NULL,
	[Gender] [varchar](7) NULL,
	[Address] [varchar](100) NULL,
	[Photo] [varchar](100) NULL,
 CONSTRAINT [PK_Teacher$] PRIMARY KEY CLUSTERED 
(
	[TeacherId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 16/05/2017 17.08.44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[userid] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](8) NULL,
	[password] [varchar](10) NULL,
	[role] [varchar](8) NULL,
 CONSTRAINT [PK_User$] PRIMARY KEY CLUSTERED 
(
	[userid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Class] ([ClassName], [Grade]) VALUES (N'XA', 1)
INSERT [dbo].[Class] ([ClassName], [Grade]) VALUES (N'XB', 1)
INSERT [dbo].[Class] ([ClassName], [Grade]) VALUES (N'XIA', 2)
INSERT [dbo].[Class] ([ClassName], [Grade]) VALUES (N'XIB', 2)
INSERT [dbo].[Class] ([ClassName], [Grade]) VALUES (N'XIIA', 3)
INSERT [dbo].[Class] ([ClassName], [Grade]) VALUES (N'XIIB', 3)
SET IDENTITY_INSERT [dbo].[DetailClass] ON 

INSERT [dbo].[DetailClass] ([DetailClassId], [ClassName], [StudentId]) VALUES (1, N'XA', N'20170001')
INSERT [dbo].[DetailClass] ([DetailClassId], [ClassName], [StudentId]) VALUES (2, N'XA', N'20170002')
INSERT [dbo].[DetailClass] ([DetailClassId], [ClassName], [StudentId]) VALUES (3, N'XA', N'20170003')
INSERT [dbo].[DetailClass] ([DetailClassId], [ClassName], [StudentId]) VALUES (4, N'XA', N'20170004')
INSERT [dbo].[DetailClass] ([DetailClassId], [ClassName], [StudentId]) VALUES (5, N'XA', N'20170005')
INSERT [dbo].[DetailClass] ([DetailClassId], [ClassName], [StudentId]) VALUES (6, N'XA', N'20170006')
INSERT [dbo].[DetailClass] ([DetailClassId], [ClassName], [StudentId]) VALUES (7, N'XA', N'20170007')
INSERT [dbo].[DetailClass] ([DetailClassId], [ClassName], [StudentId]) VALUES (8, N'XA', N'20170008')
INSERT [dbo].[DetailClass] ([DetailClassId], [ClassName], [StudentId]) VALUES (9, N'XA', N'20170009')
INSERT [dbo].[DetailClass] ([DetailClassId], [ClassName], [StudentId]) VALUES (10, N'XA', N'20170010')
INSERT [dbo].[DetailClass] ([DetailClassId], [ClassName], [StudentId]) VALUES (11, N'XB', N'20170011')
INSERT [dbo].[DetailClass] ([DetailClassId], [ClassName], [StudentId]) VALUES (12, N'XB', N'20170012')
INSERT [dbo].[DetailClass] ([DetailClassId], [ClassName], [StudentId]) VALUES (13, N'XB', N'20170013')
INSERT [dbo].[DetailClass] ([DetailClassId], [ClassName], [StudentId]) VALUES (14, N'XB', N'20170014')
INSERT [dbo].[DetailClass] ([DetailClassId], [ClassName], [StudentId]) VALUES (15, N'XB', N'20170015')
INSERT [dbo].[DetailClass] ([DetailClassId], [ClassName], [StudentId]) VALUES (16, N'XB', N'20170016')
INSERT [dbo].[DetailClass] ([DetailClassId], [ClassName], [StudentId]) VALUES (17, N'XB', N'20170017')
INSERT [dbo].[DetailClass] ([DetailClassId], [ClassName], [StudentId]) VALUES (18, N'XB', N'20170018')
INSERT [dbo].[DetailClass] ([DetailClassId], [ClassName], [StudentId]) VALUES (19, N'XB', N'20170019')
INSERT [dbo].[DetailClass] ([DetailClassId], [ClassName], [StudentId]) VALUES (20, N'XIA', N'20160001')
INSERT [dbo].[DetailClass] ([DetailClassId], [ClassName], [StudentId]) VALUES (21, N'XIA', N'20160002')
INSERT [dbo].[DetailClass] ([DetailClassId], [ClassName], [StudentId]) VALUES (22, N'XIA', N'20160003')
INSERT [dbo].[DetailClass] ([DetailClassId], [ClassName], [StudentId]) VALUES (23, N'XIA', N'20160004')
INSERT [dbo].[DetailClass] ([DetailClassId], [ClassName], [StudentId]) VALUES (24, N'XIA', N'20160005')
INSERT [dbo].[DetailClass] ([DetailClassId], [ClassName], [StudentId]) VALUES (25, N'XIA', N'20160006')
INSERT [dbo].[DetailClass] ([DetailClassId], [ClassName], [StudentId]) VALUES (26, N'XIA', N'20160007')
INSERT [dbo].[DetailClass] ([DetailClassId], [ClassName], [StudentId]) VALUES (27, N'XIA', N'20160008')
INSERT [dbo].[DetailClass] ([DetailClassId], [ClassName], [StudentId]) VALUES (28, N'XIA', N'20160009')
INSERT [dbo].[DetailClass] ([DetailClassId], [ClassName], [StudentId]) VALUES (29, N'XIB', N'20160010')
INSERT [dbo].[DetailClass] ([DetailClassId], [ClassName], [StudentId]) VALUES (30, N'XIB', N'20160011')
INSERT [dbo].[DetailClass] ([DetailClassId], [ClassName], [StudentId]) VALUES (31, N'XIB', N'20160012')
INSERT [dbo].[DetailClass] ([DetailClassId], [ClassName], [StudentId]) VALUES (32, N'XIB', N'20160013')
INSERT [dbo].[DetailClass] ([DetailClassId], [ClassName], [StudentId]) VALUES (33, N'XIB', N'20160014')
INSERT [dbo].[DetailClass] ([DetailClassId], [ClassName], [StudentId]) VALUES (34, N'XIB', N'20160015')
INSERT [dbo].[DetailClass] ([DetailClassId], [ClassName], [StudentId]) VALUES (35, N'XIB', N'20160016')
INSERT [dbo].[DetailClass] ([DetailClassId], [ClassName], [StudentId]) VALUES (36, N'XIB', N'20160017')
INSERT [dbo].[DetailClass] ([DetailClassId], [ClassName], [StudentId]) VALUES (37, N'XIB', N'20160018')
INSERT [dbo].[DetailClass] ([DetailClassId], [ClassName], [StudentId]) VALUES (38, N'XIIA', N'20150001')
INSERT [dbo].[DetailClass] ([DetailClassId], [ClassName], [StudentId]) VALUES (39, N'XIIA', N'20150002')
INSERT [dbo].[DetailClass] ([DetailClassId], [ClassName], [StudentId]) VALUES (40, N'XIIA', N'20150003')
INSERT [dbo].[DetailClass] ([DetailClassId], [ClassName], [StudentId]) VALUES (41, N'XIIA', N'20150004')
INSERT [dbo].[DetailClass] ([DetailClassId], [ClassName], [StudentId]) VALUES (42, N'XIIA', N'20150005')
INSERT [dbo].[DetailClass] ([DetailClassId], [ClassName], [StudentId]) VALUES (43, N'XIIA', N'20150006')
INSERT [dbo].[DetailClass] ([DetailClassId], [ClassName], [StudentId]) VALUES (44, N'XIIA', N'20150007')
INSERT [dbo].[DetailClass] ([DetailClassId], [ClassName], [StudentId]) VALUES (45, N'XIIA', N'20150008')
INSERT [dbo].[DetailClass] ([DetailClassId], [ClassName], [StudentId]) VALUES (46, N'XIIB', N'20150009')
INSERT [dbo].[DetailClass] ([DetailClassId], [ClassName], [StudentId]) VALUES (47, N'XIIB', N'20150010')
INSERT [dbo].[DetailClass] ([DetailClassId], [ClassName], [StudentId]) VALUES (48, N'XIIB', N'20150011')
INSERT [dbo].[DetailClass] ([DetailClassId], [ClassName], [StudentId]) VALUES (49, N'XIIB', N'20150012')
INSERT [dbo].[DetailClass] ([DetailClassId], [ClassName], [StudentId]) VALUES (50, N'XIIB', N'20150013')
INSERT [dbo].[DetailClass] ([DetailClassId], [ClassName], [StudentId]) VALUES (51, N'XIIB', N'20150014')
INSERT [dbo].[DetailClass] ([DetailClassId], [ClassName], [StudentId]) VALUES (52, N'XIIB', N'20150015')
INSERT [dbo].[DetailClass] ([DetailClassId], [ClassName], [StudentId]) VALUES (53, N'XIIB', N'20150016')
SET IDENTITY_INSERT [dbo].[DetailClass] OFF
SET IDENTITY_INSERT [dbo].[DetailSchedule] ON 

INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (1, 1, N'S1001', NULL, N'Monday', 1)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (2, 1, N'S1001', NULL, N'Monday', 2)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (3, 1, N'S1001', NULL, N'Monday', 3)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (4, 1, N'S1002', NULL, N'Monday', 4)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (5, 1, N'S1002', NULL, N'Monday', 5)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (6, 1, N'S1003', NULL, N'Tuesday', 2)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (7, 1, N'S1003', NULL, N'Tuesday', 3)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (8, 1, N'S1003', NULL, N'Wednesday', 1)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (9, 1, N'S1003', NULL, N'Wednesday', 2)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (10, 1, N'S1004', NULL, N'Wednesday', 3)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (11, 1, N'S1004', NULL, N'Wednesday', 4)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (12, 1, N'S1004', NULL, N'Tuesday', 4)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (13, 1, N'S1004', NULL, N'Tuesday', 5)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (14, 1, N'S1005', NULL, N'Monday', 6)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (15, 1, N'S1005', NULL, N'Monday', 7)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (16, 1, N'S1006', NULL, N'Monday', 8)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (17, 1, N'S1006', NULL, N'Tuesday', 1)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (18, 1, N'S1007', NULL, N'Tuesday', 6)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (19, 1, N'S1007', NULL, N'Tuesday', 7)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (20, 1, N'S1008', NULL, N'Wednesday', 5)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (21, 1, N'S1008', NULL, N'Wednesday', 6)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (22, 1, N'S1009', NULL, N'Thrusday', 1)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (23, 1, N'S1009', NULL, N'Thrusday', 2)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (24, 1, N'S1009', NULL, N'Thrusday', 3)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (25, 1, N'S1010', NULL, N'Thrusday', 4)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (26, 1, N'S1010', NULL, N'Thrusday', 5)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (27, 1, N'S1011', NULL, N'Wednesday', 7)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (28, 1, N'S1011', NULL, N'Wednesday', 8)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (29, 1, N'S1012', NULL, N'Friday', 1)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (30, 1, N'S1012', NULL, N'Friday', 2)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (31, 1, N'S1013', NULL, N'Friday', 5)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (32, 1, N'S1013', NULL, N'Friday', 6)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (33, 1, N'S1013', NULL, N'Saturday', 1)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (34, 1, N'S1013', NULL, N'Saturday', 2)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (35, 1, N'S1014', NULL, N'Tuesday', 8)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (36, 1, N'S1014', NULL, N'Friday', 7)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (37, 1, N'S1014', NULL, N'Friday', 8)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (38, 1, N'S1015', NULL, N'Thrusday', 8)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (39, 1, N'S1015', NULL, N'Saturday', 3)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (40, 1, N'S1015', NULL, N'Saturday', 4)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (41, 1, N'S1016', NULL, N'Thrusday', 5)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (42, 1, N'S1016', NULL, N'Thrusday', 7)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (43, 1, N'S1016', NULL, N'Saturday', 7)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (44, 1, N'S1016', NULL, N'Saturday', 8)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (45, 1, N'S1017', NULL, N'Friday', 3)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (46, 1, N'S1017', NULL, N'Friday', 4)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (47, 1, N'S1017', NULL, N'Saturday', 5)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (48, 1, N'S1017', NULL, N'Saturday', 6)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (49, 2, N'S2001', NULL, N'Monday', 1)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (50, 2, N'S2001', NULL, N'Tuesday', 1)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (51, 2, N'S2001', NULL, N'Wednesday', 1)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (52, 2, N'S2002', NULL, N'Monday', 2)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (53, 2, N'S2002', NULL, N'Tuesday', 2)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (54, 2, N'S2003', NULL, N'Wednesday', 2)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (55, 2, N'S2003', NULL, N'Wednesday', 3)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (56, 2, N'S2003', NULL, N'Thrusday', 1)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (57, 2, N'S2003', NULL, N'Thrusday', 2)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (58, 2, N'S2004', NULL, N'Monday', 3)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (59, 2, N'S2004', NULL, N'Monday', 4)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (60, 2, N'S2004', NULL, N'Tuesday', 3)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (61, 2, N'S2004', NULL, N'Tuesday', 4)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (62, 2, N'S2005', NULL, N'Monday', 5)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (63, 2, N'S2005', NULL, N'Monday', 6)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (64, 2, N'S2006', NULL, N'Monday', 7)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (65, 2, N'S2006', NULL, N'Monday', 8)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (66, 2, N'S2007', NULL, N'Tuesday', 5)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (67, 2, N'S2007', NULL, N'Tuesday', 6)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (68, 2, N'S2008', NULL, N'Tuesday', 7)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (69, 2, N'S2008', NULL, N'Tuesday', 8)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (70, 2, N'S2009', NULL, N'Wednesday', 4)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (71, 2, N'S2009', NULL, N'Wednesday', 5)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (72, 2, N'S2009', NULL, N'Wednesday', 6)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (73, 2, N'S2010', NULL, N'Wednesday', 7)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (74, 2, N'S2010', NULL, N'Wednesday', 8)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (75, 2, N'S2011', NULL, N'Thrusday', 3)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (76, 2, N'S2011', NULL, N'Thrusday', 4)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (77, 2, N'S2011', NULL, N'Thrusday', 5)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (78, 2, N'S2011', NULL, N'Thrusday', 6)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (79, 2, N'S2012', NULL, N'Friday', 1)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (80, 2, N'S2012', NULL, N'Friday', 2)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (81, 2, N'S2012', NULL, N'Saturday', 3)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (82, 2, N'S2012', NULL, N'Saturday', 4)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (83, 2, N'S2013', NULL, N'Thrusday', 7)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (84, 2, N'S2013', NULL, N'Thrusday', 8)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (85, 2, N'S2014', NULL, N'Friday', 3)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (86, 2, N'S2014', NULL, N'Friday', 4)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (87, 2, N'S2014', NULL, N'Saturday', 3)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (88, 2, N'S2014', NULL, N'Saturday', 4)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (89, 2, N'S2015', NULL, N'Friday', 5)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (90, 2, N'S2015', NULL, N'Friday', 6)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (91, 2, N'S2015', NULL, N'Saturday', 5)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (92, 2, N'S2015', NULL, N'Saturday', 6)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (93, 2, N'S2016', NULL, N'Friday', 7)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (94, 2, N'S2016', NULL, N'Friday', 8)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (95, 2, N'S2016', NULL, N'Saturday', 7)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (96, 2, N'S2016', NULL, N'Saturday', 8)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (97, 3, N'S2001', NULL, N'Saturday', 1)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (98, 3, N'S2001', NULL, N'Friday', 1)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (99, 3, N'S2001', NULL, N'Thrusday', 1)
GO
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (100, 3, N'S2002', NULL, N'Saturday', 2)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (101, 3, N'S2002', NULL, N'Friday', 2)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (102, 3, N'S2003', NULL, N'Thrusday', 2)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (103, 3, N'S2003', NULL, N'Thrusday', 3)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (104, 3, N'S2003', NULL, N'Wednesday', 1)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (105, 3, N'S2003', NULL, N'Wednesday', 2)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (106, 3, N'S2004', NULL, N'Saturday', 3)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (107, 3, N'S2004', NULL, N'Saturday', 4)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (108, 3, N'S2004', NULL, N'Friday', 3)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (109, 3, N'S2004', NULL, N'Friday', 4)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (110, 3, N'S2005', NULL, N'Saturday', 5)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (111, 3, N'S2005', NULL, N'Saturday', 6)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (112, 3, N'S2006', NULL, N'Saturday', 7)
INSERT [dbo].[DetailSchedule] ([DetailId], [ScheduleId], [SubjectId], [TeacherId], [Day], [ShiftId]) VALUES (113, 3, N'S2006', NULL, N'Saturday', 8)
SET IDENTITY_INSERT [dbo].[DetailSchedule] OFF
SET IDENTITY_INSERT [dbo].[HeaderSchedule] ON 

INSERT [dbo].[HeaderSchedule] ([ScheduleId], [ClassName], [Finalize]) VALUES (1, N'XA', 1)
INSERT [dbo].[HeaderSchedule] ([ScheduleId], [ClassName], [Finalize]) VALUES (2, N'XB', 0)
INSERT [dbo].[HeaderSchedule] ([ScheduleId], [ClassName], [Finalize]) VALUES (3, N'XIA', 1)
INSERT [dbo].[HeaderSchedule] ([ScheduleId], [ClassName], [Finalize]) VALUES (4, N'XIB', 0)
INSERT [dbo].[HeaderSchedule] ([ScheduleId], [ClassName], [Finalize]) VALUES (5, N'XIIA', 0)
INSERT [dbo].[HeaderSchedule] ([ScheduleId], [ClassName], [Finalize]) VALUES (6, N'XIIB', 0)
SET IDENTITY_INSERT [dbo].[HeaderSchedule] OFF
INSERT [dbo].[Shift] ([ShiftId], [Time]) VALUES (1, N'07:00 - 07:50')
INSERT [dbo].[Shift] ([ShiftId], [Time]) VALUES (2, N'07:50 - 08:40')
INSERT [dbo].[Shift] ([ShiftId], [Time]) VALUES (3, N'08:40 - 09:30')
INSERT [dbo].[Shift] ([ShiftId], [Time]) VALUES (4, N'09:50 - 10:40')
INSERT [dbo].[Shift] ([ShiftId], [Time]) VALUES (5, N'10:40 - 11:30')
INSERT [dbo].[Shift] ([ShiftId], [Time]) VALUES (6, N'11:30 - 12:20')
INSERT [dbo].[Shift] ([ShiftId], [Time]) VALUES (7, N'12:40 - 13:30')
INSERT [dbo].[Shift] ([ShiftId], [Time]) VALUES (8, N'13:30 - 14:20')
INSERT [dbo].[Student] ([StudentId], [Name], [Address], [Gender], [DateofBirth], [PhoneNumber], [Photo]) VALUES (N'20150001', N'M. ARIF BASRIS', N'264 Burrows Center', N'Male', CAST(N'1999-05-19' AS Date), N'081235509036', NULL)
INSERT [dbo].[Student] ([StudentId], [Name], [Address], [Gender], [DateofBirth], [PhoneNumber], [Photo]) VALUES (N'20150002', N'MARTINUS GAI BARA LIRA PARERA', N'2704 Barnett Avenue', N'Male', CAST(N'1999-05-20' AS Date), N'0818765488', NULL)
INSERT [dbo].[Student] ([StudentId], [Name], [Address], [Gender], [DateofBirth], [PhoneNumber], [Photo]) VALUES (N'20150003', N'MARVIN FURIANTO', N'1 Chinook Hill', N'Male', CAST(N'1999-05-21' AS Date), N'08165384904', NULL)
INSERT [dbo].[Student] ([StudentId], [Name], [Address], [Gender], [DateofBirth], [PhoneNumber], [Photo]) VALUES (N'20150004', N'MOHAMAD FATHUR BAWAFIE', N'7 Comanche Point', N'Male', CAST(N'1999-05-22' AS Date), N'0812357490', NULL)
INSERT [dbo].[Student] ([StudentId], [Name], [Address], [Gender], [DateofBirth], [PhoneNumber], [Photo]) VALUES (N'20150005', N'MUHAMMAD FADIL KAMAL', N'91597 Service Park', N'Male', CAST(N'1999-05-23' AS Date), N'0819475858', NULL)
INSERT [dbo].[Student] ([StudentId], [Name], [Address], [Gender], [DateofBirth], [PhoneNumber], [Photo]) VALUES (N'20150006', N'MUHAMMAD FARHAN HIDAYAT', N'3 Bluestem Center', N'Male', CAST(N'1999-05-24' AS Date), N'08135454532', NULL)
INSERT [dbo].[Student] ([StudentId], [Name], [Address], [Gender], [DateofBirth], [PhoneNumber], [Photo]) VALUES (N'20150007', N'MUHAMMAD HANIF', N'5 Oneill Hill', N'Male', CAST(N'1999-05-25' AS Date), N'08132757599', NULL)
INSERT [dbo].[Student] ([StudentId], [Name], [Address], [Gender], [DateofBirth], [PhoneNumber], [Photo]) VALUES (N'20150008', N'MUHAMMAD ILHAM RAHMADI', N'6 Steensland Place', N'Male', CAST(N'1999-05-26' AS Date), N'0812675899', NULL)
INSERT [dbo].[Student] ([StudentId], [Name], [Address], [Gender], [DateofBirth], [PhoneNumber], [Photo]) VALUES (N'20150009', N'MUHAMMAD REYNALDI', N'10030 Fieldstone Plaza', N'Male', CAST(N'1999-05-27' AS Date), N'0812546789', NULL)
INSERT [dbo].[Student] ([StudentId], [Name], [Address], [Gender], [DateofBirth], [PhoneNumber], [Photo]) VALUES (N'20150010', N'NAMIRA MUFIDA ADIEN', N'9 Parkside Court', N'Female', CAST(N'1999-05-28' AS Date), N'08123565332', NULL)
INSERT [dbo].[Student] ([StudentId], [Name], [Address], [Gender], [DateofBirth], [PhoneNumber], [Photo]) VALUES (N'20150011', N'NIXON', N'2365 Ridge Oak Drive', N'Male', CAST(N'1999-05-29' AS Date), N'08528564744', NULL)
INSERT [dbo].[Student] ([StudentId], [Name], [Address], [Gender], [DateofBirth], [PhoneNumber], [Photo]) VALUES (N'20150012', N'RIANDA ANGGAR KUSUMA', N'4 Hoffman Avenue', N'Male', CAST(N'1999-05-30' AS Date), N'08126754554', NULL)
INSERT [dbo].[Student] ([StudentId], [Name], [Address], [Gender], [DateofBirth], [PhoneNumber], [Photo]) VALUES (N'20150013', N'RICKY RIZALDI', N'7634 Gerald Point', N'Male', CAST(N'1999-05-31' AS Date), N'08164954777', NULL)
INSERT [dbo].[Student] ([StudentId], [Name], [Address], [Gender], [DateofBirth], [PhoneNumber], [Photo]) VALUES (N'20150014', N'SAMUEL BUDIMAN', N'97564 Westport Avenue', N'Male', CAST(N'1999-06-01' AS Date), N'08172554678', NULL)
INSERT [dbo].[Student] ([StudentId], [Name], [Address], [Gender], [DateofBirth], [PhoneNumber], [Photo]) VALUES (N'20150015', N'SAMUEL SANJAYA SUTANTO', N'771 Meadow Valley Lane', N'Male', CAST(N'1999-06-02' AS Date), N'0818204773', NULL)
INSERT [dbo].[Student] ([StudentId], [Name], [Address], [Gender], [DateofBirth], [PhoneNumber], [Photo]) VALUES (N'20150016', N'SHAVIRA', N'96 Elmside Place', N'Female', CAST(N'1999-06-03' AS Date), N'08135678494', NULL)
INSERT [dbo].[Student] ([StudentId], [Name], [Address], [Gender], [DateofBirth], [PhoneNumber], [Photo]) VALUES (N'20160001', N'HAM, RICHARD ADHIKA HARTONO', N'20805 Sunfield Alley', N'Male', CAST(N'2000-09-17' AS Date), N'0812889798', NULL)
INSERT [dbo].[Student] ([StudentId], [Name], [Address], [Gender], [DateofBirth], [PhoneNumber], [Photo]) VALUES (N'20160002', N'HENDRAWAN HADIKUSUMA', N'083 Center Trail', N'Male', CAST(N'2000-09-18' AS Date), N'08523677748', NULL)
INSERT [dbo].[Student] ([StudentId], [Name], [Address], [Gender], [DateofBirth], [PhoneNumber], [Photo]) VALUES (N'20160003', N'IGNATIUS KEVIN LANATA', N'7 Monterey Alley', N'Male', CAST(N'2000-09-19' AS Date), N'08577565555', NULL)
INSERT [dbo].[Student] ([StudentId], [Name], [Address], [Gender], [DateofBirth], [PhoneNumber], [Photo]) VALUES (N'20160004', N'INDRA KURNIAWAN', N'05888 Moland Way', N'Male', CAST(N'2000-09-20' AS Date), N'08123556565', NULL)
INSERT [dbo].[Student] ([StudentId], [Name], [Address], [Gender], [DateofBirth], [PhoneNumber], [Photo]) VALUES (N'20160005', N'JEREMY SETIAWAN', N'7 Pleasure Trail', N'Male', CAST(N'2000-09-21' AS Date), N'08123556676', NULL)
INSERT [dbo].[Student] ([StudentId], [Name], [Address], [Gender], [DateofBirth], [PhoneNumber], [Photo]) VALUES (N'20160006', N'JOHAN', N'6853 Kenwood Place', N'Male', CAST(N'2000-09-22' AS Date), N'08129674399', NULL)
INSERT [dbo].[Student] ([StudentId], [Name], [Address], [Gender], [DateofBirth], [PhoneNumber], [Photo]) VALUES (N'20160007', N'KATILI JIWO ADI WIYONO', N'38 Northport Circle', N'Male', CAST(N'2000-09-23' AS Date), N'08123657645', NULL)
INSERT [dbo].[Student] ([StudentId], [Name], [Address], [Gender], [DateofBirth], [PhoneNumber], [Photo]) VALUES (N'20160008', N'KEVIN FAUSTA', N'9652 Lunder Way', N'Male', CAST(N'2000-09-24' AS Date), N'08126643434', NULL)
INSERT [dbo].[Student] ([StudentId], [Name], [Address], [Gender], [DateofBirth], [PhoneNumber], [Photo]) VALUES (N'20160009', N'KEVIN HADINATA', N'819 Debra Alley', N'Male', CAST(N'2000-09-25' AS Date), N'0812332555', NULL)
INSERT [dbo].[Student] ([StudentId], [Name], [Address], [Gender], [DateofBirth], [PhoneNumber], [Photo]) VALUES (N'20160010', N'KEVIN KUSWANDI', N'610 Columbus Center', N'Male', CAST(N'2000-09-26' AS Date), N'0812366454', NULL)
INSERT [dbo].[Student] ([StudentId], [Name], [Address], [Gender], [DateofBirth], [PhoneNumber], [Photo]) VALUES (N'20160011', N'KEVIN SETIADI GUNAWAN', N'24727 Northwestern Avenue', N'Male', CAST(N'2000-09-27' AS Date), N'08125656767', NULL)
INSERT [dbo].[Student] ([StudentId], [Name], [Address], [Gender], [DateofBirth], [PhoneNumber], [Photo]) VALUES (N'20160012', N'KEVIN YULIAS', N'355 Troy Hill', N'Male', CAST(N'2000-09-28' AS Date), N'0812355665', NULL)
INSERT [dbo].[Student] ([StudentId], [Name], [Address], [Gender], [DateofBirth], [PhoneNumber], [Photo]) VALUES (N'20160013', N'KRESNA ADJIE DEWANTARA', N'00751 Center Court', N'Male', CAST(N'2000-09-29' AS Date), N'0818407446', NULL)
INSERT [dbo].[Student] ([StudentId], [Name], [Address], [Gender], [DateofBirth], [PhoneNumber], [Photo]) VALUES (N'20160014', N'LAYARDA PUTRA ANGKASA', N'1551 Lyons Point', N'Male', CAST(N'2000-09-30' AS Date), N'0819475656', NULL)
INSERT [dbo].[Student] ([StudentId], [Name], [Address], [Gender], [DateofBirth], [PhoneNumber], [Photo]) VALUES (N'20160015', N'LEON NATANTO', N'354 Nobel Alley', N'Male', CAST(N'2000-10-01' AS Date), N'08125678966', NULL)
INSERT [dbo].[Student] ([StudentId], [Name], [Address], [Gender], [DateofBirth], [PhoneNumber], [Photo]) VALUES (N'20160016', N'LEONARDO KURNIAWAN', N'44 Loeprich Trail', N'Male', CAST(N'2000-10-02' AS Date), N'089965474894', NULL)
INSERT [dbo].[Student] ([StudentId], [Name], [Address], [Gender], [DateofBirth], [PhoneNumber], [Photo]) VALUES (N'20160017', N'LISA INDRAPUTRI', N'7617 Manley Junction', N'Female', CAST(N'2000-10-03' AS Date), N'08957447999', NULL)
INSERT [dbo].[Student] ([StudentId], [Name], [Address], [Gender], [DateofBirth], [PhoneNumber], [Photo]) VALUES (N'20160018', N'M YOGA PRANATA', N'43819 Namekagon Circle', N'Male', CAST(N'2000-10-04' AS Date), N'0813873535', NULL)
INSERT [dbo].[Student] ([StudentId], [Name], [Address], [Gender], [DateofBirth], [PhoneNumber], [Photo]) VALUES (N'20170001', N'ACHMAD RAFII SYAFRAN', N'2 Starling Drive', N'Male', CAST(N'2001-05-15' AS Date), N'08124556565', N'160517104741.png')
INSERT [dbo].[Student] ([StudentId], [Name], [Address], [Gender], [DateofBirth], [PhoneNumber], [Photo]) VALUES (N'20170002', N'ADITYA PUTRA BUDIMAN', N'672 Swallow Trail', N'Male', CAST(N'2001-05-16' AS Date), N'0812356565', NULL)
INSERT [dbo].[Student] ([StudentId], [Name], [Address], [Gender], [DateofBirth], [PhoneNumber], [Photo]) VALUES (N'20170003', N'ALBERT PRATAMA PUTRA TJHIA', N'94327 Moland Avenue', N'Male', CAST(N'2001-05-17' AS Date), N'0816565343', NULL)
INSERT [dbo].[Student] ([StudentId], [Name], [Address], [Gender], [DateofBirth], [PhoneNumber], [Photo]) VALUES (N'20170004', N'ANDI LIWANTORO SUSANTO', N'73 Hoffman Hill', N'Male', CAST(N'2001-05-18' AS Date), N'08127998343', NULL)
INSERT [dbo].[Student] ([StudentId], [Name], [Address], [Gender], [DateofBirth], [PhoneNumber], [Photo]) VALUES (N'20170005', N'AUDIA LAVENA', N'20 Hanover Plaza', N'Female', CAST(N'2001-05-19' AS Date), N'08124566465', NULL)
INSERT [dbo].[Student] ([StudentId], [Name], [Address], [Gender], [DateofBirth], [PhoneNumber], [Photo]) VALUES (N'20170006', N'BELIGA', N'49 Sullivan Street', N'Male', CAST(N'2001-05-20' AS Date), N'081236656544', NULL)
INSERT [dbo].[Student] ([StudentId], [Name], [Address], [Gender], [DateofBirth], [PhoneNumber], [Photo]) VALUES (N'20170007', N'BRYAN', N'62946 Nevada Place', N'Male', CAST(N'2001-05-21' AS Date), N'08525676767', NULL)
INSERT [dbo].[Student] ([StudentId], [Name], [Address], [Gender], [DateofBirth], [PhoneNumber], [Photo]) VALUES (N'20170008', N'CALVIN LAURENSIUS NATAS', N'400 Northview Parkway', N'Male', CAST(N'2001-05-22' AS Date), N'08125656545', N'160517104459.png')
INSERT [dbo].[Student] ([StudentId], [Name], [Address], [Gender], [DateofBirth], [PhoneNumber], [Photo]) VALUES (N'20170009', N'CALVIN THEMDUANG', N'180 Bay Way', N'Male', CAST(N'2001-05-23' AS Date), N'08125652343', NULL)
INSERT [dbo].[Student] ([StudentId], [Name], [Address], [Gender], [DateofBirth], [PhoneNumber], [Photo]) VALUES (N'20170010', N'CARISSA', N'26 Golf Course Court', N'Female', CAST(N'2001-05-24' AS Date), N'0819556563', NULL)
INSERT [dbo].[Student] ([StudentId], [Name], [Address], [Gender], [DateofBirth], [PhoneNumber], [Photo]) VALUES (N'20170011', N'CHANDRA BUNJAYA', N'089 Northridge Place', N'Male', CAST(N'2001-05-25' AS Date), N'0818356565', N'160517101608.png')
INSERT [dbo].[Student] ([StudentId], [Name], [Address], [Gender], [DateofBirth], [PhoneNumber], [Photo]) VALUES (N'20170012', N'CHRISTIN YOHANA', N'860 Northwestern Point', N'Female', CAST(N'2001-05-26' AS Date), N'08180754663', NULL)
INSERT [dbo].[Student] ([StudentId], [Name], [Address], [Gender], [DateofBirth], [PhoneNumber], [Photo]) VALUES (N'20170013', N'CORNELLIUS GANOR ALBARADIE', N'8 Lukken Parkway', N'Male', CAST(N'2001-05-27' AS Date), N'08123555666', NULL)
INSERT [dbo].[Student] ([StudentId], [Name], [Address], [Gender], [DateofBirth], [PhoneNumber], [Photo]) VALUES (N'20170014', N'DEDDY SUPRIYADI', N'32 Carpenter Avenue', N'Male', CAST(N'2001-05-28' AS Date), N'08123653332', NULL)
INSERT [dbo].[Student] ([StudentId], [Name], [Address], [Gender], [DateofBirth], [PhoneNumber], [Photo]) VALUES (N'20170015', N'EDWINDO LAURENZO WIJANTO', N'4532 Pond Avenue', N'Male', CAST(N'2001-05-29' AS Date), N'081235563132', NULL)
INSERT [dbo].[Student] ([StudentId], [Name], [Address], [Gender], [DateofBirth], [PhoneNumber], [Photo]) VALUES (N'20170016', N'EZRA INDRASTATA SPINOZA', N'0 Dunning Junction', N'Male', CAST(N'2001-05-30' AS Date), N'08135656563', NULL)
INSERT [dbo].[Student] ([StudentId], [Name], [Address], [Gender], [DateofBirth], [PhoneNumber], [Photo]) VALUES (N'20170017', N'FAJRUL EMIRULLAH', N'13455 Grover Center', N'Male', CAST(N'2001-05-31' AS Date), N'085659766353', NULL)
INSERT [dbo].[Student] ([StudentId], [Name], [Address], [Gender], [DateofBirth], [PhoneNumber], [Photo]) VALUES (N'20170018', N'FREDRICK WIDJAYA', N'3 Anhalt Place', N'Male', CAST(N'2001-10-17' AS Date), N'083155665450', NULL)
INSERT [dbo].[Student] ([StudentId], [Name], [Address], [Gender], [DateofBirth], [PhoneNumber], [Photo]) VALUES (N'20170019', N'GERALDY OSCAR REINARD', N'520 Northridge Point', N'Male', CAST(N'2001-06-02' AS Date), N'08123656564', NULL)
INSERT [dbo].[Subject] ([SubjectId], [Name], [Assignment], [MidExam], [FinalExam], [Shift], [ForGrade]) VALUES (N'S1001', N'agama', 20, 30, 50, 3, 1)
INSERT [dbo].[Subject] ([SubjectId], [Name], [Assignment], [MidExam], [FinalExam], [Shift], [ForGrade]) VALUES (N'S1002', N'PKN', 20, 30, 50, 2, 1)
INSERT [dbo].[Subject] ([SubjectId], [Name], [Assignment], [MidExam], [FinalExam], [Shift], [ForGrade]) VALUES (N'S1003', N'bahasa indonesia', 30, 35, 35, 4, 1)
INSERT [dbo].[Subject] ([SubjectId], [Name], [Assignment], [MidExam], [FinalExam], [Shift], [ForGrade]) VALUES (N'S1004', N'matematika', 30, 30, 40, 4, 1)
INSERT [dbo].[Subject] ([SubjectId], [Name], [Assignment], [MidExam], [FinalExam], [Shift], [ForGrade]) VALUES (N'S1005', N'sejarah', 40, 30, 30, 2, 1)
INSERT [dbo].[Subject] ([SubjectId], [Name], [Assignment], [MidExam], [FinalExam], [Shift], [ForGrade]) VALUES (N'S1006', N'bahasa inggris', 25, 35, 40, 2, 1)
INSERT [dbo].[Subject] ([SubjectId], [Name], [Assignment], [MidExam], [FinalExam], [Shift], [ForGrade]) VALUES (N'S1007', N'seni budaya', 40, 30, 30, 2, 1)
INSERT [dbo].[Subject] ([SubjectId], [Name], [Assignment], [MidExam], [FinalExam], [Shift], [ForGrade]) VALUES (N'S1008', N'prakarya', 25, 35, 40, 2, 1)
INSERT [dbo].[Subject] ([SubjectId], [Name], [Assignment], [MidExam], [FinalExam], [Shift], [ForGrade]) VALUES (N'S1009', N'olahraga', 40, 30, 30, 3, 1)
INSERT [dbo].[Subject] ([SubjectId], [Name], [Assignment], [MidExam], [FinalExam], [Shift], [ForGrade]) VALUES (N'S1010', N'fisika', 40, 30, 30, 2, 1)
INSERT [dbo].[Subject] ([SubjectId], [Name], [Assignment], [MidExam], [FinalExam], [Shift], [ForGrade]) VALUES (N'S1011', N'pemrograman dasar', 30, 35, 35, 2, 1)
INSERT [dbo].[Subject] ([SubjectId], [Name], [Assignment], [MidExam], [FinalExam], [Shift], [ForGrade]) VALUES (N'S1012', N'sistem komputer', 30, 30, 40, 2, 1)
INSERT [dbo].[Subject] ([SubjectId], [Name], [Assignment], [MidExam], [FinalExam], [Shift], [ForGrade]) VALUES (N'S1013', N'perakitan komputer', 25, 35, 40, 4, 1)
INSERT [dbo].[Subject] ([SubjectId], [Name], [Assignment], [MidExam], [FinalExam], [Shift], [ForGrade]) VALUES (N'S1014', N'simulasi digital', 30, 30, 40, 3, 1)
INSERT [dbo].[Subject] ([SubjectId], [Name], [Assignment], [MidExam], [FinalExam], [Shift], [ForGrade]) VALUES (N'S1015', N'sistem operasi', 25, 35, 40, 3, 1)
INSERT [dbo].[Subject] ([SubjectId], [Name], [Assignment], [MidExam], [FinalExam], [Shift], [ForGrade]) VALUES (N'S1016', N'jaringan dasar', 20, 30, 50, 4, 1)
INSERT [dbo].[Subject] ([SubjectId], [Name], [Assignment], [MidExam], [FinalExam], [Shift], [ForGrade]) VALUES (N'S1017', N'pemrograman web', 30, 30, 40, 4, 1)
INSERT [dbo].[Subject] ([SubjectId], [Name], [Assignment], [MidExam], [FinalExam], [Shift], [ForGrade]) VALUES (N'S2001', N'agama', 20, 30, 50, 3, 2)
INSERT [dbo].[Subject] ([SubjectId], [Name], [Assignment], [MidExam], [FinalExam], [Shift], [ForGrade]) VALUES (N'S2002', N'PKN', 20, 30, 50, 2, 2)
INSERT [dbo].[Subject] ([SubjectId], [Name], [Assignment], [MidExam], [FinalExam], [Shift], [ForGrade]) VALUES (N'S2003', N'bahasa indonesia', 30, 35, 35, 4, 2)
INSERT [dbo].[Subject] ([SubjectId], [Name], [Assignment], [MidExam], [FinalExam], [Shift], [ForGrade]) VALUES (N'S2004', N'matematika', 30, 30, 40, 4, 2)
INSERT [dbo].[Subject] ([SubjectId], [Name], [Assignment], [MidExam], [FinalExam], [Shift], [ForGrade]) VALUES (N'S2005', N'sejarah', 40, 30, 30, 2, 2)
INSERT [dbo].[Subject] ([SubjectId], [Name], [Assignment], [MidExam], [FinalExam], [Shift], [ForGrade]) VALUES (N'S2006', N'bahasa inggris', 25, 35, 40, 2, 2)
INSERT [dbo].[Subject] ([SubjectId], [Name], [Assignment], [MidExam], [FinalExam], [Shift], [ForGrade]) VALUES (N'S2007', N'seni budaya', 20, 30, 50, 2, 2)
INSERT [dbo].[Subject] ([SubjectId], [Name], [Assignment], [MidExam], [FinalExam], [Shift], [ForGrade]) VALUES (N'S2008', N'prakarya', 30, 30, 40, 2, 2)
INSERT [dbo].[Subject] ([SubjectId], [Name], [Assignment], [MidExam], [FinalExam], [Shift], [ForGrade]) VALUES (N'S2009', N'olahraga', 30, 35, 35, 3, 2)
INSERT [dbo].[Subject] ([SubjectId], [Name], [Assignment], [MidExam], [FinalExam], [Shift], [ForGrade]) VALUES (N'S2010', N'fisika', 25, 35, 40, 2, 2)
INSERT [dbo].[Subject] ([SubjectId], [Name], [Assignment], [MidExam], [FinalExam], [Shift], [ForGrade]) VALUES (N'S2011', N'pemrograman dasar', 20, 30, 50, 4, 2)
INSERT [dbo].[Subject] ([SubjectId], [Name], [Assignment], [MidExam], [FinalExam], [Shift], [ForGrade]) VALUES (N'S2012', N'sistem komputer', 30, 30, 40, 4, 2)
INSERT [dbo].[Subject] ([SubjectId], [Name], [Assignment], [MidExam], [FinalExam], [Shift], [ForGrade]) VALUES (N'S2013', N'komputer terapan', 30, 35, 35, 2, 2)
INSERT [dbo].[Subject] ([SubjectId], [Name], [Assignment], [MidExam], [FinalExam], [Shift], [ForGrade]) VALUES (N'S2014', N'komunikasi data', 25, 35, 40, 4, 2)
INSERT [dbo].[Subject] ([SubjectId], [Name], [Assignment], [MidExam], [FinalExam], [Shift], [ForGrade]) VALUES (N'S2015', N'sistem operasi jaringan', 20, 30, 50, 4, 2)
INSERT [dbo].[Subject] ([SubjectId], [Name], [Assignment], [MidExam], [FinalExam], [Shift], [ForGrade]) VALUES (N'S2016', N'administrasi server', 30, 30, 40, 4, 2)
INSERT [dbo].[Subject] ([SubjectId], [Name], [Assignment], [MidExam], [FinalExam], [Shift], [ForGrade]) VALUES (N'S3001', N'agama', 20, 30, 50, 3, 3)
INSERT [dbo].[Subject] ([SubjectId], [Name], [Assignment], [MidExam], [FinalExam], [Shift], [ForGrade]) VALUES (N'S3002', N'PKN', 20, 30, 50, 2, 3)
INSERT [dbo].[Subject] ([SubjectId], [Name], [Assignment], [MidExam], [FinalExam], [Shift], [ForGrade]) VALUES (N'S3003', N'bahasa indonesia', 30, 35, 35, 4, 3)
INSERT [dbo].[Subject] ([SubjectId], [Name], [Assignment], [MidExam], [FinalExam], [Shift], [ForGrade]) VALUES (N'S3004', N'matematika', 30, 30, 40, 4, 3)
INSERT [dbo].[Subject] ([SubjectId], [Name], [Assignment], [MidExam], [FinalExam], [Shift], [ForGrade]) VALUES (N'S3005', N'sejarah', 40, 30, 30, 2, 3)
INSERT [dbo].[Subject] ([SubjectId], [Name], [Assignment], [MidExam], [FinalExam], [Shift], [ForGrade]) VALUES (N'S3006', N'bahasa inggris', 25, 35, 40, 2, 3)
INSERT [dbo].[Subject] ([SubjectId], [Name], [Assignment], [MidExam], [FinalExam], [Shift], [ForGrade]) VALUES (N'S3007', N'seni budaya', 20, 30, 50, 2, 3)
INSERT [dbo].[Subject] ([SubjectId], [Name], [Assignment], [MidExam], [FinalExam], [Shift], [ForGrade]) VALUES (N'S3008', N'prakarya', 30, 30, 40, 2, 3)
INSERT [dbo].[Subject] ([SubjectId], [Name], [Assignment], [MidExam], [FinalExam], [Shift], [ForGrade]) VALUES (N'S3009', N'olahraga', 30, 35, 35, 3, 3)
INSERT [dbo].[Subject] ([SubjectId], [Name], [Assignment], [MidExam], [FinalExam], [Shift], [ForGrade]) VALUES (N'S3010', N'jaringan nirkable', 25, 35, 40, 4, 3)
INSERT [dbo].[Subject] ([SubjectId], [Name], [Assignment], [MidExam], [FinalExam], [Shift], [ForGrade]) VALUES (N'S3011', N'keamanan jaringan', 20, 30, 50, 4, 3)
INSERT [dbo].[Subject] ([SubjectId], [Name], [Assignment], [MidExam], [FinalExam], [Shift], [ForGrade]) VALUES (N'S3012', N'trouble shooting jaringan', 30, 30, 40, 4, 3)
INSERT [dbo].[Subject] ([SubjectId], [Name], [Assignment], [MidExam], [FinalExam], [Shift], [ForGrade]) VALUES (N'S3013', N'rancang bangun jaringan', 30, 35, 35, 4, 3)
INSERT [dbo].[Subject] ([SubjectId], [Name], [Assignment], [MidExam], [FinalExam], [Shift], [ForGrade]) VALUES (N'S3014', N'kerja proyek', 30, 30, 40, 8, 3)
INSERT [dbo].[Teacher] ([TeacherId], [Name], [PhoneNumber], [DateofBirth], [Gender], [Address], [Photo]) VALUES (N'T0001', N'Derenes', N'085860619211', CAST(N'1980-08-12' AS Date), N'Male', N'Jl. Gatot Subroto No. 101, Surakarta', N'160517115636.png')
INSERT [dbo].[Teacher] ([TeacherId], [Name], [PhoneNumber], [DateofBirth], [Gender], [Address], [Photo]) VALUES (N'T0002', N'Barry Ron', N'083527836201', CAST(N'1980-08-13' AS Date), N'Male', N'Jl. Bengawan Asri No. 11, Surakarta', N'-')
INSERT [dbo].[Teacher] ([TeacherId], [Name], [PhoneNumber], [DateofBirth], [Gender], [Address], [Photo]) VALUES (N'T0003', N'Merry Antony', N'081024168959', CAST(N'1980-08-14' AS Date), N'Female', N'Jl. Bumi Asri Indah No. 13, Surakarta', N'-')
INSERT [dbo].[Teacher] ([TeacherId], [Name], [PhoneNumber], [DateofBirth], [Gender], [Address], [Photo]) VALUES (N'T0004', N'Christi', N'083840886410', CAST(N'1980-08-15' AS Date), N'Female', N'Komp. Griya Bima Asri Blok.B No. 47, Surakarta', N'-')
INSERT [dbo].[Teacher] ([TeacherId], [Name], [PhoneNumber], [DateofBirth], [Gender], [Address], [Photo]) VALUES (N'T0005', N'Alan Reynaldi', N'087181912892', CAST(N'1980-08-16' AS Date), N'Male', N'Jl. Sudirman No. 492, Surakarta', N'-')
INSERT [dbo].[Teacher] ([TeacherId], [Name], [PhoneNumber], [DateofBirth], [Gender], [Address], [Photo]) VALUES (N'T0006', N'Richard Sentosa', N'084139640318', CAST(N'1980-08-17' AS Date), N'Male', N'Jl. Keraton No. 842, Surakarta', N'-')
INSERT [dbo].[Teacher] ([TeacherId], [Name], [PhoneNumber], [DateofBirth], [Gender], [Address], [Photo]) VALUES (N'T0007', N'Brenda', N'085271078084', CAST(N'1980-08-18' AS Date), N'Female', N'Komp. Wartawan Blok. E No. 198, Surakarta', N'-')
INSERT [dbo].[Teacher] ([TeacherId], [Name], [PhoneNumber], [DateofBirth], [Gender], [Address], [Photo]) VALUES (N'T0008', N'Reza Mulyadi', N'089600460157', CAST(N'1980-08-19' AS Date), N'Male', N'Jl. Istimewa Gg. Hj Sahid No. 19, Surakarta', N'-')
INSERT [dbo].[Teacher] ([TeacherId], [Name], [PhoneNumber], [DateofBirth], [Gender], [Address], [Photo]) VALUES (N'T0009', N'Brandon', N'082907690980', CAST(N'1980-08-20' AS Date), N'Male', N'Jl. AH Nasution No. 74, Surakarta', N'-')
INSERT [dbo].[Teacher] ([TeacherId], [Name], [PhoneNumber], [DateofBirth], [Gender], [Address], [Photo]) VALUES (N'T0010', N'Reynold', N'085998471025', CAST(N'1980-08-21' AS Date), N'Male', N'Komp. Solo Makmur Blok. F No. 58, Surakarta', N'-')
INSERT [dbo].[Teacher] ([TeacherId], [Name], [PhoneNumber], [DateofBirth], [Gender], [Address], [Photo]) VALUES (N'T0011', N'Adam hudin', N'087314677817', CAST(N'1980-08-22' AS Date), N'Male', N'Jl. Yos Sudarso No. 79, Surakarta', N'-')
INSERT [dbo].[Teacher] ([TeacherId], [Name], [PhoneNumber], [DateofBirth], [Gender], [Address], [Photo]) VALUES (N'T0012', N'Conny Ken', N'083629914049', CAST(N'1980-08-23' AS Date), N'Female', N'Jl. Vandenburg Gg. Hj Kalam No. 26, Surakarta ', N'-')
INSERT [dbo].[Teacher] ([TeacherId], [Name], [PhoneNumber], [DateofBirth], [Gender], [Address], [Photo]) VALUES (N'T0013', N'Cindy', N'082808492208', CAST(N'1980-08-24' AS Date), N'Female', N'Jl. Keraton No. 387, Surakarta', N'160517104600.png')
INSERT [dbo].[Teacher] ([TeacherId], [Name], [PhoneNumber], [DateofBirth], [Gender], [Address], [Photo]) VALUES (N'T0014', N'Kristian', N'083407419721', CAST(N'1980-08-25' AS Date), N'Male', N'Jl. Gatot Subroto No. 41, Surakarta', N'-')
INSERT [dbo].[Teacher] ([TeacherId], [Name], [PhoneNumber], [DateofBirth], [Gender], [Address], [Photo]) VALUES (N'T0015', N'Dimas Santoso', N'083064285597', CAST(N'1980-08-26' AS Date), N'Male', N'Komp. Solo Makmur Blok. K No. 28, Surakarta', N'-')
INSERT [dbo].[Teacher] ([TeacherId], [Name], [PhoneNumber], [DateofBirth], [Gender], [Address], [Photo]) VALUES (N'T0016', N'Tito Gunawan', N'085603050550', CAST(N'1980-08-27' AS Date), N'Male', N'Jl. Solo Baru No. 192,Sukoharjo', N'-')
INSERT [dbo].[Teacher] ([TeacherId], [Name], [PhoneNumber], [DateofBirth], [Gender], [Address], [Photo]) VALUES (N'T0017', N'Kurnia Jaya', N'089643299667', CAST(N'1980-08-28' AS Date), N'Male', N'Komp. Bumi Sari Indah No.77, Surakarta', N'-')
INSERT [dbo].[Teacher] ([TeacherId], [Name], [PhoneNumber], [DateofBirth], [Gender], [Address], [Photo]) VALUES (N'T0018', N'Ilman Halim', N'087948727992', CAST(N'1980-08-29' AS Date), N'Male', N'Komp. Griya Bima Asri Blok.D No. 37, Surakarta', N'-')
INSERT [dbo].[Teacher] ([TeacherId], [Name], [PhoneNumber], [DateofBirth], [Gender], [Address], [Photo]) VALUES (N'T0019', N'George Tan', N'084928397718', CAST(N'1980-09-01' AS Date), N'Male', N'Jl. Vandenburg Gg. Hj Kasim No. 16, Surakarta ', N'-')
INSERT [dbo].[Teacher] ([TeacherId], [Name], [PhoneNumber], [DateofBirth], [Gender], [Address], [Photo]) VALUES (N'T0020', N'Ina Haminah', N'087893774922', CAST(N'1980-09-02' AS Date), N'Female', N'Jl. Sudirman No. 292, Surakarta', N'-')
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (1, N'T0001', N'testoy', N'Teacher')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (2, N'T0002', N'JkDZtsgfn2', N'Teacher')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (3, N'T0003', N'Wwmw4k44Y', N'Teacher')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (4, N'T0004', N'tP2mA1eR', N'Teacher')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (5, N'T0005', N'Iq7ySHrWAW', N'Teacher')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (6, N'T0006', N'L71lWreH', N'Teacher')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (7, N'T0007', N'KlveW4SNxT', N'Teacher')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (8, N'T0008', N'UTIPqhpgQJ', N'Teacher')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (9, N'T0009', N'u3pHcE', N'Teacher')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (10, N'T0010', N'NYFtKV3X69', N'Teacher')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (11, N'T0011', N'NuzCoRV9b', N'Teacher')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (12, N'T0012', N'45f3fp', N'Teacher')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (13, N'T0013', N'EIeq3p2stc', N'Teacher')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (14, N'T0014', N'abaOSBCDmR', N'Teacher')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (15, N'T0015', N'Y3zRn5', N'Teacher')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (16, N'T0016', N'teyG82', N'Teacher')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (17, N'T0017', N'ebs6Vf', N'Teacher')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (18, N'T0018', N'fXkf3y', N'Teacher')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (19, N'T0019', N'999zQD', N'Teacher')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (20, N'T0020', N'MHp3XA', N'Teacher')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (21, N'20170001', N'eGECi5', N'Student')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (22, N'20170002', N'DIZ5DACG3g', N'Student')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (23, N'20170003', N'MPqYq1ltew', N'Student')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (24, N'20170004', N'Ua5hgvRV8a', N'Student')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (25, N'20170005', N'KeQ8azJ', N'Student')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (26, N'20170006', N'V1drEKo9Zp', N'Student')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (27, N'20170007', N'0eXtq6IUy', N'Student')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (28, N'20170008', N'D7gBH42', N'Student')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (29, N'20170009', N'do9kditorr', N'Student')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (30, N'20170010', N'PYpKZMz', N'Student')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (31, N'20170011', N'Azl0SqG04l', N'Student')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (32, N'20170012', N'BdTNFg', N'Student')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (33, N'20170013', N'aafTWce', N'Student')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (34, N'20170014', N'APldwi8l08', N'Student')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (35, N'20170015', N'OC2AIr', N'Student')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (36, N'20170016', N'SQujTUAUD', N'Student')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (37, N'20170017', N'bJIjm4I2A', N'Student')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (38, N'20170018', N'HPLdqZgmSW', N'Student')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (39, N'20170019', N'JDYCO1gWYH', N'Student')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (40, N'20160001', N'uVqRQE', N'Student')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (41, N'20160002', N'tPbfeUIJ', N'Student')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (42, N'20160003', N'v3wzAuNr', N'Student')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (43, N'20160004', N'NK2kk5prEY', N'Student')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (44, N'20160005', N'IMz0SSb9c', N'Student')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (45, N'20160006', N'X4bLBpezmQ', N'Student')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (46, N'20160007', N'UqJvwY30Mb', N'Student')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (47, N'20160008', N'vDa3DKHC', N'Student')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (48, N'20160009', N'j2ZnIre5g', N'Student')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (49, N'20160010', N'CXELges', N'Student')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (50, N'20160011', N'9PWMU5KU', N'Student')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (51, N'20160012', N'gCUcSD50I', N'Student')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (52, N'20160013', N'pgpI3lj1Rv', N'Student')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (53, N'20160014', N'6EpVNgzetJ', N'Student')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (54, N'20160015', N'x8wF88', N'Student')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (55, N'20160016', N'YfalDMxQ5g', N'Student')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (56, N'20160017', N'MAny0N', N'Student')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (57, N'20160018', N'nZU1mpNqe', N'Student')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (58, N'20150001', N'x2IPQLMXT3', N'Student')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (59, N'20150002', N'C7YyOl57al', N'Student')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (60, N'20150003', N'kLgr066hz', N'Student')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (61, N'20150004', N'gt2L1l', N'Student')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (62, N'20150005', N'6fF4wM4fK', N'Student')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (63, N'20150006', N'VjX2lrgfAj', N'Student')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (64, N'20150007', N'uclFtykmT', N'Student')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (65, N'20150008', N'7iRgSPuthW', N'Student')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (66, N'20150009', N'kyiWJOpvd', N'Student')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (67, N'20150010', N'XLVqyzFIRO', N'Student')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (68, N'20150011', N'4T7IK5ACix', N'Student')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (69, N'20150012', N'ZV36Knqj', N'Student')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (70, N'20150013', N'GeJpI8z', N'Student')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (71, N'20150014', N'66LcsiI7z', N'Student')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (72, N'20150015', N'XqpdIsxP2', N'Student')
INSERT [dbo].[User] ([userid], [username], [password], [role]) VALUES (73, N'20150016', N'1PBnCC', N'Student')
SET IDENTITY_INSERT [dbo].[User] OFF
ALTER TABLE [dbo].[DetailClass]  WITH CHECK ADD  CONSTRAINT [FK_DetailClass_Class] FOREIGN KEY([ClassName])
REFERENCES [dbo].[Class] ([ClassName])
GO
ALTER TABLE [dbo].[DetailClass] CHECK CONSTRAINT [FK_DetailClass_Class]
GO
ALTER TABLE [dbo].[DetailClass]  WITH CHECK ADD  CONSTRAINT [FK_DetailClass_Student] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Student] ([StudentId])
GO
ALTER TABLE [dbo].[DetailClass] CHECK CONSTRAINT [FK_DetailClass_Student]
GO
ALTER TABLE [dbo].[DetailSchedule]  WITH CHECK ADD  CONSTRAINT [FK_DetailSchedule_HeaderSchedule] FOREIGN KEY([ScheduleId])
REFERENCES [dbo].[HeaderSchedule] ([ScheduleId])
GO
ALTER TABLE [dbo].[DetailSchedule] CHECK CONSTRAINT [FK_DetailSchedule_HeaderSchedule]
GO
ALTER TABLE [dbo].[DetailSchedule]  WITH CHECK ADD  CONSTRAINT [FK_DetailSchedule_Shift] FOREIGN KEY([ShiftId])
REFERENCES [dbo].[Shift] ([ShiftId])
GO
ALTER TABLE [dbo].[DetailSchedule] CHECK CONSTRAINT [FK_DetailSchedule_Shift]
GO
ALTER TABLE [dbo].[DetailSchedule]  WITH CHECK ADD  CONSTRAINT [FK_DetailSchedule_Subject] FOREIGN KEY([SubjectId])
REFERENCES [dbo].[Subject] ([SubjectId])
GO
ALTER TABLE [dbo].[DetailSchedule] CHECK CONSTRAINT [FK_DetailSchedule_Subject]
GO
ALTER TABLE [dbo].[DetailScore]  WITH CHECK ADD  CONSTRAINT [FK_DetailScore_DetailSchedule] FOREIGN KEY([DetailID])
REFERENCES [dbo].[DetailSchedule] ([DetailId])
GO
ALTER TABLE [dbo].[DetailScore] CHECK CONSTRAINT [FK_DetailScore_DetailSchedule]
GO
ALTER TABLE [dbo].[DetailScore]  WITH CHECK ADD  CONSTRAINT [FK_DetailScore_Student] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Student] ([StudentId])
GO
ALTER TABLE [dbo].[DetailScore] CHECK CONSTRAINT [FK_DetailScore_Student]
GO
ALTER TABLE [dbo].[Expertise]  WITH CHECK ADD  CONSTRAINT [FK_Expertise_Subject] FOREIGN KEY([SubjectID])
REFERENCES [dbo].[Subject] ([SubjectId])
GO
ALTER TABLE [dbo].[Expertise] CHECK CONSTRAINT [FK_Expertise_Subject]
GO
ALTER TABLE [dbo].[Expertise]  WITH CHECK ADD  CONSTRAINT [FK_Expertise_Teacher] FOREIGN KEY([TeacherID])
REFERENCES [dbo].[Teacher] ([TeacherId])
GO
ALTER TABLE [dbo].[Expertise] CHECK CONSTRAINT [FK_Expertise_Teacher]
GO
ALTER TABLE [dbo].[HeaderSchedule]  WITH CHECK ADD  CONSTRAINT [FK_HeaderSchedule_Class] FOREIGN KEY([ClassName])
REFERENCES [dbo].[Class] ([ClassName])
GO
ALTER TABLE [dbo].[HeaderSchedule] CHECK CONSTRAINT [FK_HeaderSchedule_Class]
GO
ALTER TABLE [dbo].[User]  WITH NOCHECK ADD  CONSTRAINT [FK_User_Student] FOREIGN KEY([username])
REFERENCES [dbo].[Student] ([StudentId])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Student]
GO
ALTER TABLE [dbo].[User]  WITH NOCHECK ADD  CONSTRAINT [FK_User_Teacher] FOREIGN KEY([username])
REFERENCES [dbo].[Teacher] ([TeacherId])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Teacher]
GO
