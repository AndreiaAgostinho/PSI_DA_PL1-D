
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/24/2021 11:01:32
-- Generated from EDMX file: C:\Users\yuriohnice\Documents\PSI\S2\Projetos\DA\app\Projeto\Projeto\DB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DA];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_PromotorProcesso]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Processo] DROP CONSTRAINT [FK_PromotorProcesso];
GO
IF OBJECT_ID(N'[dbo].[FK_EstadoProcessoProcesso]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Processo] DROP CONSTRAINT [FK_EstadoProcessoProcesso];
GO
IF OBJECT_ID(N'[dbo].[FK_TipoDocumentoDocumento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Documento] DROP CONSTRAINT [FK_TipoDocumentoDocumento];
GO
IF OBJECT_ID(N'[dbo].[FK_ProcessoProjeto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProjetoSet] DROP CONSTRAINT [FK_ProcessoProjeto];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjetoDocumento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Documento] DROP CONSTRAINT [FK_ProjetoDocumento];
GO
IF OBJECT_ID(N'[dbo].[FK_TipoProcessoTipoProcesso]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TipoProjeto] DROP CONSTRAINT [FK_TipoProcessoTipoProcesso];
GO
IF OBJECT_ID(N'[dbo].[FK_TipoProjetoProjeto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProjetoSet] DROP CONSTRAINT [FK_TipoProjetoProjeto];
GO
IF OBJECT_ID(N'[dbo].[FK_TipoProjetoEspecialista]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EspecialistaSet] DROP CONSTRAINT [FK_TipoProjetoEspecialista];
GO
IF OBJECT_ID(N'[dbo].[FK_ParecerFuncionario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ParecerSet] DROP CONSTRAINT [FK_ParecerFuncionario];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjetoParecer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ParecerSet] DROP CONSTRAINT [FK_ProjetoParecer];
GO
IF OBJECT_ID(N'[dbo].[FK_ParecerDocumento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Documento] DROP CONSTRAINT [FK_ParecerDocumento];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjetoAtribuicaoFuncionario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProjetoAtribuicao] DROP CONSTRAINT [FK_ProjetoAtribuicaoFuncionario];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjetoProjetoAtribuicao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProjetoAtribuicao] DROP CONSTRAINT [FK_ProjetoProjetoAtribuicao];
GO
IF OBJECT_ID(N'[dbo].[FK_EspecialistaFuncionario]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EspecialistaSet] DROP CONSTRAINT [FK_EspecialistaFuncionario];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Promotor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Promotor];
GO
IF OBJECT_ID(N'[dbo].[Processo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Processo];
GO
IF OBJECT_ID(N'[dbo].[EstadoProcesso]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EstadoProcesso];
GO
IF OBJECT_ID(N'[dbo].[TipoDocumento]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TipoDocumento];
GO
IF OBJECT_ID(N'[dbo].[Documento]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Documento];
GO
IF OBJECT_ID(N'[dbo].[ProjetoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProjetoSet];
GO
IF OBJECT_ID(N'[dbo].[TipoProjeto]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TipoProjeto];
GO
IF OBJECT_ID(N'[dbo].[ProjetoAtribuicao]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProjetoAtribuicao];
GO
IF OBJECT_ID(N'[dbo].[Funcionario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Funcionario];
GO
IF OBJECT_ID(N'[dbo].[ParecerSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ParecerSet];
GO
IF OBJECT_ID(N'[dbo].[EspecialistaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EspecialistaSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Promotor'
CREATE TABLE [dbo].[Promotor] (
    [NIF] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Morada] nvarchar(max)  NOT NULL,
    [Telemovel] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [CodigoAcesso] nvarchar(max)  NOT NULL,
    [Senha] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Processo'
CREATE TABLE [dbo].[Processo] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DataInicio] nvarchar(max)  NOT NULL,
    [PromotorNIF] int  NOT NULL,
    [EstadoProcessoId] int  NOT NULL
);
GO

-- Creating table 'EstadoProcesso'
CREATE TABLE [dbo].[EstadoProcesso] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DescricaoEstado] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TipoDocumento'
CREATE TABLE [dbo].[TipoDocumento] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Designacao] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Documento'
CREATE TABLE [dbo].[Documento] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Titulo] nvarchar(max)  NOT NULL,
    [DataEntrega] datetime  NOT NULL,
    [TipoDocumentoId] int  NOT NULL,
    [ProjetoId] int  NOT NULL,
    [ParecerNumero] int  NOT NULL
);
GO

-- Creating table 'ProjetoSet'
CREATE TABLE [dbo].[ProjetoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [EstadoProjeto] nvarchar(max)  NOT NULL,
    [DataEntrega] datetime  NOT NULL,
    [DataAprovação] datetime  NOT NULL,
    [ProcessoId] int  NOT NULL,
    [TipoProjetoId] int  NOT NULL
);
GO

-- Creating table 'TipoProjeto'
CREATE TABLE [dbo].[TipoProjeto] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NrDiasAprovacao] nvarchar(max)  NOT NULL,
    [Designacao] nvarchar(max)  NOT NULL,
    [TipoProcessoAscendenteId] int  NULL
);
GO

-- Creating table 'ProjetoAtribuicao'
CREATE TABLE [dbo].[ProjetoAtribuicao] (
    [Data] nvarchar(max)  NOT NULL,
    [FuncionarioNumero] int  NOT NULL,
    [ProjetoId] int  NOT NULL
);
GO

-- Creating table 'Funcionario'
CREATE TABLE [dbo].[Funcionario] (
    [Numero] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Extencao] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ParecerSet'
CREATE TABLE [dbo].[ParecerSet] (
    [Numero] int IDENTITY(1,1) NOT NULL,
    [TextoParecer] nvarchar(max)  NOT NULL,
    [DataParecer] nvarchar(max)  NOT NULL,
    [FuncionarioNumero] int  NOT NULL,
    [ProjetoId] int  NOT NULL
);
GO

-- Creating table 'EspecialistaSet'
CREATE TABLE [dbo].[EspecialistaSet] (
    [TipoProjetoId] int  NOT NULL,
    [FuncionarioNumero] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [NIF] in table 'Promotor'
ALTER TABLE [dbo].[Promotor]
ADD CONSTRAINT [PK_Promotor]
    PRIMARY KEY CLUSTERED ([NIF] ASC);
GO

-- Creating primary key on [Id] in table 'Processo'
ALTER TABLE [dbo].[Processo]
ADD CONSTRAINT [PK_Processo]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EstadoProcesso'
ALTER TABLE [dbo].[EstadoProcesso]
ADD CONSTRAINT [PK_EstadoProcesso]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TipoDocumento'
ALTER TABLE [dbo].[TipoDocumento]
ADD CONSTRAINT [PK_TipoDocumento]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Documento'
ALTER TABLE [dbo].[Documento]
ADD CONSTRAINT [PK_Documento]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ProjetoSet'
ALTER TABLE [dbo].[ProjetoSet]
ADD CONSTRAINT [PK_ProjetoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TipoProjeto'
ALTER TABLE [dbo].[TipoProjeto]
ADD CONSTRAINT [PK_TipoProjeto]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [ProjetoId], [FuncionarioNumero] in table 'ProjetoAtribuicao'
ALTER TABLE [dbo].[ProjetoAtribuicao]
ADD CONSTRAINT [PK_ProjetoAtribuicao]
    PRIMARY KEY CLUSTERED ([ProjetoId], [FuncionarioNumero] ASC);
GO

-- Creating primary key on [Numero] in table 'Funcionario'
ALTER TABLE [dbo].[Funcionario]
ADD CONSTRAINT [PK_Funcionario]
    PRIMARY KEY CLUSTERED ([Numero] ASC);
GO

-- Creating primary key on [Numero] in table 'ParecerSet'
ALTER TABLE [dbo].[ParecerSet]
ADD CONSTRAINT [PK_ParecerSet]
    PRIMARY KEY CLUSTERED ([Numero] ASC);
GO

-- Creating primary key on [TipoProjetoId], [FuncionarioNumero] in table 'EspecialistaSet'
ALTER TABLE [dbo].[EspecialistaSet]
ADD CONSTRAINT [PK_EspecialistaSet]
    PRIMARY KEY CLUSTERED ([TipoProjetoId], [FuncionarioNumero] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [PromotorNIF] in table 'Processo'
ALTER TABLE [dbo].[Processo]
ADD CONSTRAINT [FK_PromotorProcesso]
    FOREIGN KEY ([PromotorNIF])
    REFERENCES [dbo].[Promotor]
        ([NIF])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PromotorProcesso'
CREATE INDEX [IX_FK_PromotorProcesso]
ON [dbo].[Processo]
    ([PromotorNIF]);
GO

-- Creating foreign key on [EstadoProcessoId] in table 'Processo'
ALTER TABLE [dbo].[Processo]
ADD CONSTRAINT [FK_EstadoProcessoProcesso]
    FOREIGN KEY ([EstadoProcessoId])
    REFERENCES [dbo].[EstadoProcesso]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EstadoProcessoProcesso'
CREATE INDEX [IX_FK_EstadoProcessoProcesso]
ON [dbo].[Processo]
    ([EstadoProcessoId]);
GO

-- Creating foreign key on [TipoDocumentoId] in table 'Documento'
ALTER TABLE [dbo].[Documento]
ADD CONSTRAINT [FK_TipoDocumentoDocumento]
    FOREIGN KEY ([TipoDocumentoId])
    REFERENCES [dbo].[TipoDocumento]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TipoDocumentoDocumento'
CREATE INDEX [IX_FK_TipoDocumentoDocumento]
ON [dbo].[Documento]
    ([TipoDocumentoId]);
GO

-- Creating foreign key on [ProcessoId] in table 'ProjetoSet'
ALTER TABLE [dbo].[ProjetoSet]
ADD CONSTRAINT [FK_ProcessoProjeto]
    FOREIGN KEY ([ProcessoId])
    REFERENCES [dbo].[Processo]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProcessoProjeto'
CREATE INDEX [IX_FK_ProcessoProjeto]
ON [dbo].[ProjetoSet]
    ([ProcessoId]);
GO

-- Creating foreign key on [ProjetoId] in table 'Documento'
ALTER TABLE [dbo].[Documento]
ADD CONSTRAINT [FK_ProjetoDocumento]
    FOREIGN KEY ([ProjetoId])
    REFERENCES [dbo].[ProjetoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjetoDocumento'
CREATE INDEX [IX_FK_ProjetoDocumento]
ON [dbo].[Documento]
    ([ProjetoId]);
GO

-- Creating foreign key on [TipoProcessoAscendenteId] in table 'TipoProjeto'
ALTER TABLE [dbo].[TipoProjeto]
ADD CONSTRAINT [FK_TipoProcessoTipoProcesso]
    FOREIGN KEY ([TipoProcessoAscendenteId])
    REFERENCES [dbo].[TipoProjeto]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TipoProcessoTipoProcesso'
CREATE INDEX [IX_FK_TipoProcessoTipoProcesso]
ON [dbo].[TipoProjeto]
    ([TipoProcessoAscendenteId]);
GO

-- Creating foreign key on [TipoProjetoId] in table 'ProjetoSet'
ALTER TABLE [dbo].[ProjetoSet]
ADD CONSTRAINT [FK_TipoProjetoProjeto]
    FOREIGN KEY ([TipoProjetoId])
    REFERENCES [dbo].[TipoProjeto]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TipoProjetoProjeto'
CREATE INDEX [IX_FK_TipoProjetoProjeto]
ON [dbo].[ProjetoSet]
    ([TipoProjetoId]);
GO

-- Creating foreign key on [TipoProjetoId] in table 'EspecialistaSet'
ALTER TABLE [dbo].[EspecialistaSet]
ADD CONSTRAINT [FK_TipoProjetoEspecialista]
    FOREIGN KEY ([TipoProjetoId])
    REFERENCES [dbo].[TipoProjeto]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [FuncionarioNumero] in table 'ParecerSet'
ALTER TABLE [dbo].[ParecerSet]
ADD CONSTRAINT [FK_ParecerFuncionario]
    FOREIGN KEY ([FuncionarioNumero])
    REFERENCES [dbo].[Funcionario]
        ([Numero])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ParecerFuncionario'
CREATE INDEX [IX_FK_ParecerFuncionario]
ON [dbo].[ParecerSet]
    ([FuncionarioNumero]);
GO

-- Creating foreign key on [ProjetoId] in table 'ParecerSet'
ALTER TABLE [dbo].[ParecerSet]
ADD CONSTRAINT [FK_ProjetoParecer]
    FOREIGN KEY ([ProjetoId])
    REFERENCES [dbo].[ProjetoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjetoParecer'
CREATE INDEX [IX_FK_ProjetoParecer]
ON [dbo].[ParecerSet]
    ([ProjetoId]);
GO

-- Creating foreign key on [ParecerNumero] in table 'Documento'
ALTER TABLE [dbo].[Documento]
ADD CONSTRAINT [FK_ParecerDocumento]
    FOREIGN KEY ([ParecerNumero])
    REFERENCES [dbo].[ParecerSet]
        ([Numero])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ParecerDocumento'
CREATE INDEX [IX_FK_ParecerDocumento]
ON [dbo].[Documento]
    ([ParecerNumero]);
GO

-- Creating foreign key on [FuncionarioNumero] in table 'ProjetoAtribuicao'
ALTER TABLE [dbo].[ProjetoAtribuicao]
ADD CONSTRAINT [FK_ProjetoAtribuicaoFuncionario]
    FOREIGN KEY ([FuncionarioNumero])
    REFERENCES [dbo].[Funcionario]
        ([Numero])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjetoAtribuicaoFuncionario'
CREATE INDEX [IX_FK_ProjetoAtribuicaoFuncionario]
ON [dbo].[ProjetoAtribuicao]
    ([FuncionarioNumero]);
GO

-- Creating foreign key on [ProjetoId] in table 'ProjetoAtribuicao'
ALTER TABLE [dbo].[ProjetoAtribuicao]
ADD CONSTRAINT [FK_ProjetoProjetoAtribuicao]
    FOREIGN KEY ([ProjetoId])
    REFERENCES [dbo].[ProjetoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [FuncionarioNumero] in table 'EspecialistaSet'
ALTER TABLE [dbo].[EspecialistaSet]
ADD CONSTRAINT [FK_EspecialistaFuncionario]
    FOREIGN KEY ([FuncionarioNumero])
    REFERENCES [dbo].[Funcionario]
        ([Numero])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EspecialistaFuncionario'
CREATE INDEX [IX_FK_EspecialistaFuncionario]
ON [dbo].[EspecialistaSet]
    ([FuncionarioNumero]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------