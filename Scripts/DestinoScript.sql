IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Destinos] (
    [Id_Destino] int NOT NULL IDENTITY,
    [NomeDestino] nvarchar(max) NOT NULL,
    [DataIda] datetime2 NOT NULL,
    [DataVolta] datetime2 NOT NULL,
    CONSTRAINT [PK_Destinos] PRIMARY KEY ([Id_Destino])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211213052315_Inicial', N'5.0.12');
GO

COMMIT;
GO

