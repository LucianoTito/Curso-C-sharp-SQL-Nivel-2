1. Clases Abstractas (abstract)
Concepto: "La Plantilla Incompleta". Es una clase que sirve de base para otras, pero es tan genérica que no tiene sentido que exista por sí sola.

La Regla: No puedes usar new con ella. No puedes crear una instancia directa.

El Beneficio: Te obliga a usar la herencia. Define qué cosas deben tener los hijos, pero deja que los hijos decidan los detalles.

Tu Ejemplo (El problema de Persona): En tu sistema, ¿tiene sentido que contrates a "una Persona" genérica? No. Contratas a un Developer o a un Tester. Nadie trabaja de "Persona". Por eso, Persona debería ser abstracta.

// Al poner 'abstract', PROHIBO crear objetos de tipo Persona.
public abstract class Persona 
{
    public string Nombre { get; set; }
    
    // Método abstracto: "Obligo a mis hijos a que ellos digan cómo trabajan"
    // No tiene llaves { } porque no sé cómo trabaja una persona genérica.
    public abstract string Trabajar(); 
}

// Ahora Developer ESTÁ OBLIGADO a implementar Trabajar()
public class Developer : Persona 
{
    public override string Trabajar() 
    {
        return "Escribiendo código en C#...";
    }
}

✅ Persona p = new Developer(); (Válido, polimorfismo).

❌ Persona p = new Persona(); (Error, no puedes instanciar lo abstracto).

2. Clases Selladas (sealed)
Concepto: "El Producto Final". Es una clase que decide que nadie más herede de ella. Es el final de la cadena evolutiva.

La Regla: Nadie puede poner : EstaClase después de su nombre.

El Beneficio: Seguridad y rendimiento. Aseguras que nadie modifique el comportamiento de tu clase creando una hija "rara".

Tu Ejemplo: Imagina que la clase Tester es perfecta tal cual es. No quieres que venga otro programador mañana y cree un TesterJunior que rompa tu lógica. Le pones un candado.

// Nadie puede heredar de Tester
public sealed class Tester : Persona
{
    public override string Trabajar()
    {
        return "Probando el sistema...";
    }
}

// ESTO DARÍA ERROR DE COMPILACIÓN:
// class TesterJunior : Tester { }  <-- ¡PROHIBIDO!

3. Clases Estáticas (static)
Concepto: "La Caja de Herramientas". No representan un "objeto" de la vida real (como una persona o un auto), sino un conjunto de funciones útiles.

La Regla:

No se puede hacer new.

No puede heredar de nadie (ni nadie de ella).

Todo lo que tenga adentro (métodos, propiedades) también debe ser static.

El Beneficio: Tienes funciones disponibles en todo el programa sin necesidad de crear variables.

public static class CalculadoraDeSueldos
{
    // Al ser static, la llamo directo por el nombre de la clase
    public static double CalcularBono(double sueldoBase)
    {
        return sueldoBase * 1.10; // 10% de bono
    }
}

// EN EL MAIN:
// No hago: Calculadora c = new Calculadora();
// Lo uso directo:
double bono = CalculadoraDeSueldos.CalcularBono(150000);