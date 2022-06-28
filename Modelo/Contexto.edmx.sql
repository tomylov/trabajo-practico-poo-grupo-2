
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/28/2022 09:42:48
-- Generated from EDMX file: C:\Users\Tomás AREAS KARLE\Desktop\28\trabajo-practico-poo-grupo-2\Modelo\Contexto.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [POO_grupo2];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Usuarios'
CREATE TABLE [dbo].[Usuarios] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DNI] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Contraseña] nvarchar(max)  NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Telefono] nvarchar(max)  NOT NULL,
    [perfil_Id] int  NOT NULL
);
GO

-- Creating table 'Formulario'
CREATE TABLE [dbo].[Formulario] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [NombreSistema] nvarchar(max)  NOT NULL,
    [perfilId] int  NOT NULL
);
GO

-- Creating table 'permisoSet'
CREATE TABLE [dbo].[permisoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [NombreSistema] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'perfil'
CREATE TABLE [dbo].[perfil] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Ventas'
CREATE TABLE [dbo].[Ventas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [fecha] nvarchar(max)  NOT NULL,
    [Usuario_Id] int  NOT NULL
);
GO

-- Creating table 'Detalle_ventas'
CREATE TABLE [dbo].[Detalle_ventas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [cantidad] nvarchar(max)  NOT NULL,
    [Ventas_Id] int  NOT NULL,
    [Articulos_Id] int  NOT NULL
);
GO

-- Creating table 'Articulos'
CREATE TABLE [dbo].[Articulos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [nombre] nvarchar(max)  NOT NULL,
    [stock] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Formulariopermiso'
CREATE TABLE [dbo].[Formulariopermiso] (
    [Formulario_Id] int  NOT NULL,
    [permiso_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Usuarios'
ALTER TABLE [dbo].[Usuarios]
ADD CONSTRAINT [PK_Usuarios]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Formulario'
ALTER TABLE [dbo].[Formulario]
ADD CONSTRAINT [PK_Formulario]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'permisoSet'
ALTER TABLE [dbo].[permisoSet]
ADD CONSTRAINT [PK_permisoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'perfil'
ALTER TABLE [dbo].[perfil]
ADD CONSTRAINT [PK_perfil]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Ventas'
ALTER TABLE [dbo].[Ventas]
ADD CONSTRAINT [PK_Ventas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Detalle_ventas'
ALTER TABLE [dbo].[Detalle_ventas]
ADD CONSTRAINT [PK_Detalle_ventas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Articulos'
ALTER TABLE [dbo].[Articulos]
ADD CONSTRAINT [PK_Articulos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Formulario_Id], [permiso_Id] in table 'Formulariopermiso'
ALTER TABLE [dbo].[Formulariopermiso]
ADD CONSTRAINT [PK_Formulariopermiso]
    PRIMARY KEY CLUSTERED ([Formulario_Id], [permiso_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [perfil_Id] in table 'Usuarios'
ALTER TABLE [dbo].[Usuarios]
ADD CONSTRAINT [FK_Usuarioperfil]
    FOREIGN KEY ([perfil_Id])
    REFERENCES [dbo].[perfil]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Usuarioperfil'
CREATE INDEX [IX_FK_Usuarioperfil]
ON [dbo].[Usuarios]
    ([perfil_Id]);
GO

-- Creating foreign key on [perfilId] in table 'Formulario'
ALTER TABLE [dbo].[Formulario]
ADD CONSTRAINT [FK_perfilFormulario]
    FOREIGN KEY ([perfilId])
    REFERENCES [dbo].[perfil]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_perfilFormulario'
CREATE INDEX [IX_FK_perfilFormulario]
ON [dbo].[Formulario]
    ([perfilId]);
GO

-- Creating foreign key on [Formulario_Id] in table 'Formulariopermiso'
ALTER TABLE [dbo].[Formulariopermiso]
ADD CONSTRAINT [FK_Formulariopermiso_Formulario]
    FOREIGN KEY ([Formulario_Id])
    REFERENCES [dbo].[Formulario]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [permiso_Id] in table 'Formulariopermiso'
ALTER TABLE [dbo].[Formulariopermiso]
ADD CONSTRAINT [FK_Formulariopermiso_permiso]
    FOREIGN KEY ([permiso_Id])
    REFERENCES [dbo].[permisoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Formulariopermiso_permiso'
CREATE INDEX [IX_FK_Formulariopermiso_permiso]
ON [dbo].[Formulariopermiso]
    ([permiso_Id]);
GO

-- Creating foreign key on [Usuario_Id] in table 'Ventas'
ALTER TABLE [dbo].[Ventas]
ADD CONSTRAINT [FK_VentasUsuario]
    FOREIGN KEY ([Usuario_Id])
    REFERENCES [dbo].[Usuarios]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VentasUsuario'
CREATE INDEX [IX_FK_VentasUsuario]
ON [dbo].[Ventas]
    ([Usuario_Id]);
GO

-- Creating foreign key on [Ventas_Id] in table 'Detalle_ventas'
ALTER TABLE [dbo].[Detalle_ventas]
ADD CONSTRAINT [FK_VentasDetalle_ventas]
    FOREIGN KEY ([Ventas_Id])
    REFERENCES [dbo].[Ventas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VentasDetalle_ventas'
CREATE INDEX [IX_FK_VentasDetalle_ventas]
ON [dbo].[Detalle_ventas]
    ([Ventas_Id]);
GO

-- Creating foreign key on [Articulos_Id] in table 'Detalle_ventas'
ALTER TABLE [dbo].[Detalle_ventas]
ADD CONSTRAINT [FK_ArticulosDetalle_ventas]
    FOREIGN KEY ([Articulos_Id])
    REFERENCES [dbo].[Articulos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ArticulosDetalle_ventas'
CREATE INDEX [IX_FK_ArticulosDetalle_ventas]
ON [dbo].[Detalle_ventas]
    ([Articulos_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------