# CustomerManagerSystem

1- Run below the code from SQLSERVER

CREATE TABLE [dbo].[Customer]( [Id] [int] IDENTITY(1,1) NOT NULL, [Name] nvarchar NOT NULL, [Email] nvarchar NOT NULL, [PhoneNumber] nvarchar NOT NULL, [Adress] nvarchar NOT NULL, [Gender] nvarchar NOT NULL, [NationalNumber] nvarchar NOT NULL,

CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED ( [Id] ASC )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY] ) ON [PRIMARY] GO

CREATE TABLE [dbo].[Company]( [Id] [int] IDENTITY(1,1) NOT NULL, [Name] nvarchar NOT NULL, CONSTRAINT [PK_Company] PRIMARY KEY CLUSTERED ( [Id] ASC )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY] ) ON [PRIMARY] GO

2-Add connectionString to appSettings.json 

3-Run the project
