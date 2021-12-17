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

CREATE TABLE [Clientes] (
    [Id_Cliente] int NOT NULL IDENTITY,
    [Nome] nvarchar(30) NULL,
    [Cpf] nvarchar(11) NULL,
    [DataNascimento] datetime2 NOT NULL,
    [Endereco] nvarchar(60) NULL,
    CONSTRAINT [PK_Clientes] PRIMARY KEY ([Id_Cliente])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211216011626_Inicial', N'5.0.12');
GO

COMMIT;
GO

