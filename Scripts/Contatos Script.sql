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

CREATE TABLE [Contatos] (
    [Id_Contato] int NOT NULL IDENTITY,
    [Celular] nvarchar(max) NULL,
    [Email] nvarchar(max) NULL,
    [Github] nvarchar(max) NULL,
    CONSTRAINT [PK_Contatos] PRIMARY KEY ([Id_Contato])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211213062412_InitialCreate', N'5.0.12');
GO

COMMIT;
GO

