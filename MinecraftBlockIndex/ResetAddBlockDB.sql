DROP DATABASE IF EXISTS MinecraftBlockIndex
GO

CREATE DATABASE MinecraftBlockIndex
GO

USE MinecraftBlockIndex
GO

-- Create Customers table
CREATE TABLE AddBlock (
    BlockID INT PRIMARY KEY IDENTITY(1,1),
    BlockName varchar(100) NOT NULL,
    IsBurnable bit NOT NULL,
    IsTransparent bit NOT NULL,
    IsFull bit NOT NULL,
    EmitsLight bit NOT NULL
    --DateAdded DATE NOT NULL
);



-- Insert sample Blocks
INSERT INTO AddBlock (BlockName, IsBurnable, IsTransparent, IsFull, EmitsLight) VALUES
('Grass Block', 1, 0, 1, 0),
('Cobblestone Block', 0, 0, 1, 0),
('Wood Block', 1, 0, 1, 0),
('Dirt Block', 1, 0, 1, 0);
