CREATE TABLE [dbo].[tb_Veiculos] (
    [Id]          INT             IDENTITY (1, 1) NOT NULL,
    [Nome]        VARCHAR (60)    NOT NULL,
    [Modelo]      VARCHAR (50)    NOT NULL,
    [Ano]         SMALLINT        NOT NULL,
    [Fabricacao]  SMALLINT        NOT NULL,
    [Cor]         VARCHAR (10)    NOT NULL,
    [Combustivel] TINYINT         NOT NULL,
    [Automatico]  BIT             NOT NULL,
    [Valor]       DECIMAL (18, 2) NOT NULL,
    [Ativo]       BIT             NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

GO
CREATE TABLE [dbo].[Usuarios] (
    [Id]    INT          IDENTITY (1, 1) NOT NULL,
    [Email] VARCHAR (50) NULL,
    [Nome]  VARCHAR (50) NULL,
    [Senha] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'1=gasolina 2=álcoll 3=flex 4=diesel 5=gas natural', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'tb_Veiculos', @level2type = N'COLUMN', @level2name = N'Combustivel';

GO
