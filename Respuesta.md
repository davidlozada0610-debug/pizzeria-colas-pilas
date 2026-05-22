1.	¿Por qué un sistema de delivery usa Queue para los pedidos pero Stack para la bitácora? ¿Qué problema surgiría si invertimos las estructuras?
R: Los pedidos de delivery se manejan en Queue (cola) porque el primer cliente que compra es el primero que debe recibir su comida. La bitácora usa Stack (pila) porque cuando abres un registro, siempre se quiere ver lo más reciente.
Si se invierten las estructuras, seria un caos total ya que al momento de hacer los delivery se dejaría esperando a las personas que ingresaron su pedido antes y al momento de ver el registro, siempre estaríamos viendo lo mismo, el registro no se actualizaría con lo más reciente.
2.	¿Por qué es obligatorio verificar Count == 0 antes de Dequeue() o Pop()? ¿Qué ocurre en ejecución si se omite? 
R: Es obligatorio porque no podemos sacar algo de donde no lo hay. Primero se revisa que la lista tiene algo con (Count == 0 ) antes de atender a un cliente o sacar una pizza.
Si se omite el programa nos lanzara un error en plena ejecución y la aplicación se cerrará

3.	En el método Deshacer, ¿por qué es necesario analizar el texto con .StartsWith() antes de revertir? ¿Qué error lógico evitaría esto?
 R: El error que se evita el programa es hacer la acción al reves o se confunda, si no se usara el .StartWith() el programa no sabría si deshacer un cliente ingresado o una pizza ingresada.

4.	¿Qué ventaja tiene entregar mediante Fork + Pull Request en lugar de un archivo comprimido? ¿Cómo facilita la la retroalimentación?
R: La ventaja es que es mas ordenado. Con un archivo comprimido “zip.” Sí le haces cambios al código, y debe ser enviado de regreso al profesor se tiende a enredarse entre versiones. Con el Fork + Pull Request el profesor puede ver los cambios exactos hechos al código directamente por github.
Falicita la retroalimentación ya que el profesor puede acceder a mi Pull Request y dejar comentarios para mejoras del código u ot
