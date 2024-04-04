CREATE DATABASE EMPRESA;
CREATE TABLE CLIENTE (
	IDCLIENTE		INT IDENTITY (1,1) NOT NULL,
	NOMBRE			NVARCHAR(50) NOT NULL,
	APELLIDO		NVARCHAR(50) NOT NULL,
	CORREO			NVARCHAR(20) NOT NULL,
	TELEFONO		NVARCHAR(50) NOT NULL,
	DIRECCION		NVARCHAR(50) NOT NULL
	PRIMARY KEY(IDCLIENTE),
)
CREATE TABLE PEDIDOS (
	IDPEDIDO		INT IDENTITY(1,1) NOT NULL,
	IDCLIENTE		INT NOT NULL,
	FECHA			DATETIME NOT NULL,
	TOTAL			MONEY NOT NULL,
	ESTADO			NVARCHAR(20) NOT NULL
	PRIMARY KEY(IDPEDIDO),
	FOREIGN KEY (IDCLIENTE) REFERENCES CLIENTE(IDCLIENTE),
);
INSERT INTO CLIENTE VALUES('Pedro', 'Fernandez', 'pedro@gmail.com', '+59172345423','B. San Mateo');
INSERT INTO CLIENTE VALUES('Carla', 'Fernandez', 'carla@gmail.com', '+59172245423','B. Las panoosas');
INSERT INTO CLIENTE VALUES('Cristian', 'Ordoñez', 'cristian@gmail.com', '+59179345423','B. San Mateo');
INSERT INTO CLIENTE VALUES('Jorge', 'Estrada', 'jorge@gmail.com', '+59162345423','B. 24 de junio');
INSERT INTO CLIENTE VALUES('Helman', 'Fuentes', 'helman@gmail.com', '+59169345423','B. Senac');
INSERT INTO CLIENTE VALUES('Osnier', 'Camacho', 'osnier@gmail.com', '+59174445423','B. La Habana');
INSERT INTO CLIENTE VALUES('Tito', 'Jerez', 'tito@gmail.com', '+5917432223','B. Luis de fuentes');
INSERT INTO CLIENTE VALUES('Carlos', 'Balcazar', 'carlos@gmail.com', '+59179445423','B. 3 de mayo');
INSERT INTO CLIENTE VALUES('ALonso', 'Urdidinea', 'alonso@gmail.com', '+59164445423','B. La loma');
INSERT INTO CLIENTE VALUES('Geraldyn', 'Jurado', 'geraldyn@gmail.com', '+59173025423','B. El trigal');

insert into PEDIDOS values (2, '2024-05-12', 100, 'Exitoso');
insert into PEDIDOS values (1, '2024-05-12', 20, 'Exitoso');
insert into PEDIDOS values (4, '2024-03-18', 400, 'Exitoso');
insert into PEDIDOS values (5, '2024-04-11', 150, 'Exitoso');
insert into PEDIDOS values (8, '2024-07-22', 600, 'Exitoso');
insert into PEDIDOS values (6, '2024-06-14', 190, 'Exitoso');
insert into PEDIDOS values (9, '2024-01-12', 110, 'Exitoso');
insert into PEDIDOS values (10, '2024-02-08', 340, 'Exitoso');
insert into PEDIDOS values (1, '2024-09-02', 10, 'Exitoso');
insert into PEDIDOS values (2, '2024-12-12', 380, 'Exitoso');
insert into PEDIDOS values (3, '2024-11-22', 200, 'Exitoso');
insert into PEDIDOS values (6, '2024-10-02', 300, 'Exitoso');
insert into PEDIDOS values (9, '2024-10-11', 90, 'Exitoso');
insert into PEDIDOS values (5, '2024-12-25', 950, 'Exitoso');