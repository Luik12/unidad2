# unidad2

tarea de la unidad 2



Una descripción general de la aplicación.

Esta es una aplicación de consola creada para realizar operaciones matemáticas básicas, en la cual el usuario puede decidir qué tipo de dato desea utilizar. Además, maneja errores a través de excepciones para evitar que el programa se detenga.





Explicación de los métodos utilizados.

AgregarNumero

Con este método guardamos o agregamos a una lista los números con los que realizaremos las operaciones.



Convertir

Transforma los números que se pasan a la lista en tipo decimal para poder realizar las operaciones y evitar errores, ya que decimal abarca los demás tipos de datos utilizados.



EjecutarOperacion

Este método recibe la operación que se desea realizar y la aplica a todos los elementos de la lista. Por ejemplo, si la lista tiene tres valores, primero opera los dos iniciales y luego el resultado se opera con el tercero.



Sumar, Restar, Multiplicar y Dividir

Son los métodos que recibe EjecutarOperacion y se encargan únicamente de realizar la operación matemática correspondiente.



Main

Como es comúnmente sabido, es el método principal donde se ejecutan todos los procesos del programa y desde donde inicia la aplicación.



Ejecutar)

Administra el menú de opciones, permite agregar números, ejecutar operaciones y cambiar el tipo de dato cuando el usuario lo desee.





Descripción de las excepciones manejadas.

FormatException

Se produce cuando el usuario ingresa un valor en un formato incorrecto, como por ejemplo texto en lugar de un número.



InvalidOperationException

Se lanza cuando el usuario no tiene la cantidad de valores necesarios para realizar una operación. En este caso, ocurre si la lista no contiene dos o más elementos.



DivideByZeroException

Ocurre cuando se intenta dividir un número entre cero. 







Cómo el código utiliza genéricos y delegados.

El código usa genéricos para que la aplicación pueda trabajar con diferentes tipos de números sin tener que cambiar nada en el programa. Por ejemplo, el usuario puede elegir si quiere usar int, double o decimal, y la lista guardará esos valores sin problema. Esto ayuda a no repetir código y hace que la aplicación sea más fácil de usar.



También se usan delegados para realizar las operaciones matemáticas. El delegado permite indicar qué operación se quiere hacer, como sumar, restar, multiplicar o dividir, y el programa la aplica a los números de la lista. Esto hace que todo sea más ordenado y permite usar el mismo método para distintas operaciones.





Propósito del proyecto



El propósito de este proyecto es crear una aplicación de consola que permita al usuario realizar operaciones matemáticas básicas usando una lista de números. El programa fue diseñado para que el usuario pueda elegir el tipo de dato con el que desea trabajar, como enteros o decimales, y así tener mayor flexibilidad. Además, se busca aplicar conceptos importantes de C# como genéricos, delegados y el manejo de excepciones para evitar errores durante la ejecución.



Instrucciones para ejecutar el programa



Primero, se debe ejecutar en Visual Studio. Al iniciar, el sistema pedirá seleccionar el tipo de dato que se desea usar. Luego, aparecerá un menú donde el usuario podrá agregar números a la lista y escoger la operación que quiere realizar, ya sea sumar, restar, multiplicar o dividir. Después de obtener el resultado, el usuario puede seguir agregando números, realizar otra operación o cambiar el tipo de dato si lo desea.



Cómo el programa maneja las excepciones



El programa maneja las excepciones para evitar que se cierre cuando ocurre un error. Por ejemplo, si el usuario ingresa un valor que no es un número, el sistema muestra un mensaje indicando que debe ingresar un dato válido. También verifica que haya al menos dos números en la lista antes de realizar una operación y evita la división entre cero. De esta manera, el programa se mantiene funcionando correctamente y le informa al usuario qué ocurrió.

