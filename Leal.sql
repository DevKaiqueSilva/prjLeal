-- CRIANDO O BANCO DE DADOS.
CREATE DATABASE Leal

-- SELECIONANDO O BANCO DE DADOS PARA USO.
USE Leal

-- CRIAÇÃO DAS TABELAS.
CREATE TABLE Cliente
(
	Cod_Cliente INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Nome_Cliente VARCHAR(25) NOT NULL,
	Sobrenome_Cliente VARCHAR(80) NOT NULL,
	DataNascimento_Cliente DATE ,
	Sexo_Cliente VARCHAR(1),
	Endereco_Cliente VARCHAR(50) ,
	NumeroCasa_Cliente INT ,
	Bairro_Cliente VARCHAR(50) ,
	Cidade_Cliente VARCHAR(50) ,
	Estado_Cliente VARCHAR(2) ,
	Telefone_Cliente VARCHAR(10) ,
	Celular_Cliente VARCHAR(11) ,
	Foto_Cliente Varchar(100)
)

ALTER TABLE Cliente ALTER COLUMN Telefone_Cliente VARCHAR(14)
ALTER TABLE Cliente ALTER COLUMN Celular_Cliente VARCHAR(15)

CREATE TABLE Usuario
(
	Cod_Usuario INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Nome_Usuario VARCHAR(25) NOT NULL,
	Email_Usuario VARCHAR(120) NOT NULL,
	Senha_Usuario VARCHAR (100)NOT NULL
)

CREATE TABLE Produto
(
	Cod_Produto INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	CodigoBarra_Produto BIGINT,
	Descricao_Produto VARCHAR(50) NOT NULL,
	Marca_Produto VARCHAR(30) ,
	Embalagem_Produto VARCHAR(20) ,
	Tipo_Produto VARCHAR(15) ,
	Quantidade_Produto INT NOT NULL,
	Preco_Produto Decimal NOT NULL,
	Foto_Produto Varchar(100)
)
ALTER TABLE Produto ALTER COLUMN Preco_Produto Decimal(18,2)

CREATE TABLE Pedido
(
	Cod_Pedido INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Cod_Cliente INT NOT NULL,
	Data_Pedido DATE NOT NULL,
	SubTotal_Pedido Decimal NOT NULL,
	StatusPag_Pedido varchar(15) NOT NULL,
	FOREIGN key (Cod_Cliente) references Cliente(Cod_Cliente)
)
ALTER TABLE Pedido ALTER COLUMN SubTotal_Pedido Decimal(18,2)
ALTER TABLE Pedido ADD Debito_Pedido decimal null
select*from Pedido
drop table Pagamento
drop table Parcela

CREATE TABLE Pagamento
(
	Cod_Pagamento INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Cod_Pedido int not null,
	
	TipoPagamento_Pagamento varchar(20) not null,
	FOREIGN key (Cod_Pedido) references Pedido(Cod_Pedido),
	

)

--CREATE TABLE Parcela
--(
--	Cod_Parcela INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
--	Valor_Parcela decimal not null,
--	Data_Parcela Date not null,
--	Quantidade_Parcela int not null,
--)
CREATE TABLE ItemPedido
(
	Cod_ItemPedido int IDENTITY(1,1)PRIMARY KEY NOT NULL,
	Cod_Pedido int not null,
	Quantidade_ItemPedido int not null,
	Cod_Produto int not null,
	FOREIGN KEY(Cod_Pedido) references Pedido(Cod_Pedido),
	FOREIGN KEY(Cod_Produto) references Produto(Cod_Produto)
)
--------------------------Inserindo dados

