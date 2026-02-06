
--Select * from  DISCOS
 --Select Titulo, FechaLanzamiento, Descripcion from DISCOS d inner join Estilos e on d.IdEstilo = e.Id

 --INSERT
 insert into ESTILOS (Descripcion) VALUES
 ('Cumbia'),
 ('Salsa'),
 ('Reggaeton')
 insert into TIPOSEDICION (Descripcion) VALUES 
 ('Digital'),
 ('Cassette'),
 ('Blu-Ray')