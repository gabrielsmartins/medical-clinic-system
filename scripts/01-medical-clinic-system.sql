USE [master]
GO

DROP DATABASE IF EXISTS [medical-clinic-system]
GO

CREATE DATABASE [medical-clinic-system]
GO

USE [medical-clinic-system]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Medical_Appointments](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[patient_id] [uniqueidentifier] NOT NULL,
	[anamnesis] [varchar](500) NOT NULL,
	[icd] [varchar](50) NULL,
	[created_at] [datetime] NOT NULL,
	[updated_at] [datetime] NOT NULL,
 CONSTRAINT [PK_Medical_Appointments] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Patients](
	[id] [uniqueidentifier] DEFAULT (newsequentialid()) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[mother_name] [varchar](50) NOT NULL,
	[date_of_birth] [date] NOT NULL,
	[gender] [char](1) NOT NULL,
	[medication_allergy] [bit] NULL,
	[medication_allergy_description] [varchar](256) NULL,
	[created_at] [datetime] NOT NULL,
	[updated_at] [datetime] NOT NULL,
 CONSTRAINT [PK_Patients] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Medical_Appointments]  WITH CHECK ADD  CONSTRAINT [FK_Medical_Appointment_Patients] FOREIGN KEY([patient_id])
REFERENCES [dbo].[Patients] ([id])
GO
ALTER TABLE [dbo].[Medical_Appointments] CHECK CONSTRAINT [FK_Medical_Appointment_Patients]
GO