INSERT INTO Cliente VALUES ('Kaique','Souza Silva','16/01/2001','M','Raimundo Frutuoso da Silva','1464','São Conrado','Sorocaba','SP','1532264781','15991106262','');
INSERT INTO Cliente VALUES ('Pedro','Liendo','16/10/1997','M','Maria Joaquina','22','São Maria','Presidente Prudente','SP','1433140456','14997645233','');
INSERT INTO Cliente VALUES ('Marco','José Jacob','12/05/1987','M','Chade Caleti','54','Lago Azul','Campinas','SP','1532214587','15922552644','');
INSERT INTO Cliente VALUES ('Luiz','Augusto Snatos','14/02/1986','M','Santo Mendes','156','São Mateus','Sorocaba','SP','1532456875','15992456875','');
INSERT INTO Cliente VALUES ('Luana','Souza','25/12/1999','F','Fiorentina Pasto','154','Vila Hortência','Sorocaba','SP','1532123759','15991281315','');
INSERT INTO Cliente VALUES ('Alisson','Pereira','02/01/1998','M',' Preste de Barros','125','Vila São Caetano','Sorocaba','SP','1532144235','15994582141','');
INSERT INTO Cliente VALUES ('Isabela','Maria Machado','11/10/2001','F','Jaziel de Azeredo Ribeiro','255','Antonio Cassillo','Votorantim','SP','1530311112','15997526222','');
INSERT INTO Cliente VALUES ('Marta','Wayne','12/10/1978','F','Joe Chill','15','Gotham','Sorocaba','SP','1536547792','15998576422','');
INSERT INTO Cliente VALUES ('Thomas','Vagner','07/03/1975','M','Eduardo Bon','1456','Don Filomeno','Sorocaba','SP','1532254497','15997561284','');
INSERT INTO Cliente VALUES ('Alanis','Helora','18/02/1997','F','João Ferreira da Silva','135','Além Ponte','Sorocaba','SP','1534205687','15997670251','');
INSERT INTO Cliente VALUES ('Douglas','Nelson','15/02/1995','M','Calebe Mario','215','São Bento','Sorocaba','SP','1531122541','15995846892','');


INSERT INTO Produto VALUES (0000000000, 'Sabão em Pó', 'Ajax', '10 Litros', 'Limpeza', 100, 2.49, '')
INSERT INTO Produto VALUES (1111111111, 'Alvejante Liquido', 'Sanol', '5 Litros', 'Limpeza', 90, 4.99, '')
INSERT INTO Produto VALUES (2222222222, 'Agua Sanitária', 'Candura', '4 Litros', 'Limpeza', 120, 3.79, '')
INSERT INTO Produto VALUES (3333333333, 'Detergente', 'Ypê', '350 ml', 'Limpeza', 80, 1.89, '')
INSERT INTO Produto VALUES (4444444444, 'Sabão em Pedra', 'Ajax', '100g', 'Limpeza', 45, 2.69, '')
INSERT INTO Produto VALUES (5555555555, 'Amaciante de Roupas', 'Confort', '2 Litros', 'Limpeza', 85, 7.39, '')
INSERT INTO Produto VALUES (6666666666, 'Esponja', 'Ajax', '50g', 'Limpeza', 94, 1.99, '')
INSERT INTO Produto VALUES (7777777777, 'Vassoura', 'Miano', '10 Litros', 'Limpeza', 78, 4.99, '')
INSERT INTO Produto VALUES (8888888888, 'Desengordurante', 'Ypê', '500 ml', 'Limpeza', 25, 2.99, '')
INSERT INTO Produto VALUES (9999999999, 'Inseticida', 'SBP', '2 Litros', 'Limpeza', 15, 3.99, '')


INSERT INTO ItemPedido VALUES(2,6,5)
INSERT INTO ItemPedido VALUES(2,22,4)
INSERT INTO ItemPedido VALUES(2,33,3)
INSERT INTO ItemPedido VALUES(5,12,6)
INSERT INTO ItemPedido VALUES(5,25,7)
INSERT INTO ItemPedido VALUES(6,10,8)
INSERT INTO ItemPedido VALUES(6,12,1)
INSERT INTO ItemPedido VALUES(7,18,3)
INSERT INTO ItemPedido VALUES(7,16,4)
INSERT INTO ItemPedido VALUES(7,15,2)

INSERT INTO Pedido VALUES (2,'12/04/2018',105.00,'Pago',50)
INSERT INTO Pedido VALUES (2,'11/02/2018',150.00,'Pago',50)
INSERT INTO Pedido VALUES (3,'10/01/2018',50.00,'Em Aberto',20)
INSERT INTO Pedido VALUES (5,'26/03/2018',55.00,'Em Aberto',10)
INSERT INTO Pedido VALUES (6,'10/09/2018',60.00,'Pago',50)
INSERT INTO Pedido VALUES (7,'09/08/2018',80.00,'Em Aberto',20)
INSERT INTO Pedido VALUES (8,'04/02/2018',14.00,'Em Aberto',6)
INSERT INTO Pedido VALUES (9,'05/05/2018',140.00,'Pago',50)
INSERT INTO Pedido VALUES (10,'20/06/2018',75.00,'Em Aberto',30)
INSERT INTO Pedido VALUES (4,'01/05/2018',64.00,'Pago',50)

