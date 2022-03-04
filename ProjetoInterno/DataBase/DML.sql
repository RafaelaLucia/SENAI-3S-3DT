use Classificados_Tarde

insert into TipoUsuario (tituloTipo)
values ('Vendedor'),('Cliente');
go

insert into Usuario(idTipo, nomeUsuario, email, senha)
values (1, 'Mark', 'Vendedor@email.com','senha123'),
(2,'Fulano','cliente@email.com','fulano123');
go

insert into Situacao (descricao)
values ('Disponível'),('Esgotado'),('Reservado');
go

insert into Produto (idUsuario, idSituacao, nomeProduto, descricao, dataOferta)
values (1,1, 'Notebook Positivo', 'notebook da positivo seminovo i3', '22/02/2022 22:22');
go

