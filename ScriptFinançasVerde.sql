CREATE DATABASE Finan�asVerde; 
 GO
 use Finan�asVerde
 GO
 CREATE TABLE Usuario (
     ID varchar(255) PRIMARY KEY,
     Nome varchar(255),
	 Logim varchar(255),
	 Telefone varchar(255),
	 Senha varchar(255),
	 Saldo money,
	 );
GO
