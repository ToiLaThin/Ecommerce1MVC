IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221212032331_InitProductCategoryInDb')
BEGIN
    CREATE TABLE [Category] (
        [categoryId] int NOT NULL IDENTITY,
        [categoryName] nvarchar(max) NOT NULL,
        [categoryImage] nvarchar(max) NULL,
        [categoryStatus] int NOT NULL DEFAULT 0,
        CONSTRAINT [PK_Category] PRIMARY KEY ([categoryId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221212032331_InitProductCategoryInDb')
BEGIN
    CREATE TABLE [Product] (
        [productId] int NOT NULL IDENTITY,
        [productName] nvarchar(max) NOT NULL,
        [productCode] nvarchar(max) NULL,
        [id_Product_Category] int NULL,
        [productDescription] nvarchar(max) NOT NULL,
        [productPrice] decimal(18, 6) NOT NULL,
        [productImage] nvarchar(max) NULL,
        [productStatus] int NOT NULL DEFAULT 0,
        [productModifiedDate] datetime2 NOT NULL DEFAULT '2022-12-23T00:33:04.4711675+07:00',
        [productRevenue] int NOT NULL DEFAULT 0,
        CONSTRAINT [PK_Product] PRIMARY KEY ([productId]),
        CONSTRAINT [FK_Product_Category_id_Product_Category] FOREIGN KEY ([id_Product_Category]) REFERENCES [Category] ([categoryId]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221212032331_InitProductCategoryInDb')
BEGIN
    CREATE INDEX [IX_Product_id_Product_Category] ON [Product] ([id_Product_Category]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221212032331_InitProductCategoryInDb')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20221212032331_InitProductCategoryInDb', N'3.1.31');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221212093818_AddRoleAccountToDb')
BEGIN
    CREATE TABLE [Role] (
        [roleId] int NOT NULL IDENTITY,
        [roleName] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Role] PRIMARY KEY ([roleId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221212093818_AddRoleAccountToDb')
BEGIN
    CREATE TABLE [Account] (
        [accountId] int NOT NULL IDENTITY,
        [accountUserName] nvarchar(450) NOT NULL,
        [accountEmail] nvarchar(max) NULL,
        [accountFullName] nvarchar(max) NULL,
        [accountPassword] nvarchar(max) NOT NULL,
        [accountImage] nvarchar(max) NULL,
        [accountPhone] nvarchar(max) NULL,
        [accountStatus] int NOT NULL DEFAULT 0,
        [accountCode] nvarchar(max) NULL,
        [id_Account_Role] int NOT NULL,
        CONSTRAINT [PK_Account] PRIMARY KEY ([accountId]),
        CONSTRAINT [UNIQUE_accountUserName] UNIQUE ([accountUserName]),
        CONSTRAINT [FK_Account_Role_id_Account_Role] FOREIGN KEY ([id_Account_Role]) REFERENCES [Role] ([roleId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221212093818_AddRoleAccountToDb')
BEGIN
    CREATE INDEX [IX_Account_id_Account_Role] ON [Account] ([id_Account_Role]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221212093818_AddRoleAccountToDb')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20221212093818_AddRoleAccountToDb', N'3.1.31');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221213052924_AddWishListReviewToDb')
BEGIN
    CREATE TABLE [Review] (
        [reviewId] int NOT NULL IDENTITY,
        [reviewContent] nvarchar(max) NOT NULL,
        [reviewDateCreated] datetime2 NOT NULL DEFAULT '2022-12-23T00:33:04.4866386+07:00',
        [id_Review_Account] int NOT NULL,
        [id_Review_Product] int NOT NULL,
        CONSTRAINT [PK_Review] PRIMARY KEY ([reviewId]),
        CONSTRAINT [FK_Review_Account_id_Review_Account] FOREIGN KEY ([id_Review_Account]) REFERENCES [Account] ([accountId]) ON DELETE CASCADE,
        CONSTRAINT [FK_Review_Product_id_Review_Product] FOREIGN KEY ([id_Review_Product]) REFERENCES [Product] ([productId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221213052924_AddWishListReviewToDb')
BEGIN
    CREATE TABLE [WishList] (
        [id_WishList_Account] int NOT NULL,
        [id_WishList_Product] int NOT NULL,
        CONSTRAINT [PK_WishList] PRIMARY KEY ([id_WishList_Account], [id_WishList_Product]),
        CONSTRAINT [FK_WishList_Account_id_WishList_Account] FOREIGN KEY ([id_WishList_Account]) REFERENCES [Account] ([accountId]) ON DELETE CASCADE,
        CONSTRAINT [FK_WishList_Product_id_WishList_Product] FOREIGN KEY ([id_WishList_Product]) REFERENCES [Product] ([productId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221213052924_AddWishListReviewToDb')
BEGIN
    CREATE INDEX [IX_Review_id_Review_Account] ON [Review] ([id_Review_Account]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221213052924_AddWishListReviewToDb')
BEGIN
    CREATE INDEX [IX_Review_id_Review_Product] ON [Review] ([id_Review_Product]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221213052924_AddWishListReviewToDb')
BEGIN
    CREATE INDEX [IX_WishList_id_WishList_Product] ON [WishList] ([id_WishList_Product]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221213052924_AddWishListReviewToDb')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20221213052924_AddWishListReviewToDb', N'3.1.31');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221213153327_AddOrderOrderItemReceiptToDb')
BEGIN
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Product]') AND [c].[name] = N'productPrice');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Product] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [Product] ALTER COLUMN [productPrice] decimal(18, 2) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221213153327_AddOrderOrderItemReceiptToDb')
BEGIN
    CREATE TABLE [Order] (
        [orderId] int NOT NULL IDENTITY,
        [id_Order_Account] int NOT NULL,
        [orderBuyDate] datetime2 NOT NULL DEFAULT '2022-12-23T00:33:04.4908027+07:00',
        [orderStatus] int NOT NULL DEFAULT 0,
        [orderPhone] nvarchar(max) NOT NULL,
        [orderAddress] nvarchar(max) NOT NULL,
        [orderTotalPrice] decimal(18, 2) NOT NULL,
        CONSTRAINT [PK_Order] PRIMARY KEY ([orderId]),
        CONSTRAINT [FK_Order_Account_id_Order_Account] FOREIGN KEY ([id_Order_Account]) REFERENCES [Account] ([accountId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221213153327_AddOrderOrderItemReceiptToDb')
BEGIN
    CREATE TABLE [OrderItem] (
        [orderItemId] int NOT NULL IDENTITY,
        [id_OrderItem_Order] int NOT NULL,
        [id_OrderItem_Product] int NOT NULL,
        [orderItemQuantity] int NOT NULL,
        [orderItemUnitPrice] decimal(18, 2) NOT NULL,
        CONSTRAINT [PK_OrderItem] PRIMARY KEY ([orderItemId]),
        CONSTRAINT [FK_OrderItem_Order_id_OrderItem_Order] FOREIGN KEY ([id_OrderItem_Order]) REFERENCES [Order] ([orderId]) ON DELETE CASCADE,
        CONSTRAINT [FK_OrderItem_Product_id_OrderItem_Product] FOREIGN KEY ([id_OrderItem_Product]) REFERENCES [Product] ([productId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221213153327_AddOrderOrderItemReceiptToDb')
BEGIN
    CREATE TABLE [Receipt] (
        [receiptId] int NOT NULL IDENTITY,
        [id_Receipt_Order] int NOT NULL,
        [receiptReleaseDate] datetime2 NOT NULL DEFAULT '2022-12-23T00:33:04.4923331+07:00',
        CONSTRAINT [PK_Receipt] PRIMARY KEY ([receiptId]),
        CONSTRAINT [FK_Receipt_Order_id_Receipt_Order] FOREIGN KEY ([id_Receipt_Order]) REFERENCES [Order] ([orderId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221213153327_AddOrderOrderItemReceiptToDb')
BEGIN
    CREATE INDEX [IX_Order_id_Order_Account] ON [Order] ([id_Order_Account]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221213153327_AddOrderOrderItemReceiptToDb')
BEGIN
    CREATE INDEX [IX_OrderItem_id_OrderItem_Order] ON [OrderItem] ([id_OrderItem_Order]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221213153327_AddOrderOrderItemReceiptToDb')
BEGIN
    CREATE INDEX [IX_OrderItem_id_OrderItem_Product] ON [OrderItem] ([id_OrderItem_Product]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221213153327_AddOrderOrderItemReceiptToDb')
BEGIN
    CREATE INDEX [IX_Receipt_id_Receipt_Order] ON [Receipt] ([id_Receipt_Order]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221213153327_AddOrderOrderItemReceiptToDb')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20221213153327_AddOrderOrderItemReceiptToDb', N'3.1.31');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221213162916_AddSellerStoreInventoryToDb')
BEGIN
    CREATE TABLE [Store] (
        [storeId] int NOT NULL IDENTITY,
        [storeName] nvarchar(max) NOT NULL,
        [storeCreateDate] datetime2 NOT NULL DEFAULT '2022-12-23T00:33:04.5009364+07:00',
        CONSTRAINT [PK_Store] PRIMARY KEY ([storeId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221213162916_AddSellerStoreInventoryToDb')
BEGIN
    CREATE TABLE [Inventory] (
        [inventoryId] int NOT NULL IDENTITY,
        [id_Inventory_Store] int NOT NULL,
        [id_Inventory_Product] int NOT NULL,
        [inventoryProductAmount] int NOT NULL,
        CONSTRAINT [PK_Inventory] PRIMARY KEY ([inventoryId]),
        CONSTRAINT [FK_Inventory_Product_id_Inventory_Product] FOREIGN KEY ([id_Inventory_Product]) REFERENCES [Product] ([productId]) ON DELETE CASCADE,
        CONSTRAINT [FK_Inventory_Store_id_Inventory_Store] FOREIGN KEY ([id_Inventory_Store]) REFERENCES [Store] ([storeId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221213162916_AddSellerStoreInventoryToDb')
BEGIN
    CREATE TABLE [Seller] (
        [sellerId] int NOT NULL IDENTITY,
        [sellerName] nvarchar(max) NOT NULL,
        [sellerImage] nvarchar(max) NULL,
        [sellerStatus] int NOT NULL DEFAULT 1,
        [id_Seller_Store] int NOT NULL,
        CONSTRAINT [PK_Seller] PRIMARY KEY ([sellerId]),
        CONSTRAINT [FK_Seller_Store_id_Seller_Store] FOREIGN KEY ([id_Seller_Store]) REFERENCES [Store] ([storeId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221213162916_AddSellerStoreInventoryToDb')
BEGIN
    CREATE INDEX [IX_Inventory_id_Inventory_Product] ON [Inventory] ([id_Inventory_Product]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221213162916_AddSellerStoreInventoryToDb')
BEGIN
    CREATE INDEX [IX_Inventory_id_Inventory_Store] ON [Inventory] ([id_Inventory_Store]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221213162916_AddSellerStoreInventoryToDb')
BEGIN
    CREATE INDEX [IX_Seller_id_Seller_Store] ON [Seller] ([id_Seller_Store]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221213162916_AddSellerStoreInventoryToDb')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20221213162916_AddSellerStoreInventoryToDb', N'3.1.31');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221214061118_ModifyProductAccountRefToSeller')
BEGIN
    ALTER TABLE [Product] ADD [id_Product_Seller] int NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221214061118_ModifyProductAccountRefToSeller')
BEGIN
    ALTER TABLE [Account] ADD [id_Account_Seller] int NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221214061118_ModifyProductAccountRefToSeller')
BEGIN
    CREATE INDEX [IX_Product_id_Product_Seller] ON [Product] ([id_Product_Seller]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221214061118_ModifyProductAccountRefToSeller')
BEGIN
    CREATE INDEX [IX_Account_id_Account_Seller] ON [Account] ([id_Account_Seller]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221214061118_ModifyProductAccountRefToSeller')
BEGIN
    ALTER TABLE [Account] ADD CONSTRAINT [FK_Account_Seller_id_Account_Seller] FOREIGN KEY ([id_Account_Seller]) REFERENCES [Seller] ([sellerId]) ON DELETE SET NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221214061118_ModifyProductAccountRefToSeller')
BEGIN
    ALTER TABLE [Product] ADD CONSTRAINT [FK_Product_Seller_id_Product_Seller] FOREIGN KEY ([id_Product_Seller]) REFERENCES [Seller] ([sellerId]) ON DELETE SET NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221214061118_ModifyProductAccountRefToSeller')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20221214061118_ModifyProductAccountRefToSeller', N'3.1.31');
END;

GO

