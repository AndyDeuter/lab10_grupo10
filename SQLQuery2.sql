CREATE DATABASE EcommerceDB;

USE EcommerceDB;

CREATE TABLE Categor�as (
    CategoriaID INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100) NOT NULL
);

CREATE TABLE Productos (
    ProductoID INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100) NOT NULL,
    Descripci�n VARCHAR(255),
    Precio DECIMAL(10,2) NOT NULL,
    CantidadEnStock INT NOT NULL,
    CategoriaID INT FOREIGN KEY REFERENCES Categor�as(CategoriaID)
);

CREATE TABLE Pedidos (
    PedidoID INT PRIMARY KEY IDENTITY(1,1),
    FechaPedido DATETIME NOT NULL,
    ProductoID INT FOREIGN KEY REFERENCES Productos(ProductoID),
    Cantidad INT NOT NULL
);