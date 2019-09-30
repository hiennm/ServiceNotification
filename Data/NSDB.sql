CREATE TABLE [dbo].[Service] (
    [ServiceId]        INT            IDENTITY (1, 1) NOT NULL,
    [ServiceName]      NVARCHAR (250) NOT NULL,
    [Description]      NTEXT          NULL,
    [ExpirationNotice] BIT            NULL,
    [Enabled]          BIT            NULL,
    PRIMARY KEY CLUSTERED ([ServiceId] ASC)
);

GO;

CREATE TABLE [dbo].[ServiceDetail] (
    [DetailId]         INT           IDENTITY (1, 1) NOT NULL,
    [ServiceId]        INT           NOT NULL,
    [ServiceUser]      VARCHAR (50)  NOT NULL,
    [ServiceUserEmail] VARCHAR (100) NULL,
    [ExpiredDate]      DATETIME      NULL,
    [ExpirationNotice] BIT           NULL,
    [RequestId]        INT           NULL,
    PRIMARY KEY CLUSTERED ([DetailId] ASC),
    FOREIGN KEY ([ServiceId]) REFERENCES [dbo].[Service] ([ServiceId])
);

GO;

CREATE TABLE [dbo].[Request] (
    [RequestId]        INT            IDENTITY (1, 1) NOT NULL,
    [ServiceId]        INT            NOT NULL,
    [ServiceUser]      VARCHAR (50)   NOT NULL,
    [ServiceUserEmail] VARCHAR (100)  NOT NULL,
    [RequestContent]   NVARCHAR (255) NULL,
    [ExpirationNotice] BIT            NULL,
    [ExpiredDate]      DATETIME       NULL,
    [RequestUser]      VARCHAR (50)   NULL,
    [RequestDate]      DATETIME       NULL,
    [ProcessUser]      VARCHAR (50)   NULL,
    [ProcessDate]      DATETIME       NULL,
    [Status]           INT            NULL,
    PRIMARY KEY CLUSTERED ([RequestId] ASC),
    FOREIGN KEY ([ServiceId]) REFERENCES [dbo].[Service] ([ServiceId])
);

GO;


CREATE TABLE [dbo].[User] (
    [UserId]      INT            IDENTITY (1, 1) NOT NULL,
    [UserAccount] VARCHAR (50)   NOT NULL,
    [UserName]    NVARCHAR (100) NULL,
    [Email]       VARCHAR (100)  NULL,
    [LastLogin]   DATETIME       NULL,
    [Enabled]     BIT            NULL,
    PRIMARY KEY CLUSTERED ([UserId] ASC)
);

GO;

CREATE TABLE [dbo].[Role] (
    [RoleId]   INT           IDENTITY (1, 1) NOT NULL,
    [RoleName] VARCHAR (100) NOT NULL,
    [Enabled]  BIT           NULL,
    PRIMARY KEY CLUSTERED ([RoleId] ASC)
);

GO;

CREATE TABLE [dbo].[UserRole] (
    [UserRoleId] INT IDENTITY (1, 1) NOT NULL,
    [UserId]     INT NOT NULL,
    [RoleId]     INT NOT NULL,
    PRIMARY KEY CLUSTERED ([UserRoleId] ASC),
    FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([UserId]),
    FOREIGN KEY ([RoleId]) REFERENCES [dbo].[Role] ([RoleId])
);

