USE [master]
GO
/****** Object:  Database [LTHSK-BTL-QuanLyQuanCafe]    Script Date: 04/20/2020 20:40:09 ******/
CREATE DATABASE [LTHSK-BTL-QuanLyQuanCafe]
GO
USE [LTHSK-BTL-QuanLyQuanCafe]
GO
/****** Object:  Table [dbo].[tblBan]    Script Date: 04/20/2020 20:40:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBan](
	[iId] [int] IDENTITY(1,1) NOT NULL,
	[sName] [nvarchar](10) NULL,
	[sStatus] [nvarchar](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[iId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLoaidouong]    Script Date: 04/20/2020 20:40:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLoaidouong](
	[iId] [int] IDENTITY(1,1) NOT NULL,
	[sName] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[iId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblUser]    Script Date: 04/20/2020 20:40:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUser](
	[iId] [int] IDENTITY(1,1) NOT NULL,
	[sHoten] [nvarchar](30) NULL,
	[sGioitinh] [nvarchar](3) NULL,
	[iType_user] [int] NULL,
	[iSdt] [nvarchar](15) NULL,
	[dNgaysinh] [date] NULL,
	[iCMND] [nvarchar](15) NULL,
	[sUsername] [nvarchar](50) NULL,
	[sPassword] [nvarchar](50) NULL,
	[sDiaChi] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[iId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblMenu]    Script Date: 04/20/2020 20:40:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblMenu](
	[iId] [int] IDENTITY(1,1) NOT NULL,
	[sTendouong] [nvarchar](30) NULL,
	[sLoaidouong] [int] NULL,
	[fDongia] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[iId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblHoadon]    Script Date: 04/20/2020 20:40:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHoadon](
	[iId] [int] IDENTITY(1,1) NOT NULL,
	[sMaban] [int] NULL,
	[sMaNV] [int] NULL,
	[dThoigianthanhtoan] [date] NULL,
	[sTrangthai] [nvarchar](10) NULL,
	[fToongtien] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[iId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblChitietHD]    Script Date: 04/20/2020 20:40:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChitietHD](
	[iId] [int] IDENTITY(1,1) NOT NULL,
	[sMaHD] [int] NULL,
	[sMadouong] [int] NULL,
	[iSoluong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[iId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[viewtblBill]    Script Date: 04/20/2020 20:40:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[viewtblBill] as
select tblHoadon.iId, tblBan.sName, tblUser.sHoten, tblHoadon.dThoigianthanhtoan, tblHoadon.sTrangthai,tblHoadon.fToongtien 
from tblBan,tblUser,tblHoadon 
where tblBan.iId = tblHoadon.sMaban and tblHoadon.sMaNV = tblUser.iId
GO
/****** Object:  View [dbo].[viewRepostBill]    Script Date: 04/20/2020 20:40:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[viewRepostBill] as
select tblChitietHD.iId As [id] , tblBan.sName,tblUser.sHoten,tblHoadon.dThoigianthanhtoan,tblMenu.sTendouong,tblMenu.fDongia,tblChitietHD.iSoluong,tblHoadon.iId as [bill_id],tblHoadon.fToongtien
 from tblBan,tblUser,tblHoadon,tblChitietHD,tblMenu
where tblBan.iId = tblHoadon.sMaban and tblHoadon.sMaNV = tblUser.iId and tblChitietHD.sMaHD = tblHoadon.iId and tblChitietHD.sMadouong = tblMenu.iId
GO
/****** Object:  View [dbo].[viewBill_Infor]    Script Date: 04/20/2020 20:40:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[viewBill_Infor]
AS
select tblChitietHD.iId,tblMenu.sTendouong,tblChitietHD.iSoluong,tblMenu.fDongia,tblChitietHD.sMaHD
from tblChitietHD inner join tblMenu
on tblChitietHD.sMadouong = tblMenu.iId
GO
/****** Object:  ForeignKey [FK_loaidouong]    Script Date: 04/20/2020 20:40:10 ******/
ALTER TABLE [dbo].[tblMenu]  WITH CHECK ADD  CONSTRAINT [FK_loaidouong] FOREIGN KEY([sLoaidouong])
REFERENCES [dbo].[tblLoaidouong] ([iId])
GO
ALTER TABLE [dbo].[tblMenu] CHECK CONSTRAINT [FK_loaidouong]
GO
/****** Object:  ForeignKey [FK_maban]    Script Date: 04/20/2020 20:40:10 ******/
ALTER TABLE [dbo].[tblHoadon]  WITH CHECK ADD  CONSTRAINT [FK_maban] FOREIGN KEY([sMaban])
REFERENCES [dbo].[tblBan] ([iId])
GO
ALTER TABLE [dbo].[tblHoadon] CHECK CONSTRAINT [FK_maban]
GO
/****** Object:  ForeignKey [FK_manv]    Script Date: 04/20/2020 20:40:10 ******/
ALTER TABLE [dbo].[tblHoadon]  WITH CHECK ADD  CONSTRAINT [FK_manv] FOREIGN KEY([sMaNV])
REFERENCES [dbo].[tblUser] ([iId])
GO
ALTER TABLE [dbo].[tblHoadon] CHECK CONSTRAINT [FK_manv]
GO
/****** Object:  ForeignKey [FK_madouong]    Script Date: 04/20/2020 20:40:10 ******/
ALTER TABLE [dbo].[tblChitietHD]  WITH CHECK ADD  CONSTRAINT [FK_madouong] FOREIGN KEY([sMadouong])
REFERENCES [dbo].[tblMenu] ([iId])
GO
ALTER TABLE [dbo].[tblChitietHD] CHECK CONSTRAINT [FK_madouong]
GO
/****** Object:  ForeignKey [FK_mahd]    Script Date: 04/20/2020 20:40:10 ******/
ALTER TABLE [dbo].[tblChitietHD]  WITH CHECK ADD  CONSTRAINT [FK_mahd] FOREIGN KEY([sMaHD])
REFERENCES [dbo].[tblHoadon] ([iId])
GO
ALTER TABLE [dbo].[tblChitietHD] CHECK CONSTRAINT [FK_mahd]
GO

