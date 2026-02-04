1. El misterio de la variable animal
Mira detenidamente esta línea dentro de tu bucle:

C#
Console.WriteLine(animal.comunicarse());
Aquí está sucediendo algo que, si lo piensas, es muy loco:

La variable animal es de tipo Genérico (Animal).

Sin embargo, cuando el programa corre, el resultado es Específico (uno ladra, el otro maúlla, el otro gruñe).

La Analogía del Director de Orquesta: Imagina que eres un director de orquesta (tú eres el foreach). Tienes una fila de músicos con instrumentos distintos (Violín, Tambor, Flauta), pero todos son "Músicos" (Animal).

Tú no tienes que ir uno por uno diciendo: "Tú, toca las cuerdas con el arco", "Tú, golpea el parche con el palo". Tú simplemente levantas la batuta y das una orden genérica: "¡Toquen!" (comunicarse()).

El Violín entiende "Toquen" y hace sonar cuerdas.

El Tambor entiende "Toquen" y golpea el parche.

La Flauta entiende "Toquen" y sopla aire.

Eso es Polimorfismo: Una misma orden (comunicarse), ejecutada por objetos distintos, genera comportamientos distintos.

2. ¿Qué pasa "Bajo el capó" en tu Foreach?
Vamos a seguir la ejecución de tu código paso a paso mentalmente:

Vuelta 1:

El foreach saca el primer objeto. Es el objeto p1 (Perro).

Lo guarda en la variable animal.

Ejecuta animal.comunicarse().

C# dice: "Un momento, la variable dice Animal, pero en memoria real esto es un Perro. Voy a ejecutar el código del Perro".

Salida: "Guau Guau".

Vuelta 2:

El foreach saca el segundo objeto. Es g1 (Gato).

Ejecuta la misma línea de código: animal.comunicarse().

C# dice: "Ahora en memoria hay un Gato".

Salida: "Miau Miau".

Vuelta 3:

Saca el Oso.

C# detecta que es un Oso.

Salida: "Grrrr".