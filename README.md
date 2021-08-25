# Capacitación .NET

C# es un lenguaje de programación

.NET es un framework para la construcción de aplicaciones en Windows
CLR  (comun lenguaje runtime)

### CLR

Antes cuando compilaba en Windows 96 -> lenguaje nativo de una computadora de Windows 96
Esto no lo entiende por ejemplo otro SO(Linux)

C# nace de esta cuestión, no se traduce a lenguaje de maquina inmediatamente si no que pasa por un intermedio

<u>Usando JAVA</u>
Código java       ->     Byte Code
Alto nivel        			Lenguaje intermedio

<u>Análogamente en C#</u>
Codigo C#     ->   IL Code             **->**     Native Code
alto nivel              Intermediate           Lenguaje

Eso ultimo es independiente de la computadora que lo ejecute
IL Code -> Native COde (Just-in-time Compilation : **JIT** )

**Namespace** = Un contenedor(conjunto) para clases
**Assembly** = Contenedor de namespaces
Cuando se compila una aplicación, el compilador crea uno o mas ensamblajes según la forma en que particiona su código



#### Visual Studio IDE

Ventana de *Solution Explorer* : Es la visualización de tu carpeta raíz y sus archivos/carpetas

Si lo borras o no esta lo puedes volver a sacar: `VIEW->Solution Explorer`

:file_folder: `Properties : AssemblyInfo.cs `, contiene la identificación del Asembly (Titulo,Descripción,Compañía, Producto,Copyright,...)

:file_folder: ` References `: Conjunto de Ensamblajes que son parte de `:NET`, como por ejemplo (`System|System.Core|System.Data`,...) Como minimo VS supone que vas a utilizar clases del ensamblado del sistema

:page_facing_up:`App.config` : Están los valores de las configuraciones de la aplicación (cadena de conexión a la BD,Puerto,Dominio,... )



**Nuestro Proyecto** se llama  `HelloWorld`   ->  VS de forma predeterminada crea un `namespace` llamado `HelloWorld` , luego podemos acceder a todas las clases del ` namespace` si quisiera acceder al de otros lo importaría con `using ...`

``````c#
// Si usamos
Console.WriteLine("Hello World")
    
// Se resaltara 
using System;
// Es porque estamos usando la clase llamada "Console" que se define en el namespace de System
``````

Bonus: `ReSharper`

#### Udemy

Resumen
Entonces, en esta sección, aprendió los conceptos básicos de C #.

C # frente a .NET

C # es un lenguaje de programación, mientras que .NET es un marco. Consiste en un entorno de tiempo de ejecución (CLR) y una biblioteca de clases que usamos para crear aplicaciones.

CLR

Cuando compila una aplicación, el compilador de C # compila su código en código IL (lenguaje intermedio). El código IL es independiente de la plataforma, lo que hace posible tomar un programa C # en una computadora diferente con diferente arquitectura de hardware y sistema operativo y ejecutarlo. Para que esto suceda, necesitamos CLR. Cuando ejecuta una aplicación C #, CLR compila el código IL en el código de máquina nativo de la computadora en la que se está ejecutando. Este proceso se denomina compilación justo a tiempo (JIT).

Arquitectura de aplicaciones .NET

En términos de arquitectura, una aplicación escrita con C # consta de bloques de construcción llamados clases. Una clase es un contenedor de datos (atributos) y métodos (funciones). Los atributos representan el estado de la aplicación. Los métodos incluyen código. Tienen lógica. Ahí es donde implementamos nuestros algoritmos y escribimos código.

Un espacio de nombres es un contenedor de clases relacionadas. Entonces, a medida que su aplicación crece en tamaño, es posible que desee agrupar las clases relacionadas en varios espacios de nombres para una mejor capacidad de mantenimiento.

A medida que el número de clases y espacios de nombres crece aún más, es posible que desee separar físicamente los espacios de nombres relacionados en ensamblajes separados. Un ensamblado es un archivo (DLL o EXE) que contiene uno o más espacios de nombres y clases. Un archivo EXE representa un programa que se puede ejecutar. Una DLL es un archivo que incluye código que se puede reutilizar en diferentes programas.

En la siguiente sección, aprenderá los conceptos básicos del lenguaje C #, incluidas las variables, constantes, conversión de tipos y operadores.



