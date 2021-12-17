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

CREATE TABLE [Promocaos] (
    [Id_Promo] int NOT NULL IDENTITY,
    [Destino_Promo] nvarchar(max) NOT NULL,
    [Valor_promo] real NOT NULL,
    [Qntd_Dias] int NOT NULL,
    CONSTRAINT [PK_Promocaos] PRIMARY KEY ([Id_Promo])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211213060123_InitialCreate', N'5.0.12');
GO

COMMIT;
GO

