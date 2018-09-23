CREATE DATABASE GARCIAS_DB
GO
USE GARCIAS_DB
GO
CREATE TABLE MODULOS(
	IDMODULO INT NOT NULL IDENTITY (1,1) PRIMARY KEY,
	DESCRIPCION VARCHAR(30) NOT NULL,
	OPC_HABILITADAS INT NOT NULL,
	)

GO
CREATE TABLE PERFILES(
	IDPERFIL INT NOT NULL IDENTITY (1,1) PRIMARY KEY,
	DESCRIPCION VARCHAR(50) NOT NULL,
	IDMODULOS INT NOT NULL FOREIGN KEY REFERENCES MODULOS(IDMODULO),
	FECHA_ALTA DATETIME NOT NULL,
	FECHA_BAJA DATETIME NULL,
	ULT_MOD DATETIME NULL
	)
    
GO
CREATE TABLE USUARIOS(
	IDUSER INT NOT NULL IDENTITY (1,1) PRIMARY KEY,
	USUARIO VARCHAR (10) NOT NULL UNIQUE,
	NOMBRE_APELLIDO VARCHAR(150) NOT NULL,
	FECHA_ALTA DATETIME NOT NULL,
	FECHA_BAJA DATETIME NULL,
	ULT_MOD DATETIME NULL,	
	BLOQUEADO BIT NOT NULL,
	CLAVE VARCHAR(10) NOT NULL,
	IDPERFIL INT NOT NULL FOREIGN KEY REFERENCES PERFILES(IDPERFIL)
	)
    
GO
CREATE TABLE CONTACTOS(
	IDCONTACTO INT NOT NULL IDENTITY (1,1) PRIMARY KEY,
	NOMBRE VARCHAR(80) NOT NULL,
	TELEFONO INT NULL,
	EMAIL VARCHAR(50) NULL,
	DIRECCION VARCHAR(50) NULL
	)


GO
CREATE TABLE CLIENTES(
	IDCLIENTE INT NOT NULL IDENTITY (1,1) PRIMARY KEY,
	NOMBRE VARCHAR(50) NOT NULL,
	CUIT VARCHAR(13) NOT NULL UNIQUE,
	IDCONTACTO INT NOT NULL FOREIGN KEY REFERENCES CONTACTOS(IDCONTACTO)
	)
GO 
CREATE TABLE PROVEEDORES(
	IDPROV INT NOT NULL IDENTITY (1,1) PRIMARY KEY,
	NOMBRE VARCHAR(50) NOT NULL,
	CUIT VARCHAR(13) NOT NULL UNIQUE,
	IDCONTACTO INT NOT NULL FOREIGN KEY REFERENCES CONTACTOS(IDCONTACTO)
	)
    
GO
CREATE TABLE INSUMOS(
	IDINSUMO INT NOT NULL PRIMARY KEY,
	DESCRIPCION VARCHAR(50) NOT NULL,
	VALOR_ULT_COMPRA MONEY NULL,
	FECHA_ULT_COMPRA DATETIME NULL,
	)
    
GO
CREATE TABLE PRODUCTOS(
	IDPROD INT NOT NULL IDENTITY (1,1) PRIMARY KEY,
	DESCRIPCION VARCHAR(50) NOT NULL,
	GANANCIA INT NOT NULL,
	INSUMOS VARCHAR(30) NOT NULL,
	VALOR_ULT_VTA MONEY NULL,
	FECHA_ULT_VTA DATETIME NULL	
	)
GO
CREATE TABLE COMPRAS(
	IDCOMPRA INT NOT NULL IDENTITY (1,1) PRIMARY KEY,
	CODPROV INT NOT NULL FOREIGN KEY REFERENCES PROVEEDORES(IDPROV),
	FECHA_COMPRA DATETIME NOT NULL,
	VALOR_COMPRA MONEY NOT NULL,
	NRODOCUMENTO VARCHAR(15) NULL,
	)
GO
CREATE TABLE REMITOS(
	NROREMITO VARCHAR(15) NOT NULL,
	FECHAREMITO DATETIME NOT NULL,
	NROPEDIDO INT NOT NULL FOREIGN KEY REFERENCES COMPRAS(IDCOMPRA),
	INSUMO INT NOT NULL FOREIGN KEY REFERENCES INSUMOS(IDINSUMO),
	CANTIDAD INT NOT NULL,
	PRIMARY KEY(NROREMITO,INSUMO)
	)

