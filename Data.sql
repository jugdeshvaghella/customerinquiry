USE [CustomerInquiry]
GO
INSERT [dbo].[customer] ([id], [name], [email], [mobile]) VALUES (CAST(331822 AS Numeric(10, 0)), N'Heather Gordon

', N'h.gordon@example.com

', N'8055801779')
GO
INSERT [dbo].[customer] ([id], [name], [email], [mobile]) VALUES (CAST(435622 AS Numeric(10, 0)), N'Meghan Martinez', N'm.martinez16@example.com', N'8129331382')
GO
INSERT [dbo].[customer] ([id], [name], [email], [mobile]) VALUES (CAST(644122 AS Numeric(10, 0)), N'Aubree Hall', N'aubree.hall53@example.com', N'6005958940')
GO
SET IDENTITY_INSERT [dbo].[transaction] ON 
GO
INSERT [dbo].[transaction] ([id], [customerid], [date], [amount], [currencycode], [status]) VALUES (CAST(1 AS Numeric(18, 0)), CAST(331822 AS Numeric(10, 0)), CAST(N'2018-01-31T21:34:00.000' AS DateTime), CAST(0.34 AS Decimal(18, 2)), N'USD', 1)
GO
INSERT [dbo].[transaction] ([id], [customerid], [date], [amount], [currencycode], [status]) VALUES (CAST(2 AS Numeric(18, 0)), CAST(435622 AS Numeric(10, 0)), CAST(N'2018-01-11T08:34:00.000' AS DateTime), CAST(0.56 AS Decimal(18, 2)), N'TBH', 0)
GO
INSERT [dbo].[transaction] ([id], [customerid], [date], [amount], [currencycode], [status]) VALUES (CAST(3 AS Numeric(18, 0)), CAST(435622 AS Numeric(10, 0)), CAST(N'2018-01-31T21:34:00.000' AS DateTime), CAST(0.83 AS Decimal(18, 2)), N'USD', 2)
GO
SET IDENTITY_INSERT [dbo].[transaction] OFF
GO
