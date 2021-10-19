USE [comida]

CREATE TABLE [dbo].[productos] (
    [id]        INT             IDENTITY (1, 1) NOT NULL,
    [nombre]    TEXT            NOT NULL,
    [precio]    FLOAT (53)      NOT NULL,
    [imagen]    VARBINARY (MAX) NULL,
    [categoria] TEXT            NOT NULL
);

CREATE TABLE [dbo].[ventas] (
    [id]    INT        IDENTITY (1, 1) NOT NULL,
    [total] FLOAT (53) NULL,
    [fecha] DATE       NULL
);

CREATE TABLE [dbo].[ventas_prod] (
    [id]       INT        IDENTITY (1, 1) NOT NULL,
    [nombre]   TEXT       NULL,
    [precio]   FLOAT (53) NULL,
    [id_venta] INT        NOT NULL
);