use [LTHSK-BTL-QuanLyQuanCafe]

insert into tblUser(sHoten,sGioitinh,iType_user,iSdt,dNgaysinh,iCMND,sUsername,sPassword,sDiaChi)
values (N'Ph?m V?n H?i',N'Nam',1,0354326853,'06/01/1999',145871169,N'admin',N'123456',N'H?ng Yên');

Select * from tblUser

update tblUser set sPassword = '12345' where iId =1

insert into tblLoaidouong (sName) values (N'Cà Phê');
insert into tblLoaidouong (sName) values (N'Siro ?á bào');
insert into tblLoaidouong (sName) values (N'Yougurd ?á bào');
insert into tblLoaidouong (sName) values (N'Gi?i khát');

insert into tblLoaidouong (sName) values (N'Trà s?a');

delete from tblLoaidouong where iId = 5

select * from tblMenu
select * from tblBan

insert into tblMenu (sTendouong,sLoaidouong,fDongia) values(N'Cà phê ?á',3,10000),
															(N'Cà phê s?a ?á',3,15000),
															(N'B?c xíu ?á',3,15000),
															(N'Nho',1,10000),
															(N'?ào',1,10000),
															(N'Cam',1,10000),
															(N'7 Up',7,15000),
															(N'Coca',7,15000),
select iId from tblHoadon where sMaban = 1 and  like '0'
select * from tblHoadon
select * from tblChitietHD
select * from tblBan
insert into tblHoadon (sMaNV, sMaban,dThoigianthanhtoan,sTrangthai,fToongtien) values(,15,GETDATE(),0,0)
select * from viewtblBill where dThoigianthanhtoan between '2020/06/1' and '2020/06/2'


ALTER TABLE tblHoadon
ALTER COLUMN  dThoigianthanhtoan date;

delete from tblBan where iId = 22


ALter PROCEDURE removeTable
@table_id int
AS 
BEGIN 
delete from tblChitietHD where sMaHD = (select iId from tblHoadon where sMaban = @table_id)
delete from tblHoadon where sMaban = @table_id
delete from tblBan where iId = @table_id
END 

exec removeTable 19

select * from dbo.viewRepostBill where bill_id = 4

select * from tblUser where DATEDIFF(year,dNgaysinh,GETDATE())> 10

