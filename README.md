<h1 align="center">Proyecto Final Fundamento de Software</h1>

## ALUMNOS
-Diego Lewensztain 

-Alejandro Ojeda

-Leandro Miranda

## PROBLEMATICA
El propósito de este proyecto es desarrollar una aplicación en C# que permita a los usuarios cifrar y descifrar mensajes utilizando el cifrado César. La aplicación debe ser capaz de recibir un texto y un desplazamiento como entradas, y luego permitir al usuario elegir si desea cifrar o descifrar el texto ingresado.
Para desarrollar habilidades fundamentales en programación y seguridad informática todo esto para fortalecer la capacidad de proteger información sensible y comunicaciones personales contra accesos no autorizados.


## JUSTIFICACION DEL PROYECTO
Presentamos un proyecto completo, muy sencillo, completo y eficaz. 
Este proyecto presenta un codigo bastante legible y entendible, los usuarios no solo aprenderan a cifrar y descifrar mensajes de manera interactiva, sino que tambien adquiriran habilidades de programacion y validacion de datos esenciales para el desarrollo de software seguro.


## DESCRIPCION DE FUNCIONES
Tenemos:
-Cipher.cs.- Aqui esta el codigo que hara el cifrado o descifrado de el texto que ingrese el usuario. 
Metodo estatico para Encriptar que toma un string(text) y un int(shift) como parametros y devuelve un string(el texto ya cifrado).
Luego pasamos a un bucle que recorrera cada caracter del texto ingresado, y:
 -Si es una letra agarrara y el valor ASCII sumara el entero a recorrer y con el offset ajustara al rango de letra may o min, luego asegura que el desplazamiento este dentro de rango
 - Si no es una letra se agrega el caracter tal cual
Y nos devolvera el txto ya cifrado.

Metodo estatico para DesEncriptar que toma un string(text) y un int(shift) como parametros y devuelve un string(el texto ya descifrado).
Llama a la funcion de descriptar y realiza el proceso solo que de manera inversa con los parametros string(text) y int(26-shift) 

-Program.cs.- Este contiene el menu donde recibiremos toda la informacion y devolveremos la el texto cifrado o descifrado
Primero nos pedira ingresar el texto que vamos a cifrar o descifrar
Segundo el numero de desplazamiento para el texto
Luego nos preguntara si queremos cifrar o descifrar, y depende lo que escojamos llamara a la funcion correspondiente para realizar lo solicitado

-CipherTests.cs.- Tenemos unas pruebas para verificar el correcto funcionamiento de nuestro codigo tanto encriptando como descriptando distintos mensajes, con distintos desplazamientos


