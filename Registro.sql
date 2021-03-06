USE [Registro]
GO
/****** Object:  Table [dbo].[alm_alumno]    Script Date: 28/06/2021 21:55:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[alm_alumno](
	[alm_id] [int] NOT NULL,
	[alm_nombre] [varchar](300) NOT NULL,
	[alm_edad] [int] NOT NULL,
	[alm_sexo] [varchar](100) NOT NULL,
	[alm_id_grd] [int] NOT NULL,
	[alm_observaciones] [varchar](300) NOT NULL,
	[created_at] [datetime] NOT NULL,
	[update_at] [datetime] NOT NULL,
 CONSTRAINT [PK_alm_alumno] PRIMARY KEY CLUSTERED 
(
	[alm_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[grd_grado]    Script Date: 28/06/2021 21:55:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[grd_grado](
	[grd_Id] [int] NOT NULL,
	[grd_Nombre] [varchar](100) NOT NULL,
	[created_at] [datetime] NOT NULL,
	[updated_at] [datetime] NOT NULL,
 CONSTRAINT [PK_grd_grado] PRIMARY KEY CLUSTERED 
(
	[grd_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[mat_materia]    Script Date: 28/06/2021 21:55:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mat_materia](
	[mat_id] [int] NOT NULL,
	[mat_nombre] [varchar](100) NOT NULL,
	[created_at] [datetime] NOT NULL,
	[updated_at] [datetime] NOT NULL,
 CONSTRAINT [PK_mat_materia] PRIMARY KEY CLUSTERED 
(
	[mat_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[mxg_materiasxgrado]    Script Date: 28/06/2021 21:55:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mxg_materiasxgrado](
	[mxg_id] [int] NOT NULL,
	[mxg_id_grd] [int] NOT NULL,
	[mxg_id_mat] [int] NOT NULL,
	[created_at] [datetime] NOT NULL,
	[updated_at] [datetime] NOT NULL,
 CONSTRAINT [PK_mxg_materiasxgrado] PRIMARY KEY CLUSTERED 
(
	[mxg_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[alm_alumno] ([alm_id], [alm_nombre], [alm_edad], [alm_sexo], [alm_id_grd], [alm_observaciones], [created_at], [update_at]) VALUES (1, N'Rudy Ricardo', 21, N'Maculino', 1, N'Examen Aprobado', CAST(N'2021-06-26T06:22:07.300' AS DateTime), CAST(N'2021-06-27T00:00:00.000' AS DateTime))
INSERT [dbo].[alm_alumno] ([alm_id], [alm_nombre], [alm_edad], [alm_sexo], [alm_id_grd], [alm_observaciones], [created_at], [update_at]) VALUES (2, N'Estefany Ramirez', 23, N'Femenino', 1, N'Pendiente de examen', CAST(N'2021-06-26T00:00:00.000' AS DateTime), CAST(N'2021-06-28T00:00:00.000' AS DateTime))
INSERT [dbo].[alm_alumno] ([alm_id], [alm_nombre], [alm_edad], [alm_sexo], [alm_id_grd], [alm_observaciones], [created_at], [update_at]) VALUES (4, N'Gerardo Alfonso', 22, N'Masculino', 1, N'Pendiente de examen', CAST(N'2021-06-29T00:00:00.000' AS DateTime), CAST(N'2021-06-26T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[grd_grado] ([grd_Id], [grd_Nombre], [created_at], [updated_at]) VALUES (1, N'Segundo de Primaria', CAST(N'2021-06-25T00:00:00.000' AS DateTime), CAST(N'2021-06-25T00:00:00.000' AS DateTime))
INSERT [dbo].[grd_grado] ([grd_Id], [grd_Nombre], [created_at], [updated_at]) VALUES (2, N'Bachillerato General', CAST(N'2021-06-24T00:00:00.000' AS DateTime), CAST(N'2021-06-26T00:00:00.000' AS DateTime))
INSERT [dbo].[grd_grado] ([grd_Id], [grd_Nombre], [created_at], [updated_at]) VALUES (3, N'Segundo de Primaria', CAST(N'2021-06-24T00:00:00.000' AS DateTime), CAST(N'2021-06-27T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[mat_materia] ([mat_id], [mat_nombre], [created_at], [updated_at]) VALUES (1, N'Matematica II', CAST(N'2021-06-24T22:09:19.000' AS DateTime), CAST(N'2021-06-27T00:00:00.000' AS DateTime))
INSERT [dbo].[mat_materia] ([mat_id], [mat_nombre], [created_at], [updated_at]) VALUES (2, N'Lenguaje y escritura Salvadoreña II', CAST(N'2021-06-26T00:00:00.000' AS DateTime), CAST(N'2021-06-27T00:00:00.000' AS DateTime))
INSERT [dbo].[mat_materia] ([mat_id], [mat_nombre], [created_at], [updated_at]) VALUES (3, N'Estudios Sociales', CAST(N'2021-06-02T00:00:00.000' AS DateTime), CAST(N'2021-06-28T00:00:00.000' AS DateTime))
INSERT [dbo].[mat_materia] ([mat_id], [mat_nombre], [created_at], [updated_at]) VALUES (4, N'Informatica', CAST(N'2021-06-29T00:00:00.000' AS DateTime), CAST(N'2021-06-30T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[mxg_materiasxgrado] ([mxg_id], [mxg_id_grd], [mxg_id_mat], [created_at], [updated_at]) VALUES (1, 1, 1, CAST(N'2021-06-26T10:58:59.800' AS DateTime), CAST(N'2021-06-26T10:58:59.800' AS DateTime))
GO
ALTER TABLE [dbo].[alm_alumno]  WITH CHECK ADD FOREIGN KEY([alm_id_grd])
REFERENCES [dbo].[grd_grado] ([grd_Id])
GO
ALTER TABLE [dbo].[mxg_materiasxgrado]  WITH CHECK ADD FOREIGN KEY([mxg_id_grd])
REFERENCES [dbo].[grd_grado] ([grd_Id])
GO
ALTER TABLE [dbo].[mxg_materiasxgrado]  WITH CHECK ADD FOREIGN KEY([mxg_id_mat])
REFERENCES [dbo].[mat_materia] ([mat_id])
GO
/****** Object:  StoredProcedure [dbo].[CreateGrade]    Script Date: 28/06/2021 21:55:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[CreateGrade]
	-- Add the parameters for the stored procedure here
	@idgrado int,
	@grado_name varchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Insert into grd_grado values(@idgrado, @grado_name, SYSDATETIME(), SYSDATETIME());
END
GO
/****** Object:  StoredProcedure [dbo].[CreateMateria]    Script Date: 28/06/2021 21:55:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[CreateMateria] 
	-- Add the parameters for the stored procedure here
	@mat_id int, 
	@mat_nombre varchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Insert into mat_materia values(@mat_id, @mat_nombre, SYSDATETIME(), SYSDATETIME());
END
GO
/****** Object:  StoredProcedure [dbo].[GradoMateria]    Script Date: 28/06/2021 21:55:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GradoMateria]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select mg.mxg_id_grd, m.mat_nombre, g.grd_Nombre
from mxg_materiasxgrado as mg inner join mat_materia as m on mg.mxg_id_mat=m.mat_id
inner join grd_grado g 
on mg.mxg_id_grd=g.grd_Id
END
GO
