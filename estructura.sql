USE [PELUQUERIA_CRUD]
GO
/****** Object:  Table [dbo].[Tabla_clientes]    Script Date: 1/9/2022 13:10:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tabla_clientes](
	[cliente_IdClientes] [varchar](15) NOT NULL,
	[cliente_Nombre] [varchar](50) NULL,
	[cliente_Telefono] [int] NULL,
	[cliente_Direccion] [varchar](100) NULL,
	[cliente_Observaciones] [varchar](100) NULL,
 CONSTRAINT [PK_Tabla_clientes] PRIMARY KEY CLUSTERED 
(
	[cliente_IdClientes] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