SET DATEFORMAT dmy; 
--INSERT INTO Parcela VALUES (10.00, '01/10/2018', 1)
--INSERT INTO Parcela VALUES (20.00, '02/10/2018', 2)
--INSERT INTO Parcela VALUES (30.00, '03/10/2018', 3)
--INSERT INTO Parcela VALUES (40.00, '04/10/2018', 4)
--INSERT INTO Parcela VALUES (50.00, '05/10/2018', 5)
--INSERT INTO Parcela VALUES (60.00, '06/10/2018', 6)
--INSERT INTO Parcela VALUES (70.00, '07/10/2018', 7)
--INSERT INTO Parcela VALUES (80.00, '08/10/2018', 8)
--INSERT INTO Parcela VALUES (90.00, '09/10/2018', 9)
--INSERT INTO Parcela VALUES (100.00, '09/10/2018', 10)

INSERT INTO Pagamento VALUES (1,  'CRÉDITO')
INSERT INTO Pagamento VALUES (2,  'DÉBITO')
INSERT INTO Pagamento VALUES (3,  'DINHEIRO')
INSERT INTO Pagamento VALUES (4,  'CRÉDITO')
INSERT INTO Pagamento VALUES (5,  'DINHEIRO')
INSERT INTO Pagamento VALUES (6,  'DÉBITO')
INSERT INTO Pagamento VALUES (7,  'DINHEIRO')
INSERT INTO Pagamento VALUES (8,  'DÉBITO')
INSERT INTO Pagamento VALUES (9,  'CRÉDITO')
INSERT INTO Pagamento VALUES (10,  'DINHEIRO')

INSERT INTO Usuario VALUES ('Kaique','kaiquesouzasilva11@gmail.com','01020102')

Select *from Cliente
Select *from Produto
Select *from ItemPedido
Select *from Pedido
Select *from  Pagamento
Select *from Usuario

--drop table Cliente
--drop table Produto
--drop table ItemPedido
--drop table Pedido
--drop table Pagamento
--drop table Usuario

DELETE FROM  Pedido

DBCC CHECKIDENT(Pagamento, RESEED, 0)

Select Cod_Produto from Produto where  Descricao_Produto = 'Sabão em pó'

select CodPedido=Pedido.cod_pedido, CodItemPedido=Cod_ItemPedido,CodProduto=Produto.Cod_Produto, CódigoDeBarrras = Produto.CodigoBarra_Produto, Produto=produto.Descricao_Produto, PreçoUnit=Produto.Preco_Produto,Quantidade=ItemPedido.Quantidade_ItemPedido, Total=ItemPedido.Quantidade_ItemPedido* Produto.Preco_Produto from ItemPedido,Pedido,Produto where ItemPedido.Cod_Pedido = Pedido.Cod_Pedido and ItemPedido.Cod_Produto = Produto.Cod_Produto and Pedido.Cod_Pedido =2

SELECT        Pedido.Cod_Pedido, ItemPedido.Cod_ItemPedido, Produto.Cod_Produto, Produto.CodigoBarra_Produto, Produto.Descricao_Produto, Produto.Preco_Produto, ItemPedido.Quantidade_ItemPedido, 
                         ItemPedido.Quantidade_ItemPedido * Produto.Preco_Produto AS Total
FROM            ItemPedido INNER JOIN
                         Produto ON ItemPedido.Cod_Produto = Produto.Cod_Produto INNER JOIN
                         Pedido ON ItemPedido.Cod_Pedido = Pedido.Cod_Pedido

	SELECT *FROM PEDIDO WHERE Cod_Cliente = 2 

Select Cod_Cliente from Cliente  where Nome_Cliente = 'Kaique'

SELECT Cod_Cliente from Cliente where Nome_Cliente like 'Kaique'

UPDATE Produto SET Preco_Produto = '100'  where CodigoBarra_Produto = '1111111111' 

delete from Pedido
where Cod_Pedido =12
delete from ItemPedido
delete from pagamento