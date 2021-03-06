USE [cpt03]
GO
/****** Object:  Table [dbo].[Class]    Script Date: 16/05/2017 11.58.01 ******/
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
/****** Object:  Table [dbo].[DetailClass]    Script Date: 16/05/2017 11.58.01 ******/
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
/****** Object:  Table [dbo].[DetailSchedule]    Script Date: 16/05/2017 11.58.01 ******/
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
/****** Object:  Table [dbo].[DetailScore]    Script Date: 16/05/2017 11.58.01 ******/
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
/****** Object:  Table [dbo].[Expertise]    Script Date: 16/05/2017 11.58.01 ******/
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
/****** Object:  Table [dbo].[HeaderSchedule]    Script Date: 16/05/2017 11.58.01 ******/
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
/****** Object:  Table [dbo].[Shift]    Script Date: 16/05/2017 11.58.01 ******/
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
/****** Object:  Table [dbo].[Student]    Script Date: 16/05/2017 11.58.01 ******/
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
/****** Object:  Table [dbo].[Subject]    Script Date: 16/05/2017 11.58.01 ******/
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
/****** Object:  Table [dbo].[Teacher]    Script Date: 16/05/2017 11.58.01 ******/
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
/****** Object:  Table [dbo].[User]    Script Date: 16/05/2017 11.58.01 ******/
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
