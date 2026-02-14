--Quiero traer además de la infomación del pokemon, su tipo.

--Consulta entre tablas:
SELECT P.Nombre, P.Descripcion, P.UrlImagen,E.Descripcion AS Tipo, D.Descripcion AS Debilidad FROM dbo.ELEMENTOS E, POKEMONS P, ELEMENTOS D  WHERE E.Id = P.IdTipo And D.Id = P.IdDebilidad


 
