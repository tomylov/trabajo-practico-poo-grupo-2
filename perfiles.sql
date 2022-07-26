create database POO_grupo2bd
use POO_grupo2bd

 insert into Perfiles values('Super admin'),('Cliente'),('Vendedor')
 insert into Articulos values ('Mayonesa','100','200'),('Salchicha','200','90'),('Coca-cola','1','250')

insert into Usuarios values('43767827','admin',ENCRYPTBYPASSPHRASE('contraseña','clave'),'tomas','123',1)
insert into Usuarios values('43767827','cliente',ENCRYPTBYPASSPHRASE('contraseña','clave'),'Alva','123',2)
insert into Usuarios values('43767827','vendedor',ENCRYPTBYPASSPHRASE('contraseña','clave'),'tomas','123',3)


 select * from Usuarios
 select * from Perfiles
 select * from Articulos
 select * from Detalle_ventas
