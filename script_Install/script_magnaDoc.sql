USE [AST_EMM]
GO
/****** Object:  StoredProcedure [dbo].[spUpdateAstFormato]    Script Date: 3/7/2022 11:55:09 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spUpdateAstFormato]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spUpdateAstFormato]
GO
/****** Object:  StoredProcedure [dbo].[spTipoDocQuery]    Script Date: 3/7/2022 11:55:09 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spTipoDocQuery]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spTipoDocQuery]
GO
/****** Object:  StoredProcedure [dbo].[spLogin]    Script Date: 3/7/2022 11:55:09 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spLogin]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spLogin]
GO
/****** Object:  StoredProcedure [dbo].[spInsertAstSecuencia]    Script Date: 3/7/2022 11:55:09 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spInsertAstSecuencia]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spInsertAstSecuencia]
GO
/****** Object:  StoredProcedure [dbo].[spInsertAstPP]    Script Date: 3/7/2022 11:55:09 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spInsertAstPP]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spInsertAstPP]
GO
/****** Object:  StoredProcedure [dbo].[spInsertAstPI]    Script Date: 3/7/2022 11:55:09 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spInsertAstPI]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spInsertAstPI]
GO
/****** Object:  StoredProcedure [dbo].[spInsertAstGA]    Script Date: 3/7/2022 11:55:09 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spInsertAstGA]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spInsertAstGA]
GO
/****** Object:  StoredProcedure [dbo].[spInsertAstFormato]    Script Date: 3/7/2022 11:55:09 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spInsertAstFormato]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spInsertAstFormato]
GO
/****** Object:  StoredProcedure [dbo].[spGetASTid]    Script Date: 3/7/2022 11:55:09 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spGetASTid]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spGetASTid]
GO
/****** Object:  StoredProcedure [dbo].[spEliminaDetalleAst]    Script Date: 3/7/2022 11:55:09 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spEliminaDetalleAst]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spEliminaDetalleAst]
GO
/****** Object:  StoredProcedure [dbo].[spEliminaAst]    Script Date: 3/7/2022 11:55:09 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spEliminaAst]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spEliminaAst]
GO
/****** Object:  StoredProcedure [dbo].[spDeptos]    Script Date: 3/7/2022 11:55:09 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spDeptos]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spDeptos]
GO
/****** Object:  StoredProcedure [dbo].[spConsultaAstSecuenciaTrab_byId]    Script Date: 3/7/2022 11:55:09 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spConsultaAstSecuenciaTrab_byId]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spConsultaAstSecuenciaTrab_byId]
GO
/****** Object:  StoredProcedure [dbo].[spConsultaAstPracticasProh_byId]    Script Date: 3/7/2022 11:55:09 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spConsultaAstPracticasProh_byId]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spConsultaAstPracticasProh_byId]
GO
/****** Object:  StoredProcedure [dbo].[spConsultaAstPersonalInvo_byId]    Script Date: 3/7/2022 11:55:09 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spConsultaAstPersonalInvo_byId]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spConsultaAstPersonalInvo_byId]
GO
/****** Object:  StoredProcedure [dbo].[spConsultaAstGpoAprobacion_byId]    Script Date: 3/7/2022 11:55:09 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spConsultaAstGpoAprobacion_byId]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spConsultaAstGpoAprobacion_byId]
GO
/****** Object:  StoredProcedure [dbo].[spConsultaAstFormato_byId]    Script Date: 3/7/2022 11:55:09 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spConsultaAstFormato_byId]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spConsultaAstFormato_byId]
GO
/****** Object:  StoredProcedure [dbo].[spConsultaAst]    Script Date: 3/7/2022 11:55:09 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spConsultaAst]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spConsultaAst]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[Refroles2]') AND parent_object_id = OBJECT_ID(N'[dbo].[usuario]'))
ALTER TABLE [dbo].[usuario] DROP CONSTRAINT [Refroles2]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[Refdepartamento3]') AND parent_object_id = OBJECT_ID(N'[dbo].[usuario]'))
ALTER TABLE [dbo].[usuario] DROP CONSTRAINT [Refdepartamento3]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[Refformato_ast5]') AND parent_object_id = OBJECT_ID(N'[dbo].[secuencia_trabajo]'))
ALTER TABLE [dbo].[secuencia_trabajo] DROP CONSTRAINT [Refformato_ast5]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[Refformato_ast6]') AND parent_object_id = OBJECT_ID(N'[dbo].[practicas_prohibidas]'))
ALTER TABLE [dbo].[practicas_prohibidas] DROP CONSTRAINT [Refformato_ast6]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[Refformato_ast18]') AND parent_object_id = OBJECT_ID(N'[dbo].[personal_involucrado]'))
ALTER TABLE [dbo].[personal_involucrado] DROP CONSTRAINT [Refformato_ast18]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[Refformato_ast17]') AND parent_object_id = OBJECT_ID(N'[dbo].[grupo_aprobacion]'))
ALTER TABLE [dbo].[grupo_aprobacion] DROP CONSTRAINT [Refformato_ast17]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[Refusuario8]') AND parent_object_id = OBJECT_ID(N'[dbo].[formato_ast]'))
ALTER TABLE [dbo].[formato_ast] DROP CONSTRAINT [Refusuario8]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[Reftipo_docto4]') AND parent_object_id = OBJECT_ID(N'[dbo].[formato_ast]'))
ALTER TABLE [dbo].[formato_ast] DROP CONSTRAINT [Reftipo_docto4]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[Refdepto_id]') AND parent_object_id = OBJECT_ID(N'[dbo].[formato_ast]'))
ALTER TABLE [dbo].[formato_ast] DROP CONSTRAINT [Refdepto_id]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 3/7/2022 11:55:09 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usuario]') AND type in (N'U'))
DROP TABLE [dbo].[usuario]
GO
/****** Object:  Table [dbo].[tipo_docto]    Script Date: 3/7/2022 11:55:09 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tipo_docto]') AND type in (N'U'))
DROP TABLE [dbo].[tipo_docto]
GO
/****** Object:  Table [dbo].[secuencia_trabajo]    Script Date: 3/7/2022 11:55:09 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[secuencia_trabajo]') AND type in (N'U'))
DROP TABLE [dbo].[secuencia_trabajo]
GO
/****** Object:  Table [dbo].[roles]    Script Date: 3/7/2022 11:55:09 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[roles]') AND type in (N'U'))
DROP TABLE [dbo].[roles]
GO
/****** Object:  Table [dbo].[practicas_prohibidas]    Script Date: 3/7/2022 11:55:09 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[practicas_prohibidas]') AND type in (N'U'))
DROP TABLE [dbo].[practicas_prohibidas]
GO
/****** Object:  Table [dbo].[personal_involucrado]    Script Date: 3/7/2022 11:55:09 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[personal_involucrado]') AND type in (N'U'))
DROP TABLE [dbo].[personal_involucrado]
GO
/****** Object:  Table [dbo].[grupo_aprobacion]    Script Date: 3/7/2022 11:55:09 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[grupo_aprobacion]') AND type in (N'U'))
DROP TABLE [dbo].[grupo_aprobacion]
GO
/****** Object:  Table [dbo].[formato_ast]    Script Date: 3/7/2022 11:55:09 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[formato_ast]') AND type in (N'U'))
DROP TABLE [dbo].[formato_ast]
GO
/****** Object:  Table [dbo].[departamento]    Script Date: 3/7/2022 11:55:09 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[departamento]') AND type in (N'U'))
DROP TABLE [dbo].[departamento]
GO
/****** Object:  Table [dbo].[departamento]    Script Date: 3/7/2022 11:55:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[departamento]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[departamento](
	[dpto_id] [int] IDENTITY(1,1) NOT NULL,
	[dpto_nombre] [varchar](50) NULL,
PRIMARY KEY NONCLUSTERED 
(
	[dpto_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[formato_ast]    Script Date: 3/7/2022 11:55:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[formato_ast]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[formato_ast](
	[ast_id] [int] IDENTITY(1,1) NOT NULL,
	[email_contactoPlanta] [varchar](100) NULL,
	[nombre_docto] [varchar](40) NULL,
	[fecha_creacion] [date] NULL,
	[desc_trabajo_realizar] [varchar](1000) NULL,
	[puestos_involucrados] [varchar](250) NULL,
	[epp_utilizar] [char](250) NULL,
	[tipo_id] [int] NOT NULL,
	[user_id] [int] NOT NULL,
	[motivo_rechazo] [varchar](300) NULL,
	[estatus] [varchar](25) NULL,
	[dpto_id] [int] NULL,
	[area] [varchar](200) NULL,
	[plan_respuesta] [varchar](1000) NULL,
	[hora_fin] [varchar](20) NULL,
	[hora_inicio] [varchar](20) NULL,
PRIMARY KEY NONCLUSTERED 
(
	[ast_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[grupo_aprobacion]    Script Date: 3/7/2022 11:55:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[grupo_aprobacion]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[grupo_aprobacion](
	[gpa_id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](80) NULL,
	[email] [varchar](100) NULL,
	[ast_id] [int] NOT NULL,
PRIMARY KEY NONCLUSTERED 
(
	[gpa_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[personal_involucrado]    Script Date: 3/7/2022 11:55:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[personal_involucrado]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[personal_involucrado](
	[personal_id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NULL,
	[email] [varchar](100) NULL,
	[ast_id] [int] NOT NULL,
PRIMARY KEY NONCLUSTERED 
(
	[personal_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[practicas_prohibidas]    Script Date: 3/7/2022 11:55:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[practicas_prohibidas]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[practicas_prohibidas](
	[practica_id] [int] IDENTITY(1,1) NOT NULL,
	[practica_num] [smallint] NOT NULL,
	[ast_id] [int] NOT NULL,
	[desc_practica] [varchar](300) NULL,
PRIMARY KEY NONCLUSTERED 
(
	[practica_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[roles]    Script Date: 3/7/2022 11:55:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[roles]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[roles](
	[rol_id] [int] IDENTITY(1,1) NOT NULL,
	[rol_nombre] [varchar](25) NULL,
PRIMARY KEY NONCLUSTERED 
(
	[rol_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[secuencia_trabajo]    Script Date: 3/7/2022 11:55:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[secuencia_trabajo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[secuencia_trabajo](
	[sec_id] [int] IDENTITY(1,1) NOT NULL,
	[paso_num] [smallint] NOT NULL,
	[desc_secuencia] [varchar](250) NULL,
	[ast_id] [int] NOT NULL,
	[identifica_riesgos] [varchar](500) NULL,
	[procedmiento_realizar] [varchar](500) NULL,
PRIMARY KEY NONCLUSTERED 
(
	[sec_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tipo_docto]    Script Date: 3/7/2022 11:55:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tipo_docto]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tipo_docto](
	[tipo_id] [int] IDENTITY(1,1) NOT NULL,
	[desc_docto] [varchar](80) NULL,
PRIMARY KEY NONCLUSTERED 
(
	[tipo_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 3/7/2022 11:55:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usuario]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[usuario](
	[user_id] [int] IDENTITY(1,1) NOT NULL,
	[fecha_alta] [date] NOT NULL,
	[nombre] [varchar](80) NOT NULL,
	[email] [varchar](100) NOT NULL,
	[password] [char](10) NULL,
	[esActivo] [bit] NULL,
	[rol_id] [int] NOT NULL,
	[dpto_id] [int] NOT NULL,
	[cia] [varchar](40) NULL,
PRIMARY KEY NONCLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[Refdepto_id]') AND parent_object_id = OBJECT_ID(N'[dbo].[formato_ast]'))
ALTER TABLE [dbo].[formato_ast]  WITH CHECK ADD  CONSTRAINT [Refdepto_id] FOREIGN KEY([dpto_id])
REFERENCES [dbo].[departamento] ([dpto_id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[Refdepto_id]') AND parent_object_id = OBJECT_ID(N'[dbo].[formato_ast]'))
ALTER TABLE [dbo].[formato_ast] CHECK CONSTRAINT [Refdepto_id]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[Reftipo_docto4]') AND parent_object_id = OBJECT_ID(N'[dbo].[formato_ast]'))
ALTER TABLE [dbo].[formato_ast]  WITH CHECK ADD  CONSTRAINT [Reftipo_docto4] FOREIGN KEY([tipo_id])
REFERENCES [dbo].[tipo_docto] ([tipo_id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[Reftipo_docto4]') AND parent_object_id = OBJECT_ID(N'[dbo].[formato_ast]'))
ALTER TABLE [dbo].[formato_ast] CHECK CONSTRAINT [Reftipo_docto4]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[Refusuario8]') AND parent_object_id = OBJECT_ID(N'[dbo].[formato_ast]'))
ALTER TABLE [dbo].[formato_ast]  WITH CHECK ADD  CONSTRAINT [Refusuario8] FOREIGN KEY([user_id])
REFERENCES [dbo].[usuario] ([user_id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[Refusuario8]') AND parent_object_id = OBJECT_ID(N'[dbo].[formato_ast]'))
ALTER TABLE [dbo].[formato_ast] CHECK CONSTRAINT [Refusuario8]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[Refformato_ast17]') AND parent_object_id = OBJECT_ID(N'[dbo].[grupo_aprobacion]'))
ALTER TABLE [dbo].[grupo_aprobacion]  WITH CHECK ADD  CONSTRAINT [Refformato_ast17] FOREIGN KEY([ast_id])
REFERENCES [dbo].[formato_ast] ([ast_id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[Refformato_ast17]') AND parent_object_id = OBJECT_ID(N'[dbo].[grupo_aprobacion]'))
ALTER TABLE [dbo].[grupo_aprobacion] CHECK CONSTRAINT [Refformato_ast17]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[Refformato_ast18]') AND parent_object_id = OBJECT_ID(N'[dbo].[personal_involucrado]'))
ALTER TABLE [dbo].[personal_involucrado]  WITH CHECK ADD  CONSTRAINT [Refformato_ast18] FOREIGN KEY([ast_id])
REFERENCES [dbo].[formato_ast] ([ast_id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[Refformato_ast18]') AND parent_object_id = OBJECT_ID(N'[dbo].[personal_involucrado]'))
ALTER TABLE [dbo].[personal_involucrado] CHECK CONSTRAINT [Refformato_ast18]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[Refformato_ast6]') AND parent_object_id = OBJECT_ID(N'[dbo].[practicas_prohibidas]'))
ALTER TABLE [dbo].[practicas_prohibidas]  WITH CHECK ADD  CONSTRAINT [Refformato_ast6] FOREIGN KEY([ast_id])
REFERENCES [dbo].[formato_ast] ([ast_id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[Refformato_ast6]') AND parent_object_id = OBJECT_ID(N'[dbo].[practicas_prohibidas]'))
ALTER TABLE [dbo].[practicas_prohibidas] CHECK CONSTRAINT [Refformato_ast6]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[Refformato_ast5]') AND parent_object_id = OBJECT_ID(N'[dbo].[secuencia_trabajo]'))
ALTER TABLE [dbo].[secuencia_trabajo]  WITH CHECK ADD  CONSTRAINT [Refformato_ast5] FOREIGN KEY([ast_id])
REFERENCES [dbo].[formato_ast] ([ast_id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[Refformato_ast5]') AND parent_object_id = OBJECT_ID(N'[dbo].[secuencia_trabajo]'))
ALTER TABLE [dbo].[secuencia_trabajo] CHECK CONSTRAINT [Refformato_ast5]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[Refdepartamento3]') AND parent_object_id = OBJECT_ID(N'[dbo].[usuario]'))
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD  CONSTRAINT [Refdepartamento3] FOREIGN KEY([dpto_id])
REFERENCES [dbo].[departamento] ([dpto_id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[Refdepartamento3]') AND parent_object_id = OBJECT_ID(N'[dbo].[usuario]'))
ALTER TABLE [dbo].[usuario] CHECK CONSTRAINT [Refdepartamento3]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[Refroles2]') AND parent_object_id = OBJECT_ID(N'[dbo].[usuario]'))
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD  CONSTRAINT [Refroles2] FOREIGN KEY([rol_id])
REFERENCES [dbo].[roles] ([rol_id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[Refroles2]') AND parent_object_id = OBJECT_ID(N'[dbo].[usuario]'))
ALTER TABLE [dbo].[usuario] CHECK CONSTRAINT [Refroles2]
GO
/****** Object:  StoredProcedure [dbo].[spConsultaAst]    Script Date: 3/7/2022 11:55:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spConsultaAst]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spConsultaAst] AS' 
END
GO
ALTER proc [dbo].[spConsultaAst]
	@prmTipoDocto	int = 1
as
set nocount on
begin
	select 
			a.ast_id, 
			a.email_contactoPlanta, 
			a.nombre_docto, 
			a.fecha_creacion, 
			a.hora_fin, 
			a.hora_inicio, 
			a.desc_trabajo_realizar, 
			a.puestos_involucrados, 
			a.epp_utilizar, 
			a.tipo_id, 
			a.user_id, 
			a.motivo_rechazo,
			a.estatus,
			b.cia,
			c.dpto_nombre,
			A.area
		from formato_ast a
			left join usuario b on
						b.user_id = a.user_id
			left join departamento c on
						c.dpto_id = a.dpto_id
			where tipo_id = @prmTipoDocto
		order by ast_id
end

GO
/****** Object:  StoredProcedure [dbo].[spConsultaAstFormato_byId]    Script Date: 3/7/2022 11:55:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spConsultaAstFormato_byId]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spConsultaAstFormato_byId] AS' 
END
GO


ALTER proc [dbo].[spConsultaAstFormato_byId]
	@p_astid		int
as
set nocount on

begin
	select 
			a.ast_id, 
			a.email_contactoPlanta, 
			a.nombre_docto, 
			a.fecha_creacion, 
			a.hora_fin, 
			a.hora_inicio, 
			a.desc_trabajo_realizar, 
			a.puestos_involucrados, 
			a.epp_utilizar, 
			a.tipo_id, 
			a.user_id, 
			a.motivo_rechazo, 
			a.estatus, 
			a.dpto_id, 
			a.area,
			a.plan_respuesta
		from formato_ast a
		where a.ast_id = @p_astid

end
---- fin ------






GO
/****** Object:  StoredProcedure [dbo].[spConsultaAstGpoAprobacion_byId]    Script Date: 3/7/2022 11:55:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spConsultaAstGpoAprobacion_byId]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spConsultaAstGpoAprobacion_byId] AS' 
END
GO

ALTER proc [dbo].[spConsultaAstGpoAprobacion_byId]
	@p_aspid		int
as
set nocount on

begin
	select 
		gpa_id, 
		nombre, 
		email, 
		ast_id	
	from grupo_aprobacion a
	where a.ast_id = @p_aspid

end
---- fin ------






GO
/****** Object:  StoredProcedure [dbo].[spConsultaAstPersonalInvo_byId]    Script Date: 3/7/2022 11:55:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spConsultaAstPersonalInvo_byId]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spConsultaAstPersonalInvo_byId] AS' 
END
GO

ALTER proc [dbo].[spConsultaAstPersonalInvo_byId]
	@p_aspid		int
as
set nocount on

begin
	select 
		personal_id, 
		nombre, 
		email, 
		ast_id
	from personal_involucrado a
	where a.ast_id = @p_aspid

end
---- fin ------






GO
/****** Object:  StoredProcedure [dbo].[spConsultaAstPracticasProh_byId]    Script Date: 3/7/2022 11:55:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spConsultaAstPracticasProh_byId]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spConsultaAstPracticasProh_byId] AS' 
END
GO

ALTER proc [dbo].[spConsultaAstPracticasProh_byId]
	@p_aspid		int
as
set nocount on

begin
	select 
		practica_id, 
		practica_num,
		desc_practica, 
		ast_id
	from practicas_prohibidas a
	where a.ast_id = @p_aspid

end
---- fin ------






GO
/****** Object:  StoredProcedure [dbo].[spConsultaAstSecuenciaTrab_byId]    Script Date: 3/7/2022 11:55:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spConsultaAstSecuenciaTrab_byId]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spConsultaAstSecuenciaTrab_byId] AS' 
END
GO

ALTER proc [dbo].[spConsultaAstSecuenciaTrab_byId]
	@p_aspid		int
as
set nocount on

begin
	select 
		sec_id, 
		paso_num, 
		desc_secuencia, 
		identifica_riesgos, 
		procedmiento_realizar,
		ast_id
	from secuencia_trabajo a
	where a.ast_id = @p_aspid

end
---- fin ------






GO
/****** Object:  StoredProcedure [dbo].[spDeptos]    Script Date: 3/7/2022 11:55:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spDeptos]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spDeptos] AS' 
END
GO
ALTER proc [dbo].[spDeptos]
as

set nocount on

	select 
		dpto_id,
		dpto_nombre
	from departamento

--end ---
GO
/****** Object:  StoredProcedure [dbo].[spEliminaAst]    Script Date: 3/7/2022 11:55:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spEliminaAst]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spEliminaAst] AS' 
END
GO
ALTER proc [dbo].[spEliminaAst]
	@p_astId				int
as
set nocount on

begin

	delete [dbo].[grupo_aprobacion]			where ast_id = @p_astId
	delete [dbo].[personal_involucrado]		where ast_id = @p_astId
	delete [dbo].[practicas_prohibidas]		where ast_id = @p_astId
	delete [dbo].[secuencia_trabajo]		where ast_id = @p_astId
	delete [dbo].[formato_ast]				where ast_id = @p_astId

end

GO
/****** Object:  StoredProcedure [dbo].[spEliminaDetalleAst]    Script Date: 3/7/2022 11:55:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spEliminaDetalleAst]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spEliminaDetalleAst] AS' 
END
GO
ALTER proc [dbo].[spEliminaDetalleAst]
	@p_astId				int
as
set nocount on

begin

	delete [dbo].[grupo_aprobacion]			where ast_id = @p_astId
	delete [dbo].[personal_involucrado]		where ast_id = @p_astId
	delete [dbo].[practicas_prohibidas]		where ast_id = @p_astId
	delete [dbo].[secuencia_trabajo]		where ast_id = @p_astId

end

GO
/****** Object:  StoredProcedure [dbo].[spGetASTid]    Script Date: 3/7/2022 11:55:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spGetASTid]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spGetASTid] AS' 
END
GO
ALTER proc [dbo].[spGetASTid]
	@p_nombre_docto		varchar(40)
as 

set nocount on
select ast_id 
		from formato_ast 
		where nombre_docto = @p_nombre_docto

----- end ----
GO
/****** Object:  StoredProcedure [dbo].[spInsertAstFormato]    Script Date: 3/7/2022 11:55:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spInsertAstFormato]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spInsertAstFormato] AS' 
END
GO

ALTER proc [dbo].[spInsertAstFormato]
	@p_area							varchar(200),
	@p_fecha						datetime,
	@p_hora_inicio 					varchar(20) ,
	@p_hora_fin 					varchar(20) ,
	@p_email_contactoPlanta 		varchar(100) ,
	@p_nombre_docto 				varchar(30) ,
	@p_desc_trabajo_realizar 		varchar(1000) ,
	@p_puestos_involucrados 		varchar(250) ,
	@p_epp_utilizar 				varchar(250) ,
	@p_tipo_id 						int ,
	@p_user_id 						int ,
	@p_dpto_id						int ,
	@p_motivo_rechazo 				varchar(300),
	@p_estatus						varchar(25) ,
	@p_plan_respuesta				varchar(1000)	
as
set nocount on

begin
	insert into formato_ast ( 
		area,
		email_contactoPlanta, 
		nombre_docto, 
		fecha_creacion, 
		hora_fin, 
		hora_inicio, 
		desc_trabajo_realizar, 
		puestos_involucrados, 
		epp_utilizar, 
		tipo_id, 
		user_id ,
		motivo_rechazo,
		dpto_id,
		estatus,
		plan_respuesta
		)
	values (
		@p_area,
		@p_email_contactoPlanta,
		@p_nombre_docto,
		@p_fecha,
		@p_hora_fin,
		@p_hora_inicio,
		@p_desc_trabajo_realizar,
		@p_puestos_involucrados,
		@p_epp_utilizar,
		@p_tipo_id,
		@p_user_id,
		@p_motivo_rechazo,
		@p_dpto_id,
		@p_estatus,
		@p_plan_respuesta
		)
end

--- end ------
GO
/****** Object:  StoredProcedure [dbo].[spInsertAstGA]    Script Date: 3/7/2022 11:55:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spInsertAstGA]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spInsertAstGA] AS' 
END
GO


ALTER proc [dbo].[spInsertAstGA]
	 @p_nombre		varchar(80), 
	 @p_email		varchar(100), 
	 @p_ast_id		int
as
set nocount on
begin
	insert into grupo_aprobacion (
			nombre,
			email,
			ast_id
		)
	values(
			@p_nombre,	
			@p_email,	
			@p_ast_id	
	)
end

--- end ------
GO
/****** Object:  StoredProcedure [dbo].[spInsertAstPI]    Script Date: 3/7/2022 11:55:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spInsertAstPI]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spInsertAstPI] AS' 
END
GO


ALTER proc [dbo].[spInsertAstPI]
	 @p_nombre		varchar(100), 
	 @p_email		varchar(100) = null, 
	 @p_ast_id		int
	 

as
set nocount on
begin
	insert into personal_involucrado (
		 nombre, 
		 email, 
		 ast_id
		 )
	values(
		@p_nombre,
		@p_email,
		@p_ast_id
	)
end

--- end ------
GO
/****** Object:  StoredProcedure [dbo].[spInsertAstPP]    Script Date: 3/7/2022 11:55:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spInsertAstPP]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spInsertAstPP] AS' 
END
GO


ALTER proc [dbo].[spInsertAstPP]
	 @p_practica_num		smallint,  
	 @p_desc_practica		varchar(300),
	 @p_ast_id				int

as
set nocount on
begin
	insert into practicas_prohibidas (
			practica_num, 
			desc_practica, 
			ast_id
			)
	values(
			@p_practica_num,
			@p_desc_practica,	
			@p_ast_id			
	
		)
end

--- end ------
GO
/****** Object:  StoredProcedure [dbo].[spInsertAstSecuencia]    Script Date: 3/7/2022 11:55:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spInsertAstSecuencia]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spInsertAstSecuencia] AS' 
END
GO


ALTER proc [dbo].[spInsertAstSecuencia]
	@p_paso_num							smallint,
	@p_desc_secuencia					varchar(250),
	@p_identifica_riesgos				varchar(500),
	@p_procedmiento_realizar			varchar(500),
	@p_ast_id							int
as
set nocount on
begin
	insert into secuencia_trabajo (
			paso_num,
			desc_secuencia,
			identifica_riesgos,
			procedmiento_realizar,
			ast_id
		)
	values (
			@p_paso_num,
			@p_desc_secuencia,
			@p_identifica_riesgos,
			@p_procedmiento_realizar,
			@p_ast_id	
		)
end

--- end ------
GO
/****** Object:  StoredProcedure [dbo].[spLogin]    Script Date: 3/7/2022 11:55:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spLogin]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spLogin] AS' 
END
GO
ALTER proc [dbo].[spLogin]
	@prmEmail		varchar(100),
	@prmPass		varchar(10)
as
set nocount on
begin
	
	select user_id,
			nombre,
			email
		from usuario
		where	@prmEmail		= email
			and	@prmPass		= password
			and esActivo		= 1

end
--- end procedure ---
GO
/****** Object:  StoredProcedure [dbo].[spTipoDocQuery]    Script Date: 3/7/2022 11:55:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spTipoDocQuery]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spTipoDocQuery] AS' 
END
GO
ALTER proc [dbo].[spTipoDocQuery]
as
set nocount on
begin
	select 
		tipo_id, 
		desc_docto	
	from [dbo].[tipo_docto] a
end

GO
/****** Object:  StoredProcedure [dbo].[spUpdateAstFormato]    Script Date: 3/7/2022 11:55:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spUpdateAstFormato]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spUpdateAstFormato] AS' 
END
GO

ALTER proc [dbo].[spUpdateAstFormato]
	@p_area							varchar(200),
	--@p_fecha						datetime,
	@p_hora_inicio 					varchar(20) ,
	@p_hora_fin 					varchar(20) ,
	@p_email_contactoPlanta 		varchar(100) ,
	--@p_nombre_docto 				varchar(30) ,
	@p_desc_trabajo_realizar 		varchar(1000) ,
	@p_puestos_involucrados 		varchar(250) ,
	@p_epp_utilizar 				varchar(250) ,
	@p_tipo_id 						int ,
	@p_user_id 						int ,
	@p_dpto_id						int ,
	@p_motivo_rechazo 				varchar(300),
	--@p_estatus						varchar(25) ,
	@p_plan_respuesta				varchar(1000),
	@p_astId						int
as
set nocount on

begin

	update formato_ast set 
		area						= @p_area						,
		email_contactoPlanta		= @p_email_contactoPlanta		, 
		--nombre_docto				= @p_nombre_docto				, 
		--fecha_creacion				= @p_fecha						, 
		hora_fin					= @p_hora_fin					, 
		hora_inicio					= @p_hora_inicio				, 
		desc_trabajo_realizar		= @p_desc_trabajo_realizar		, 
		puestos_involucrados		= @p_puestos_involucrados		, 
		epp_utilizar				= @p_epp_utilizar				, 
		tipo_id						= @p_tipo_id					, 
		user_id						= @p_user_id					,
		motivo_rechazo				= @p_motivo_rechazo			,
		dpto_id						= @p_dpto_id					,
		--estatus						= @p_estatus					,
		plan_respuesta				= @p_plan_respuesta			
	where ast_id = @p_astId



end

--- end ------
GO
