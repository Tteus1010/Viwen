|| Projeto de conclusão de curso || ADS ETEC BASILIDES DE GODOY ||

Programa de cadastro, edição e visualização de produtos de uma loja de roupa, dados para criação do banco:

create database viwen;
use viwen;

create table login(
login_user varchar(30),
senha_user varchar(16));

create table produto(
id_prod int auto_increment,
nome_prod varchar(60),
qtd_prod varchar(4),
vl_prod varchar(10),
desc_prod varchar(60),
primary key(id_prod));

insert into produto(nome_prod, qtd_prod, vl_prod, desc_prod) values ('null','null','null','null');

item 1 da lista de produtos SEMPRE precisar listar como nulo.
