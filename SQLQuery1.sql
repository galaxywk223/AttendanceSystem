USE master
GO

-- ！！！注意：这一步会删除现有的 AttendanceDB 数据库及其所有数据！！！
-- 如果存在旧数据库，先删除，保证环境是新的
IF EXISTS (SELECT name FROM sys.databases WHERE name = 'AttendanceDB')
BEGIN
    -- 把其他人踢下线，防止删除失败
    ALTER DATABASE AttendanceDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE
    DROP DATABASE AttendanceDB
END
GO

-- 重新创建数据库
CREATE DATABASE AttendanceDB
GO

USE AttendanceDB
GO

-- 1. 班级表
CREATE TABLE [dbo].[StudentClass](
    [ClassId] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [ClassName] [varchar](50) NOT NULL
)
GO

-- 2. 学员表
CREATE TABLE [dbo].[Student](
    [StudentId] [int] IDENTITY(10000,1) NOT NULL PRIMARY KEY,
    [StudentName] [varchar](20) NOT NULL,
    [Gender] [char](2) NOT NULL,
    [Birthday] [date] NOT NULL,
    [StudentIdNo] [varchar](18) NOT NULL UNIQUE,
    [CardNo] [varchar](50) NOT NULL UNIQUE,
    [PhoneNumber] [varchar](20) NULL,
    [StudentAddress] [varchar](200) NULL,
    [ClassId] [int] NOT NULL FOREIGN KEY REFERENCES [dbo].[StudentClass]([ClassId]),
    [StudentImage] [varchar](200) NULL,
    [Age] [int] NULL
)
GO

-- 3. 管理员表
CREATE TABLE [dbo].[SysAdmin](
    [LoginId] [int] NOT NULL PRIMARY KEY,
    [LoginPwd] [varchar](20) NOT NULL, -- 确保存储列名是 LoginPwd
    [AdminName] [varchar](20) NOT NULL
)
GO

-- 4. 成绩表
CREATE TABLE [dbo].[Score](
    [ScoreId] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [StudentId] [int] NOT NULL FOREIGN KEY REFERENCES [dbo].[Student]([StudentId]),
    [CSharp] [int] NULL,
    [SQLServerDB] [int] NULL
)
GO

-- 5. 插入默认管理员
-- 因为上面是全新创建的表，这里一定能成功
INSERT INTO SysAdmin (LoginId, LoginPwd, AdminName) VALUES (1001, 'admin123', 'Admin')
GO

-- 查询一下看看结果
SELECT * FROM SysAdmin
GO