**Sección 3: Primitive Types and Expressions**

````c#
Camel Case: firstName
Pascal Case: FirstName
Hungarian Notation: strFirstName // prefijo del tipo de dato (str)
````

**Primitivos** : `float, int, decimal, double`

````c#
float number = 1.2
// C# podria interpretar que es un double, si quiero decirle al compilador que lo interprete como un float debo aclarlo explicitamente.

// Luego
float number = 1.2f;
decimal number = 1.2m;

// Es un error dado que no puedo almacenar un int(8 bytes) en un (1 byte)
// ----------------- Sobre el casteo --------------------------
int number1 = 257;
byte number2 = number1; // Aqui ya directamente ocurrira un error de compilacion 
````

**No primitivos** : `String, Array, Enum, Class`

**Overflowing**

````c#
byte number = 255;
number = number + 1; // 0

// Lo anterior no intervierne en el flujo de la ejecucion(no es una expecion)
checked{
    byte number = 255;
	number = number + 1;
}
````

**Scope** : El alcance de una variable (Local: su bloque)



**ATAJO**: Para no escribir a mano `Console.WritLine()` usamos el atajo `cw + enter`

**ALCLARACION**: Me paso en Java que me olvide que esto solo tiene 1 argumento asi que no le puedes pasar mas, te saltara el error para que lo veas

````c#
try{}
catch(Exception){// Atrapa cualquier tipo de Exception
    // ...
}
````



### CLASES

````c#
public class Person{
    public string Name;
    public void Introduce(){
        Console.WriteLine("Hola mi nombre es " + Name);
    }
}

int number;
Person person = new Person();

// DONDE se inicializa tu programa
class Program{
    static void Main(){
    }
}
````

`Click derecho En el proyecto > Add > New Clase ` Y decime que me ayuda hacerlo de esto forma, FACIL , se me crea una plantilla con `namespace nombreProyecto, using's ...`

**Cuidado para importar una clase** que esta dentro de otra carpeta `namespace nombreProyecto.nameCarpeta` o mas fácil usa la ayuda



### struct

````c#
public struct RgbColor{
	public int Red;
    public int Green;
    public int Blue;
}
````

#### Strings

````c#
string name = firstName + " " + lastName;
string name = string.Format("{0} {1}",firstName,lastName);

var numbers = new int[3] {1,2,3};
string list = string.Join(",", numbers);

string name = "Mosh";
char firstChar = name[0];

// Cadenas literales
string path = "c:\\projects\\folder1";
string path = @"c:\projects\folder1"; // Este es equi elmino los exesos \
````



#### ENUM

````c#
public enum Ship{ // podes añadir la especificacion :byte
	reg=1,
	sum=2,
	mul=3;
}
// EN todo caso que haya un error castearlo como lo que quieres que sea (int)
var oper = Ship.reg;
Console.WriteLine((int) oper); // devuelve el int asociado

var op_id = 3
Console.WriteLine((Ship) op_id); // devuelve el string asociado
Console.WriteLine(oper.ToString()); // Analogo

// Generalizacion que nadie usa en la practica
var name = "reg";
var shipmet = (Ship) Enum.Parse(typeof (Ship), methodName);
````

#### Valor Por referencia

````c#
// LAs listas se pasan por referencia por defecto
var array1 = new int[3]{1,2,3};
var array2 = array1; // se copio su referencia
    array2[0] = 0; // se cambia en ambos, por que estan apuntando a la misma porcion de memoria
// Analogo a las listas tambien las clases se pasan por referencia
    
````



#### TIME

##### Lapso de Tiempo

````c#
var timeSpan = new TimeSpan(1,2,3); // ! hora | 2 min | 3 seg

var timeSpan1 = new TimeSpan(1,0,0); // Sabemos que es 1 hora pero quisa no muy expresivo
var timeSpan2 = TimeSpan.FromHours(1); // Mas expresivo

// La resta de 2 formatos Date sigue siendo un formato Date

// Properties
timeSpan.Minutes // 1:20:30 -> 20
timeSpan.TotalMinutes // 1:20:30 -> 60+20+0.5=80.5
// Tambien es inmutable
timeSpan.Add() // LE paso por paramtro otro TimeSpan  
timeSpan.Subtract()
    
CW("Parse: " + TimeSpan.Parse("01:02:03"))  
````

