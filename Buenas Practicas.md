# Convenciones y Estándares de Nombres

Las siguientes convensiones pretenden ayudar a standarizar el desarrollo de esta proyecto, es posible que al inicio sea incomodo seguirlar pero busco que este protecto este disponible a la mayor cantidad de programadores sin importar su nivel de conocimiento.

**Si lo puede entender tu abuela ...** estas en el camino correcto. 
El codigo esta bien formado cuando alguien que no lo ha codificado es capaz de leerlo sin necesidad de adivinar que hace y que necesita.

**Notación Pascal** – El primer carácter de todas las palabras se escribe en Mayúsculas y los otros caracteres en minúsculas.

> Ejemplo: ColorDeFondo

**Notación de Camell** – El primer carácter de todas las palabras, excepto de la primera palabra se escribe en Mayúsculas y los otros caracteres en minúsculas.

> Ejemplo: colorDeFondo

1. Usa notación Pascal para el nombre de las Clases
2. Usa notación Pascal para el nombre de los Métodos
3. Usa notación de Camell para variables y parámetros de los métodos
4. Usa el prefijo “I” con notación Pascal para las interfaces (Ejemplo: IEntity). Utiliza “T“ para estructuras de tipos de datos.
5. No uses notación Húngara para el nombre de las variables.
6. Usa palabras entendibles y descriptivas para nombrar a las variables. No uses abreviaciones.
7. No uses nombres de variables de un solo caracter como i, n, s etc. Usa nombres como indice, temp. **Una excepción** en este caso podría ser las variables usadas para iteraciones en los ciclos:

```sh
for ( int i = 0; i < cuantos; i++)
{ ....
}
```
8. No uses guiones bajos (_) para nombres de variables locales.
9. No uses palabras reservadas para nombres de variables.
10. Usa el prefijo “Es” ó “Is” para variables de tipo boolean o prefijos similares.
```sh
private bool EsValido
private bool IsActivo
```
11. Los nombres de Clases o Métodos y funciones deben seguir el estándar :
```sh
<Accion/Verbo en Inglés><descripción>
GetClientes();
AddCliente();
```
12. El nombre de los archivos debe coincidir con el nombre de la clase.

# Buenas prácticas de programación
> “Los programas deben ser escritos para que los lean las personas, y sólo incidentalmente, para que lo ejecuten las máquinas”.
– Abelson and Sussman

1. **Evita escribir métodos muy largos.** Un método debe típicamente tener entre 1 a 25 líneas de código. Si un método tiene más de 25 líneas de código, debes considerar refactorizarlo en métodos separados.
2. **El nombre de los métodos debe decir lo que hace.** No uses nombres engañosos. Si el nombre del método es obvio, no hay necesidad de documentación que explique qué hace el método.
3. **Un método debe tener solo ‘una tarea’**. No combines más de una tarea en un solo método, aún si esas tareas son pequeñas.
4. **Siempre verifica valores inesperados.** Por ejemplo, si estas usando un parámetro con 2 posibles valores, nunca asumas que si uno no concuerda entonces la única posibilidad es el otro valor.
5. **Convierte las cadenas de texto a minúsculas o mayúsculas antes de compararlas.** Esto asegurará que la cadena coincida.
6. **Usa String.Empty en vez de “”** al momento de hacer comparaciones.
7. **Evita usar variables globales.** Declara variables locales siempre que sea necesario y pásalas a otros métodos en vez de compartir una variable global entre métodos. Si compartes una variable global entre métodos, te será difícil rastrear qué método cambia el valor y cuando.
8. Cuando despliegues mensajes de error, adicionalmente a decirle al usuario qué está mal, el mensaje debe también decirle lo que el usuario debe hacer para resolver el problema. En vez de un mensaje como *“Fallo al actualizar la base de datos.”*, sugiere lo que el usuario debe hacer: *“Fallo al actualizar la base de datos. Por favor asegúrate de que la cuenta y la contraseña sean correctos.”.*
9. Muestra mensajes cortos y amigables al usuario. Pero registra el error actual con toda la información posible. Esto ayudará mucho a diagnosticar problemas.
10. **Evita pasar muchos parámetros a un método.** Si tienes más de 4~5 parámetros, es un buen candidato para definir una clase o una estructura. Lo contrario destroza el consumo en memoria, más facilidad de corrupción de datos, más castigo a los ciclos del procesador... etc.
11. Si tienes un método que retorna una colección, **devuelve una colección vacía en vez de null**, si no hay datos que retornar. Por ejemplo, si tienes un método que retorna un ArrayList, siempre retorna un ArrayList válido. Si no tienes elementos que devolver, entonces retorna un ArrayList válido con 0 elementos. Esto hará fácil para la aplicación que llama al método verificar solamente la propiedad “Count” en vez que hacer verificaciones adicionales para “null”.
12. Si estas abriendo conexiones a una base de datos, sockets, archivos etc, **siempre cierra dichas conexiones en el bloque finally.** Esto asegurará que aún si una excepción ocurre después de abrir la conexión, se cerrará seguramente en el bloque finally.
13. Declara variables tan cerca como sea posible de donde son usadas por primera vez. Usa una declaración de variable por línea.
14. **Usa la clase StringBuilder en vez de String si tienes que manipular objetos de tipo string dentro de un ciclo.** El objeto String trabajar en modo extraño en .NET. Cada vez que concatenas una cadena, realmente se descarta la cadena anterior y se recrea un nuevo objeto, lo cual es una operación relativamente pesada.
15. **No guardes más de una clase en un solo archivo.**


  