GO 
CREATE TABLE VENTAS(
	IDVENTA INT NOT NULL IDENTITY (1,1) UNIQUE,
	FECHA_VTA DATETIME NOT NULL,
	IDCLIENTE INT NOT NULL FOREIGN KEY REFERENCES CLIENTES(IDCLIENTE),
	PRODUCTO INT NOT NULL FOREIGN KEY REFERENCES PRODUCTOS(IDPROD),
	CANTIDADVTA INT NOT NULL,
	STATUS_VENTA INT NOT NULL,
	VENDEDOR INT NOT NULL FOREIGN KEY REFERENCES USUARIOS(IDUSER),
	PRIMARY KEY (IDVENTA, FECHA_VTA, PRODUCTO)
	)

GO
CREATE TABLE PEDIDOS(
	IDPEDIDO INT NOT NULL IDENTITY (1,1),
	IDVENTA INT NOT NULL FOREIGN KEY REFERENCES VENTAS(IDVENTA),
	FECHA_PEDIDO DATETIME NOT NULL,	
	FECHA_ENTREGA_ACORDADA DATETIME NOT NULL,
	FECHA_ENTREGA_REAL DATETIME NULL,
	INSUMOS INT NOT NULL FOREIGN KEY REFERENCES INSUMOS(IDINSUMO),
	CANTIDAD INT NOT NULL,
	VALOR_VTA_PROM MONEY NULL,
	STATUS_PEDIDO INT NOT NULL,
	NROFACTURA VARCHAR(15) NULL,
	FECHA_FACTURA DATETIME NULL,
	MONTO_FACTURA MONEY NULL,
	PRIMARY KEY (IDVENTA, INSUMOS)
	)

GO
    INSERT INTO MODULOS (DESCRIPCION,OPC_HABILITADAS) VALUES ('ADMINISTRADOR',1)
    INSERT INTO MODULOS (DESCRIPCION,OPC_HABILITADAS) VALUES ('VENDEDOR',2)
GO
    INSERT INTO PERFILES(DESCRIPCION,IDMODULOS,FECHA_ALTA,FECHA_BAJA,ULT_MOD) VALUES ('Admin Sistema',1,'23/9/2018',NULL,'23/9/2018')
    INSERT INTO PERFILES(DESCRIPCION,IDMODULOS,FECHA_ALTA,FECHA_BAJA,ULT_MOD) VALUES ('Ventas',2,'23/9/2018',NULL,'23/9/2018')
GO
    INSERT INTO USUARIOS (USUARIO,NOMBRE_APELLIDO,FECHA_ALTA,FECHA_BAJA,ULT_MOD,BLOQUEADO,CLAVE,IDPERFIL) VALUES ('GARCIAS','SANTIAGO GARCIA','23/9/2018',NULL,'23/9/2018',0,'TEST',1)
    INSERT INTO USUARIOS (USUARIO,NOMBRE_APELLIDO,FECHA_ALTA,FECHA_BAJA,ULT_MOD,BLOQUEADO,CLAVE,IDPERFIL) VALUES ('DINELLAS','SANTIAGO DINELLA','23/9/2018',NULL,'23/9/2018',0,'TEST',2)
GO
    INSERT INTO CONTACTOS (NOMBRE,TELEFONO,EMAIL,DIRECCION) VALUES ('ADRIAN CACCAVIELLO', 1538845385, 'ADRI_KK@GMAIL.COM','LIMA 1501, PACHECO')
    INSERT INTO CONTACTOS (NOMBRE,TELEFONO,EMAIL,DIRECCION) VALUES ('LUCAS ADELMANN', 1541381234, 'ANDY_LUKETI@GMAIL.COM','BALCARCE 83, PACHECO')
    INSERT INTO CONTACTOS (NOMBRE,TELEFONO,EMAIL,DIRECCION) VALUES ('LAUTARO LUPANI', 47362411, 'LAUTARO.LUPANI@TREKEN.COM.AR','PAUL GROUSAC 2405, LOPEZ CAMELO')
    INSERT INTO CONTACTOS (NOMBRE,TELEFONO,EMAIL,DIRECCION) VALUES ('FRANCO BARBIERI', 47407847, 'VIKTIMA_22@GMAIL.COM','ALBERDI 203, PACHECO')
GO
    INSERT INTO CLIENTES (NOMBRE,CUIT,IDCONTACTO) VALUES ('PATRICIA GONZALEZ','27-25338134-4',4)
    INSERT INTO CLIENTES (NOMBRE,CUIT,IDCONTACTO) VALUES ('FRANCO BARBIERI','20-32392192-7',2)
GO
    INSERT INTO PROVEEDORES (NOMBRE,CUIT,IDCONTACTO) VALUES ('FERRETERIA GONZALEZ','30-25338134-2',1)
    INSERT INTO PROVEEDORES (NOMBRE,CUIT,IDCONTACTO) VALUES ('TREKEN S.A','30-50918302-7',3)
