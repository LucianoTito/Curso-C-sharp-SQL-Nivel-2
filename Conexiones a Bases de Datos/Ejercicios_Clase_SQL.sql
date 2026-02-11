--SELECT * from DISCOS
--SELECT * FROM TIPOSEDICION
--SELECT * from ESTILOS
--SELECT DISTINCT e.Descripcion
--FROM ESTILOS e
-- INNER JOIN [DISCOS] d ON e.Id = d.IdEstilo
 /* SELECT
d.Titulo AS Nombre,
e.Descripcion AS Estilo,
t.Descripcion AS Edicion
FROM DISCOS d
INNER JOIN ESTILOS e ON d.IdEstilo = e.Id
INNER JOIN TIPOSEDICION t ON d.IdTipoEdicion = t.Id */
/* ==================================================================
   APUNTE RÁPIDO: ALIAS Y JOINS EN SQL
   ==================================================================

   1. ¿QUÉ ES UN ALIAS? (Las letras minúsculas)
   Es un apodo corto que le inventamos a una tabla para escribir menos 
   y mantener el código limpio. Se asigna en el FROM o en el JOIN.
   - Ejemplo: FROM DISCOS d  --> La 'd' es el alias de DISCOS.

   2. ¿CÓMO SE USA EN EL SELECT?
   Sirve como "GPS" para SQL. Le indica exactamente de qué tabla 
   debe sacar una columna, evitando errores si dos tablas tienen 
   columnas que se llaman igual (como 'Descripcion' o 'Id').
   - Ejemplo: SELECT d.Titulo, e.Descripcion

   3. ¿CÓMO FUNCIONA EL INNER JOIN?
   Es un puente que une dos tablas basándose en una coincidencia.
   Busca que el número "Foráneo" (ej: IdEstilo en el disco) 
   sea igual al número "Principal" (ej: Id en la tabla estilos).

   - ESTRUCTURA CLÁSICA DE UN JOIN:
   SELECT a.Columna, b.Columna
   FROM TablaA a
   INNER JOIN TablaB b ON a.IdForaneo = b.IdPrincipal
   ================================================================== */
SELECT Titulo from DISCOS
where Titulo LIKE '%ar%'