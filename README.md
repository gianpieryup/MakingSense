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