GO
    INSERT INTO INSUMOS (IDINSUMO,DESCRIPCION,VALOR_ULT_COMPRA,FECHA_ULT_COMPRA) VALUES (1,'PERFIL 3/4',450,'1/7/2018')
    INSERT INTO INSUMOS (IDINSUMO,DESCRIPCION,VALOR_ULT_COMPRA,FECHA_ULT_COMPRA) VALUES (2,'SELLADOR',250,'8/9/2018')
GO
    INSERT INTO PRODUCTOS (DESCRIPCION,GANANCIA,INSUMOS,VALOR_ULT_VTA,FECHA_ULT_VTA) VALUES ('VENTANA A MEDIDA 2x4',25,'1,2',4000,'10/9/2018')
    INSERT INTO PRODUCTOS (DESCRIPCION,GANANCIA,INSUMOS,VALOR_ULT_VTA,FECHA_ULT_VTA) VALUES ('VENTANA ESTANDAR 1,8x2',15,'1,2',2500,'18/9/2018')
GO
    INSERT INTO COMPRAS (CODPROV,FECHA_COMPRA,VALOR_COMPRA,NRODOCUMENTO) VALUES (1,'10/9/2018',900,'0001A00001234')
    INSERT INTO COMPRAS (CODPROV,FECHA_COMPRA,VALOR_COMPRA,NRODOCUMENTO) VALUES (2,'10/9/2018',500,'0001A00000394')
    INSERT INTO COMPRAS (CODPROV,FECHA_COMPRA,VALOR_COMPRA,NRODOCUMENTO) VALUES (1,'20/9/2018',1800,'0001A00001265')
    INSERT INTO COMPRAS (CODPROV,FECHA_COMPRA,VALOR_COMPRA,NRODOCUMENTO) VALUES (2,'20/9/2018',750,'0001A00000416')
GO
    INSERT INTO REMITOS (NROREMITO,FECHAREMITO,NROPEDIDO,INSUMO,CANTIDAD) VALUES ('0001R00007789','14/9/2018',1,1,2)
    INSERT INTO REMITOS (NROREMITO,FECHAREMITO,NROPEDIDO,INSUMO,CANTIDAD) VALUES ('0001R00001245','10/9/2018',2,2,2)
    INSERT INTO REMITOS (NROREMITO,FECHAREMITO,NROPEDIDO,INSUMO,CANTIDAD) VALUES ('0001R00007837','25/9/2018',3,1,4)
    INSERT INTO REMITOS (NROREMITO,FECHAREMITO,NROPEDIDO,INSUMO,CANTIDAD) VALUES ('0001R00001378','21/9/2018',4,2,3)
GO
    INSERT INTO VENTAS (FECHA_VTA,IDCLIENTE,PRODUCTO,CANTIDADVTA,STATUS_VENTA,VENDEDOR) VALUES ('22/9/2018',1,1,4,0,2)
    INSERT INTO VENTAS (FECHA_VTA,IDCLIENTE,PRODUCTO,CANTIDADVTA,STATUS_VENTA,VENDEDOR) VALUES ('22/9/2018',2,2,8,0,2)
GO
    INSERT INTO PEDIDOS (IDVENTA,FECHA_PEDIDO,FECHA_ENTREGA_ACORDADA,FECHA_ENTREGA_REAL,INSUMOS,CANTIDAD,VALOR_VTA_PROM,STATUS_PEDIDO,NROFACTURA,FECHA_FACTURA,MONTO_FACTURA) VALUES (1,'22/9/2018','24/11/2018',NULL,1,8,2500,1,NULL,NULL,NULL)
    INSERT INTO PEDIDOS (IDVENTA,FECHA_PEDIDO,FECHA_ENTREGA_ACORDADA,FECHA_ENTREGA_REAL,INSUMOS,CANTIDAD,VALOR_VTA_PROM,STATUS_PEDIDO,NROFACTURA,FECHA_FACTURA,MONTO_FACTURA) VALUES (1,'22/9/2018','24/11/2018',NULL,2,3,750,1,NULL,NULL,NULL)
    INSERT INTO PEDIDOS (IDVENTA,FECHA_PEDIDO,FECHA_ENTREGA_ACORDADA,FECHA_ENTREGA_REAL,INSUMOS,CANTIDAD,VALOR_VTA_PROM,STATUS_PEDIDO,NROFACTURA,FECHA_FACTURA,MONTO_FACTURA) VALUES (2,'22/9/2018','15/12/2018',NULL,1,8,2500,1,NULL,NULL,NULL)
    INSERT INTO PEDIDOS (IDVENTA,FECHA_PEDIDO,FECHA_ENTREGA_ACORDADA,FECHA_ENTREGA_REAL,INSUMOS,CANTIDAD,VALOR_VTA_PROM,STATUS_PEDIDO,NROFACTURA,FECHA_FACTURA,MONTO_FACTURA) VALUES (2,'22/9/2018','15/12/2018',NULL,2,3,750,1,NULL,NULL,NULL)