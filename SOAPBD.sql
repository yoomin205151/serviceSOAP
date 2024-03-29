USE [SOAPBD]
GO
/****** Object:  Table [dbo].[product]    Script Date: 2024-01-17 오전 8:00:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[product](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[detail] [varchar](100) NOT NULL,
	[quantity] [int] NOT NULL,
	[price] [decimal](18, 2) NULL,
	[dates] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[product] ON 

INSERT [dbo].[product] ([id], [detail], [quantity], [price], [dates]) VALUES (2, N'dsadsadsa', 200, CAST(200.00 AS Decimal(18, 2)), CAST(N'2024-01-16' AS Date))
INSERT [dbo].[product] ([id], [detail], [quantity], [price], [dates]) VALUES (3, N'22222222', 2222, CAST(28.25 AS Decimal(18, 2)), CAST(N'2024-01-02' AS Date))
SET IDENTITY_INSERT [dbo].[product] OFF
GO
/****** Object:  StoredProcedure [dbo].[SP_ACTUALIZARPRODUCTO]    Script Date: 2024-01-17 오전 8:00:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ACTUALIZARPRODUCTO]
	@id int,
	@detail varchar(100),
	@quantity int,
	@price decimal(18,2),
	@dates date
AS
BEGIN
	UPDATE product SET detail = @detail, quantity = @quantity, price = @price, dates = @dates
	WHERE id = @id;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_BUSCARPRODUCTO]    Script Date: 2024-01-17 오전 8:00:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_BUSCARPRODUCTO]
	@letra varchar(50)
AS
BEGIN
	SELECT * FROM product WHERE detail LIKE '%' + @letra + '%'
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_ELIMINARPRODUCTO]    Script Date: 2024-01-17 오전 8:00:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ELIMINARPRODUCTO]
	@id int
AS
BEGIN
	DELETE FROM product WHERE id = @id;
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_INSETARPRODUCTO]    Script Date: 2024-01-17 오전 8:00:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_INSETARPRODUCTO]
	@detail varchar(100),
	@quantity int,
	@price decimal(18,2),
	@dates date
AS
BEGIN
	INSERT INTO product (detail,quantity,price,dates)
	VALUES (@detail, @quantity, @price, @dates);
END;
GO
/****** Object:  StoredProcedure [dbo].[SP_LISTARPRODUCTO]    Script Date: 2024-01-17 오전 8:00:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_LISTARPRODUCTO]
as
begin
	select * from product
end;
GO
