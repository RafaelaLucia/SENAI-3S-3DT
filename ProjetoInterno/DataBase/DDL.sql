create database Classificados_Tarde
use Classificados_Tarde

Create table TipoUsuario(
idTipo smallint primary key identity,
tituloTipo varchar(50) unique not null
);
go

Create table Usuario(
idUsuario int primary key identity,
idTipo smallint foreign key references TipoUsuario (idTipo),
nomeUsuario varchar(100) not null,
email varchar(256) unique not null,
senha varchar(10) not null check( len(senha) >= 8),
);
go

Create table Situacao (
idSituacao tinyint primary key identity,
descricao varchar(30) unique not null
);
go

Create table Imagem(
idImagem int primary key identity(1,1),
idUsuario int not null unique foreign key references Usuario(idUsuario),
binario varbinary(max) not null,
mimeType varchar(30) not null,
nomeArquivo varchar(250) not null, 
data_inclusao datetime default getdate() null
);
go

Create table Produto(
idProduto int primary key identity,
idUsuario int not null foreign key references Usuario(idUsuario),
idSituacao tinyint not null foreign key references Situacao (idSituacao),
idImagem int foreign key references Imagem (idImagem),
nomeProduto varchar (50) not null,
descricao varchar (300) not null,
dataOferta datetime not null,
);
go