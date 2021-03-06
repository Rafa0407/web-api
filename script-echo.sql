USE [BD]
GO
/****** Object:  Table [dbo].[Admision]    Script Date: 18/09/2019 18:26:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admision](
	[idIAdmision] [int] IDENTITY(1,1) NOT NULL,
	[creadoPor] [int] NULL,
	[Internamiento] [int] NULL,
	[fechaAdmision] [datetime] NULL,
	[habitacionAsignada] [smallint] NULL,
	[Acompannantes] [int] NULL,
	[diagnosticoIngreso] [varchar](255) NULL,
	[fechaIngreso] [datetime] NULL,
	[diagnosticoEgreso] [varchar](255) NULL,
	[procedimientosRealizados] [nchar](10) NULL,
 CONSTRAINT [PK_Admision] PRIMARY KEY CLUSTERED 
(
	[idIAdmision] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Alergias]    Script Date: 18/09/2019 18:26:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alergias](
	[IdAlergia] [int] IDENTITY(1,1) NOT NULL,
	[Medicamento] [nvarchar](40) NULL,
	[historiaClinica] [int] NULL,
 CONSTRAINT [PK_Alergias] PRIMARY KEY CLUSTERED 
(
	[IdAlergia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ControlNotas]    Script Date: 18/09/2019 18:26:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ControlNotas](
	[idControlNotas] [int] IDENTITY(1,1) NOT NULL,
	[fechaNota] [datetime] NULL,
	[medicamentoSuministrado] [varchar](50) NULL,
	[nota] [varchar](255) NULL,
	[creadoPor] [int] NULL,
	[notasEnfermeria] [int] NULL,
 CONSTRAINT [PK_ControlNotas] PRIMARY KEY CLUSTERED 
(
	[idControlNotas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ControlSignos]    Script Date: 18/09/2019 18:26:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ControlSignos](
	[idControlSignos] [int] IDENTITY(1,1) NOT NULL,
	[Internamiento] [int] NULL,
 CONSTRAINT [PK_ControlSignos] PRIMARY KEY CLUSTERED 
(
	[idControlSignos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CosentimientoInformado]    Script Date: 18/09/2019 18:26:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CosentimientoInformado](
	[idConsentimiento] [int] NOT NULL,
	[fechaCreacion] [datetime] NULL,
	[archivoConsentimiento] [varchar](max) NULL,
	[Internamiento] [int] NULL,
	[creadoPor] [int] NULL,
 CONSTRAINT [PK_CosentimientoInformado] PRIMARY KEY CLUSTERED 
(
	[idConsentimiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DatosPadres]    Script Date: 18/09/2019 18:26:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatosPadres](
	[idDatosPadres] [int] IDENTITY(1,1) NOT NULL,
	[identificacionPadre] [varchar](50) NULL,
	[identificacionMadre] [varchar](50) NULL,
	[NombrePadre] [varchar](50) NULL,
	[NombreMadre] [varchar](50) NULL,
	[Paciente] [int] NULL,
 CONSTRAINT [PK_DatosPadres] PRIMARY KEY CLUSTERED 
(
	[idDatosPadres] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExamenFisico]    Script Date: 18/09/2019 18:26:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExamenFisico](
	[idExamenFisico] [int] IDENTITY(1,1) NOT NULL,
	[fechaAplicacion] [datetime] NULL,
	[presionArterial] [varchar](10) NULL,
	[frecuenciaCardiaca] [int] NULL,
	[frecuenciaRespiratoria] [int] NULL,
	[temperatura] [int] NULL,
	[saturacionOxigeno] [int] NULL,
	[talla] [int] NULL,
	[peso] [int] NULL,
	[aspecto] [varchar](50) NULL,
	[historiaClinica] [int] NULL,
 CONSTRAINT [PK_ExamenFisico] PRIMARY KEY CLUSTERED 
(
	[idExamenFisico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HistoriaClinica]    Script Date: 18/09/2019 18:26:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HistoriaClinica](
	[idIHistoriaClinica] [int] IDENTITY(1,1) NOT NULL,
	[Internamiento] [int] NULL,
	[fechaHistoria] [datetime] NULL,
	[creadoPor] [int] NULL,
	[servicio] [varchar](50) NULL,
	[peso] [int] NULL,
	[talla] [smallint] NULL,
	[estadoVacunacion] [bit] NULL,
	[AFH] [varchar](255) NULL,
	[APP] [varchar](255) NULL,
	[AQXT] [varchar](255) NULL,
	[AGO] [varchar](255) NULL,
	[tratamientoActual] [varchar](255) NULL,
	[otrosDatos] [varchar](255) NULL,
	[estadoNeurológico] [varchar](255) NULL,
	[oftalmológico] [varchar](255) NULL,
	[cuello] [varchar](255) NULL,
	[ORL] [varchar](255) NULL,
	[paladarDentadura] [varchar](255) NULL,
	[cardiaco] [varchar](255) NULL,
	[toraxPulmonar] [varchar](255) NULL,
	[abdomen] [varchar](255) NULL,
	[extremidades] [varchar](255) NULL,
	[pulsos] [varchar](255) NULL,
	[pielAnexos] [varchar](255) NULL,
	[tactoVaginal] [varchar](255) NULL,
	[tactoRectal] [varchar](255) NULL,
 CONSTRAINT [PK_HistoriaClinica] PRIMARY KEY CLUSTERED 
(
	[idIHistoriaClinica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Internamientos]    Script Date: 18/09/2019 18:26:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Internamientos](
	[idInternamiento] [int] IDENTITY(1,1) NOT NULL,
	[fechaCreacion] [datetime] NOT NULL,
	[estadoInternamiento] [bit] NULL,
	[creadoPor] [int] NULL,
	[MedicoEncargado] [smallint] NULL,
	[PacienteInternamiento] [int] NULL,
	[PersonalMedico] [int] NULL,
 CONSTRAINT [PK_Internamientos] PRIMARY KEY CLUSTERED 
(
	[idInternamiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NotaOperatoria]    Script Date: 18/09/2019 18:26:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NotaOperatoria](
	[idNotaOperatoria] [int] IDENTITY(1,1) NOT NULL,
	[creadoPor] [int] NULL,
	[Internamiento] [int] NULL,
	[fechaNota] [datetime] NULL,
	[diagnosticoPreoperatorio] [varchar](255) NULL,
	[diagnosticoPostoperatorio] [varchar](255) NULL,
	[cirugíaRealizada] [varchar](255) NULL,
	[hallazgos] [varchar](255) NULL,
	[tecnicaEmpleada] [varchar](255) NULL,
	[observaciones] [varchar](255) NULL,
 CONSTRAINT [PK_NotaOperatoria] PRIMARY KEY CLUSTERED 
(
	[idNotaOperatoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NotasEnfermeria]    Script Date: 18/09/2019 18:26:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NotasEnfermeria](
	[idNotaEnfermeria] [int] IDENTITY(1,1) NOT NULL,
	[Internamiento] [int] NULL,
 CONSTRAINT [PK_NotasEnfermeria] PRIMARY KEY CLUSTERED 
(
	[idNotaEnfermeria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NotasEvolucion]    Script Date: 18/09/2019 18:26:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NotasEvolucion](
	[idNotaEvolucion] [int] IDENTITY(1,1) NOT NULL,
	[fechaNota] [datetime] NULL,
	[nota] [varchar](255) NULL,
	[indicaciones] [varchar](255) NULL,
	[estadoNota] [bit] NULL,
	[planEvolucion] [int] NULL,
 CONSTRAINT [PK_NotasEvolución] PRIMARY KEY CLUSTERED 
(
	[idNotaEvolucion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pacientes]    Script Date: 18/09/2019 18:26:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pacientes](
	[IdPaciente] [int] IDENTITY(1,1) NOT NULL,
	[Identificacion] [varchar](20) NOT NULL,
	[IdTipoIdentificacion] [tinyint] NULL,
	[IdNacionalidad] [smallint] NULL,
	[Apellido1] [nvarchar](26) NOT NULL,
	[Apellido2] [nvarchar](26) NULL,
	[Nombre] [varchar](150) NULL,
	[FechaNacimiento] [datetime] NULL,
	[Genero] [nchar](1) NULL,
	[IdEstadoCivil] [tinyint] NULL,
	[IdOcupacion] [smallint] NULL,
	[IdProvincia] [tinyint] NULL,
	[IdCanton] [smallint] NULL,
	[IdDistrito] [int] NULL,
	[OtrasSeñas] [nvarchar](255) NULL,
	[TelefonoHabitacion] [nvarchar](8) NULL,
	[TelefonoMovil] [nvarchar](8) NULL,
	[TelefonoTrabajo] [nvarchar](8) NULL,
	[GrupoSanguineo] [nvarchar](8) NULL,
	[RH] [nvarchar](8) NULL,
	[TieneConyuge] [bit] NULL,
	[CSENC] [nvarchar](50) NULL,
	[Apellido1Conyuge] [nvarchar](26) NULL,
	[Apellido2Conyuge] [nvarchar](26) NULL,
	[NombreConyuge] [nvarchar](30) NULL,
	[OcupacionConyuge] [smallint] NULL,
	[TelefonoMovilConyuge] [nvarchar](8) NULL,
	[TelefonoOficinaConyuge] [nvarchar](8) NULL,
	[FechaRegistro] [datetime] NOT NULL,
	[Usuario] [varchar](50) NULL,
	[EMail] [nvarchar](50) NULL,
	[Email2] [varchar](50) NULL,
	[IDConverioEmpresas] [int] NOT NULL,
	[PrimeraVez] [bit] NOT NULL,
	[NIT] [varchar](20) NULL,
	[NIT_APELLIDO1] [varchar](50) NULL,
	[NIT_APELLIDO2] [varchar](50) NULL,
	[NIT_NOMBRE] [varchar](150) NULL,
	[EdadActual]  AS (((((CONVERT([varchar],floor(CONVERT([float],datediff(day,[FechaNacimiento],getdate()),(0))/(365)),(0))+' Años, ')+CONVERT([varchar],floor((CONVERT([float],datediff(day,[FechaNacimiento],getdate()),(0))/(365)-floor(CONVERT([float],datediff(day,[FechaNacimiento],getdate()),(0))/(365)))*(12)),(0)))+' Meses, ')+CONVERT([varchar],floor(((CONVERT([float],datediff(day,[FechaNacimiento],getdate()),(0))/(365)-floor(CONVERT([float],datediff(day,[FechaNacimiento],getdate()),(0))/(365)))*(12)-floor((CONVERT([float],datediff(day,[FechaNacimiento],getdate()),(0))/(365)-floor(CONVERT([float],datediff(day,[FechaNacimiento],getdate()),(0))/(365)))*(12)))*((365)/(12))),(0)))+' Días'),
	[Activo] [bit] NOT NULL,
	[FechaActualiza] [datetime] NULL,
	[NombreCompleto]  AS (((([Apellido1]+case when len([apellido2])>(1) then ' ' else '' end)+[Apellido2])+case when len([Nombre])>(1) then ' ' else '' end)+[Nombre]),
	[NIT_NOMBRECOMPLETO]  AS (((([NIT_Apellido1]+case when len([NIT_apellido2])>(1) then ' ' else '' end)+[NIT_Apellido2])+case when len([NIT_Nombre])>(1) then ' ' else '' end)+[NIT_Nombre]),
	[Revisado] [bit] NULL,
	[Direccion] [varchar](255) NULL,
	[ClienteExactus] [varchar](20) NULL,
	[numSeguro] [nchar](20) NULL,
	[lugarNacimiento] [nchar](10) NULL,
	[datosPadres] [int] NULL,
 CONSTRAINT [PK_Pacientes] PRIMARY KEY CLUSTERED 
(
	[IdPaciente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY],
 CONSTRAINT [IX_Pacientes_Indentificacion] UNIQUE NONCLUSTERED 
(
	[Identificacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PlanesEvolucion]    Script Date: 18/09/2019 18:26:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlanesEvolucion](
	[idPlanesEvolucion] [int] IDENTITY(1,1) NOT NULL,
	[creadoPor] [int] NULL,
	[Internamiento] [int] NULL,
 CONSTRAINT [PK_PlanesEvolucion] PRIMARY KEY CLUSTERED 
(
	[idPlanesEvolucion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoAlergias]    Script Date: 18/09/2019 18:26:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoAlergias](
	[idTipoAlergia] [int] IDENTITY(1,1) NOT NULL,
	[nombreAlergia] [varchar](50) NULL,
	[alergias] [int] NULL,
 CONSTRAINT [PK_TipoAlergias] PRIMARY KEY CLUSTERED 
(
	[idTipoAlergia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TomaSignos]    Script Date: 18/09/2019 18:26:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TomaSignos](
	[idTomaSignos] [int] IDENTITY(1,1) NOT NULL,
	[fechaToma] [datetime] NULL,
	[creadoPor] [int] NULL,
	[presionArterial] [varchar](50) NULL,
	[temperatura] [varchar](50) NULL,
	[saturacionOxigeno] [varchar](50) NULL,
	[frecuenciaRespiratoria] [varchar](50) NULL,
	[frecienciaCardiaca] [varchar](50) NULL,
	[controlSignos] [int] NULL,
 CONSTRAINT [PK_TomaSignos] PRIMARY KEY CLUSTERED 
(
	[idTomaSignos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Internamientos] ADD  CONSTRAINT [DF_Internamientos_estadoInternamiento]  DEFAULT ((0)) FOR [estadoInternamiento]
GO
ALTER TABLE [dbo].[NotasEvolucion] ADD  CONSTRAINT [DF_NotasEvolución_estadoNota]  DEFAULT ((1)) FOR [estadoNota]
GO
ALTER TABLE [dbo].[Pacientes] ADD  CONSTRAINT [DF__tmp_Pacie__IdTip__766C7FFC]  DEFAULT ((1)) FOR [IdTipoIdentificacion]
GO
ALTER TABLE [dbo].[Pacientes] ADD  CONSTRAINT [DF__tmp_Pacie__IdNac__7760A435]  DEFAULT ((49)) FOR [IdNacionalidad]
GO
ALTER TABLE [dbo].[Pacientes] ADD  CONSTRAINT [DF__tmp_Pacie__Apell__7854C86E]  DEFAULT ('') FOR [Apellido2]
GO
ALTER TABLE [dbo].[Pacientes] ADD  CONSTRAINT [DF__Pacientes__Nombr__3D5EEB29]  DEFAULT ('') FOR [Nombre]
GO
ALTER TABLE [dbo].[Pacientes] ADD  CONSTRAINT [DF__Pacientes__Telef__11757BF3]  DEFAULT (N'') FOR [TelefonoHabitacion]
GO
ALTER TABLE [dbo].[Pacientes] ADD  CONSTRAINT [DF__Pacientes__Telef__1269A02C]  DEFAULT (N'') FOR [TelefonoMovil]
GO
ALTER TABLE [dbo].[Pacientes] ADD  CONSTRAINT [DF__Pacientes__Telef__135DC465]  DEFAULT (N'') FOR [TelefonoTrabajo]
GO
ALTER TABLE [dbo].[Pacientes] ADD  CONSTRAINT [DF__tmp_Pacie__Fecha__7A3D10E0]  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [dbo].[Pacientes] ADD  CONSTRAINT [DF_Pacientes_Usuario]  DEFAULT ('Registro Automatico') FOR [Usuario]
GO
ALTER TABLE [dbo].[Pacientes] ADD  CONSTRAINT [DF__tmp_Pacie__IDCon__7B313519]  DEFAULT ((-1)) FOR [IDConverioEmpresas]
GO
ALTER TABLE [dbo].[Pacientes] ADD  CONSTRAINT [DF__tmp_Pacie__Prime__7C255952]  DEFAULT ((0)) FOR [PrimeraVez]
GO
ALTER TABLE [dbo].[Pacientes] ADD  CONSTRAINT [DF_Pacientes_Activo]  DEFAULT ((1)) FOR [Activo]
GO
ALTER TABLE [dbo].[Admision]  WITH CHECK ADD  CONSTRAINT [FK_Admision_AcompannantePaciente] FOREIGN KEY([Acompannantes])
REFERENCES [dbo].[AcompannantePaciente] ([idAcompannante])
GO
ALTER TABLE [dbo].[Admision] CHECK CONSTRAINT [FK_Admision_AcompannantePaciente]
GO
ALTER TABLE [dbo].[Admision]  WITH CHECK ADD  CONSTRAINT [FK_Admision_Internamientos] FOREIGN KEY([Internamiento])
REFERENCES [dbo].[Internamientos] ([idInternamiento])
GO
ALTER TABLE [dbo].[Admision] CHECK CONSTRAINT [FK_Admision_Internamientos]
GO
ALTER TABLE [dbo].[Admision]  WITH CHECK ADD  CONSTRAINT [FK_Admision_Usuarios] FOREIGN KEY([creadoPor])
REFERENCES [dbo].[Usuarios] ([IdUsusario])
GO
ALTER TABLE [dbo].[Admision] CHECK CONSTRAINT [FK_Admision_Usuarios]
GO
ALTER TABLE [dbo].[Alergias]  WITH CHECK ADD  CONSTRAINT [FK_Alergias_TipoAlergias] FOREIGN KEY([historiaClinica])
REFERENCES [dbo].[HistoriaClinica] ([idIHistoriaClinica])
GO
ALTER TABLE [dbo].[Alergias] CHECK CONSTRAINT [FK_Alergias_TipoAlergias]
GO
ALTER TABLE [dbo].[ControlNotas]  WITH CHECK ADD  CONSTRAINT [FK_ControlNotas_NotasEnfermeria] FOREIGN KEY([notasEnfermeria])
REFERENCES [dbo].[NotasEnfermeria] ([idNotaEnfermeria])
GO
ALTER TABLE [dbo].[ControlNotas] CHECK CONSTRAINT [FK_ControlNotas_NotasEnfermeria]
GO
ALTER TABLE [dbo].[ControlNotas]  WITH CHECK ADD  CONSTRAINT [FK_ControlNotas_Usuarios] FOREIGN KEY([creadoPor])
REFERENCES [dbo].[Usuarios] ([IdUsusario])
GO
ALTER TABLE [dbo].[ControlNotas] CHECK CONSTRAINT [FK_ControlNotas_Usuarios]
GO
ALTER TABLE [dbo].[ControlSignos]  WITH CHECK ADD  CONSTRAINT [FK_ControlSignos_Internamientos] FOREIGN KEY([Internamiento])
REFERENCES [dbo].[Internamientos] ([idInternamiento])
GO
ALTER TABLE [dbo].[ControlSignos] CHECK CONSTRAINT [FK_ControlSignos_Internamientos]
GO
ALTER TABLE [dbo].[CosentimientoInformado]  WITH CHECK ADD  CONSTRAINT [FK_CosentimientoInformado_Internamientos] FOREIGN KEY([Internamiento])
REFERENCES [dbo].[Internamientos] ([idInternamiento])
GO
ALTER TABLE [dbo].[CosentimientoInformado] CHECK CONSTRAINT [FK_CosentimientoInformado_Internamientos]
GO
ALTER TABLE [dbo].[CosentimientoInformado]  WITH CHECK ADD  CONSTRAINT [FK_CosentimientoInformado_Usuarios] FOREIGN KEY([creadoPor])
REFERENCES [dbo].[Usuarios] ([IdUsusario])
GO
ALTER TABLE [dbo].[CosentimientoInformado] CHECK CONSTRAINT [FK_CosentimientoInformado_Usuarios]
GO
ALTER TABLE [dbo].[DatosPadres]  WITH CHECK ADD  CONSTRAINT [FK_DatosPadres_Pacientes] FOREIGN KEY([Paciente])
REFERENCES [dbo].[Pacientes] ([IdPaciente])
GO
ALTER TABLE [dbo].[DatosPadres] CHECK CONSTRAINT [FK_DatosPadres_Pacientes]
GO
ALTER TABLE [dbo].[ExamenFisico]  WITH CHECK ADD  CONSTRAINT [FK_ExamenFisico_HistoriaClinica] FOREIGN KEY([historiaClinica])
REFERENCES [dbo].[HistoriaClinica] ([idIHistoriaClinica])
GO
ALTER TABLE [dbo].[ExamenFisico] CHECK CONSTRAINT [FK_ExamenFisico_HistoriaClinica]
GO
ALTER TABLE [dbo].[HistoriaClinica]  WITH CHECK ADD  CONSTRAINT [FK_HistoriaClinica_Internamientos] FOREIGN KEY([Internamiento])
REFERENCES [dbo].[Internamientos] ([idInternamiento])
GO
ALTER TABLE [dbo].[HistoriaClinica] CHECK CONSTRAINT [FK_HistoriaClinica_Internamientos]
GO
ALTER TABLE [dbo].[HistoriaClinica]  WITH CHECK ADD  CONSTRAINT [FK_HistoriaClinica_Usuarios] FOREIGN KEY([creadoPor])
REFERENCES [dbo].[Usuarios] ([IdUsusario])
GO
ALTER TABLE [dbo].[HistoriaClinica] CHECK CONSTRAINT [FK_HistoriaClinica_Usuarios]
GO
ALTER TABLE [dbo].[Internamientos]  WITH CHECK ADD  CONSTRAINT [FK_Internamientos_Medicos] FOREIGN KEY([MedicoEncargado])
REFERENCES [dbo].[Medicos] ([IdMedico])
GO
ALTER TABLE [dbo].[Internamientos] CHECK CONSTRAINT [FK_Internamientos_Medicos]
GO
ALTER TABLE [dbo].[Internamientos]  WITH CHECK ADD  CONSTRAINT [FK_Internamientos_Pacientes] FOREIGN KEY([PacienteInternamiento])
REFERENCES [dbo].[Pacientes] ([IdPaciente])
GO
ALTER TABLE [dbo].[Internamientos] CHECK CONSTRAINT [FK_Internamientos_Pacientes]
GO
ALTER TABLE [dbo].[Internamientos]  WITH CHECK ADD  CONSTRAINT [FK_Internamientos_PersonalInternamiento] FOREIGN KEY([PersonalMedico])
REFERENCES [dbo].[PersonalInternamiento] ([idPersonalMedico])
GO
ALTER TABLE [dbo].[Internamientos] CHECK CONSTRAINT [FK_Internamientos_PersonalInternamiento]
GO
ALTER TABLE [dbo].[Internamientos]  WITH CHECK ADD  CONSTRAINT [FK_Internamientos_Usuarios] FOREIGN KEY([creadoPor])
REFERENCES [dbo].[Usuarios] ([IdUsusario])
GO
ALTER TABLE [dbo].[Internamientos] CHECK CONSTRAINT [FK_Internamientos_Usuarios]
GO
ALTER TABLE [dbo].[NotaOperatoria]  WITH CHECK ADD  CONSTRAINT [FK_NotaOperatoria_Internamientos] FOREIGN KEY([Internamiento])
REFERENCES [dbo].[Internamientos] ([idInternamiento])
GO
ALTER TABLE [dbo].[NotaOperatoria] CHECK CONSTRAINT [FK_NotaOperatoria_Internamientos]
GO
ALTER TABLE [dbo].[NotaOperatoria]  WITH CHECK ADD  CONSTRAINT [FK_NotaOperatoria_Usuarios] FOREIGN KEY([creadoPor])
REFERENCES [dbo].[Usuarios] ([IdUsusario])
GO
ALTER TABLE [dbo].[NotaOperatoria] CHECK CONSTRAINT [FK_NotaOperatoria_Usuarios]
GO
ALTER TABLE [dbo].[NotasEnfermeria]  WITH CHECK ADD  CONSTRAINT [FK_idNotaEnfermeria_Internamientos] FOREIGN KEY([Internamiento])
REFERENCES [dbo].[Internamientos] ([idInternamiento])
GO
ALTER TABLE [dbo].[NotasEnfermeria] CHECK CONSTRAINT [FK_idNotaEnfermeria_Internamientos]
GO
ALTER TABLE [dbo].[NotasEvolucion]  WITH CHECK ADD  CONSTRAINT [FK_NotasEvolucion_PlanesEvolucion1] FOREIGN KEY([planEvolucion])
REFERENCES [dbo].[PlanesEvolucion] ([idPlanesEvolucion])
GO
ALTER TABLE [dbo].[NotasEvolucion] CHECK CONSTRAINT [FK_NotasEvolucion_PlanesEvolucion1]
GO
ALTER TABLE [dbo].[Pacientes]  WITH NOCHECK ADD  CONSTRAINT [FK_Pacientes_Cantones] FOREIGN KEY([IdCanton])
REFERENCES [dbo].[Cantones] ([IdCanton])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Pacientes] CHECK CONSTRAINT [FK_Pacientes_Cantones]
GO
ALTER TABLE [dbo].[Pacientes]  WITH NOCHECK ADD  CONSTRAINT [FK_Pacientes_EstadoCivil] FOREIGN KEY([IdEstadoCivil])
REFERENCES [dbo].[EstadoCivil] ([IdEstadoCivil])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Pacientes] CHECK CONSTRAINT [FK_Pacientes_EstadoCivil]
GO
ALTER TABLE [dbo].[Pacientes]  WITH NOCHECK ADD  CONSTRAINT [FK_Pacientes_Nacionalidades] FOREIGN KEY([IdNacionalidad])
REFERENCES [dbo].[Nacionalidades] ([IdNacionalidad])
ON UPDATE CASCADE
ON DELETE CASCADE
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Pacientes] CHECK CONSTRAINT [FK_Pacientes_Nacionalidades]
GO
ALTER TABLE [dbo].[Pacientes]  WITH NOCHECK ADD  CONSTRAINT [FK_Pacientes_Ocupaciones] FOREIGN KEY([IdOcupacion])
REFERENCES [dbo].[Ocupaciones] ([IdOcupacion])
GO
ALTER TABLE [dbo].[Pacientes] CHECK CONSTRAINT [FK_Pacientes_Ocupaciones]
GO
ALTER TABLE [dbo].[Pacientes]  WITH NOCHECK ADD  CONSTRAINT [FK_Pacientes_Provincias] FOREIGN KEY([IdProvincia])
REFERENCES [dbo].[Provincias] ([IdProvincia])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Pacientes] CHECK CONSTRAINT [FK_Pacientes_Provincias]
GO
ALTER TABLE [dbo].[Pacientes]  WITH CHECK ADD  CONSTRAINT [FK_Pacientes_TipoIdentificacion] FOREIGN KEY([IdTipoIdentificacion])
REFERENCES [dbo].[TipoIdentificacion] ([IdTipoIdentificacion])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Pacientes] CHECK CONSTRAINT [FK_Pacientes_TipoIdentificacion]
GO
ALTER TABLE [dbo].[PlanesEvolucion]  WITH CHECK ADD  CONSTRAINT [FK_PlanesEvolucion_Internamientos] FOREIGN KEY([Internamiento])
REFERENCES [dbo].[Internamientos] ([idInternamiento])
GO
ALTER TABLE [dbo].[PlanesEvolucion] CHECK CONSTRAINT [FK_PlanesEvolucion_Internamientos]
GO
ALTER TABLE [dbo].[PlanesEvolucion]  WITH CHECK ADD  CONSTRAINT [FK_PlanesEvolucion_Usuarios] FOREIGN KEY([creadoPor])
REFERENCES [dbo].[Usuarios] ([IdUsusario])
GO
ALTER TABLE [dbo].[PlanesEvolucion] CHECK CONSTRAINT [FK_PlanesEvolucion_Usuarios]
GO
ALTER TABLE [dbo].[TipoAlergias]  WITH CHECK ADD  CONSTRAINT [FK_TipoAlergias_Alergias] FOREIGN KEY([alergias])
REFERENCES [dbo].[Alergias] ([IdAlergia])
GO
ALTER TABLE [dbo].[TipoAlergias] CHECK CONSTRAINT [FK_TipoAlergias_Alergias]
GO
ALTER TABLE [dbo].[TomaSignos]  WITH CHECK ADD  CONSTRAINT [FK_TomaSignos_ControlSignos] FOREIGN KEY([controlSignos])
REFERENCES [dbo].[ControlSignos] ([idControlSignos])
GO
ALTER TABLE [dbo].[TomaSignos] CHECK CONSTRAINT [FK_TomaSignos_ControlSignos]
GO
ALTER TABLE [dbo].[TomaSignos]  WITH CHECK ADD  CONSTRAINT [FK_TomaSignos_Usuarios] FOREIGN KEY([creadoPor])
REFERENCES [dbo].[Usuarios] ([IdUsusario])
GO
ALTER TABLE [dbo].[TomaSignos] CHECK CONSTRAINT [FK_TomaSignos_Usuarios]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Número de Identificación' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Pacientes', @level2type=N'COLUMN',@level2name=N'Identificacion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Cómo se enteró de nuestro consultorio' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Pacientes', @level2type=N'COLUMN',@level2name=N'CSENC'
GO
