<h1>
  Prototipo Control
</h1>
  <p>
    Este proyecto se realizó como una evaluación para la universidad. El propósito era crear un mando virtual interactuable, el cual pueda controlar alguna máquina a elección; en este caso se trata de un robot, el cual puede moverse, volar, agarrar otros bloques y modificar el tamaño de los bloques.
  </p>

<h2>
  Funcionamiento
</h2>  
<h3>
  Activar/desactivar mando
</h3>
  <p>
    Primero, el control inicia apagado en la escena, por lo que se requiere una batería para encenderlo; para que eso ocurra, creamos variables, por un lado de los scripts que se desactivan o activan, y por el otro, los GameObjects en donde se encuentran estos scripts.
  </p>
  <p>
    Luego, todas las variables de scripts serán equivalentes a los scripts que estén dentro de los GameObjects, respectivamente. 
  </p>
  <p>
    A continuación, se desactivarán todos los scripts de los controles desde el inicio para que se requiera colocar la batería.
  </p>
  
  <img width="453" height="686" alt="encender1" src="https://github.com/user-attachments/assets/ff0b9374-7471-4971-9d63-7bf4fbaf3a2b" />
  
  <p>
    Y, por último, se crean dos métodos, "Activar" y "Desactivar". Lo que sucede es que, al colocar o quitar la batería en el espacio de atrás del mando, llama a uno de los dos métodos, los cuales, dependiendo de cuál sea el caso, todos los componentes (scripts) que contiene el mando se activarán o desactivarán.
  </p>
  
  <img width="314" height="330" alt="encender2" src="https://github.com/user-attachments/assets/86c8331e-74f9-4fc9-aaf1-8afe9288484d" />

<h3>
  Movimiento y vuelo del robot
</h3>
  <P>
    para el robot, float para la velocidad, Rigidbody del robot y un vector 3 dirección en 0.
  </P>
  <p>
    Luego se iguala la variable "_rb" para que sea igual al Rigidbody del robot y se activa el "isKinematic" para este.
  </p>
  <img width="502" height="372" alt="Move1" src="https://github.com/user-attachments/assets/8f9777e1-5da0-48c1-9c88-bd15b654601c" />
  <p>
    En el método "Movimiento", primero se crean 2 variables, "_vauleX" y "_vauleY"; estas tomarán los valores del joystick en sus respectivos ejes.
  </p>
  <p>
    Luego, para que el robot se mueva solo en 4 direcciones, dentro del switch se usa una fórmula matemática para sacar el valor absoluto de los ejes. En el caso de ir a la derecha, si la variable "x" absoluta es mayor a la variable "y" absoluta, y aparte, la variable "x" es positiva, entonces la dirección será a la derecha.
  </p>
  <P>
    Esta lógica se aplica a los 4 lados para determinar en qué dirección después se aplicará la fuerza, llamando al método "MoverRobot", el cual consiste en que, si la dirección es igual a 0, entonces no hace nada para que no se gasten recursos, y después, si se encuentra el Rigidbody, entonces se le aplicará una fuerza al robot calculando su posición actual y sumando la dirección multiplicada por la velocidad y Time.deltaTime.
  </P>
  <img width="802" height="636" alt="Move2" src="https://github.com/user-attachments/assets/aab0a0c1-423f-4ebc-a69c-8786444688c2" />
  <p>
    Ahora, para que el robot vuele, primero se crean tres variables: dos para llamar a scripts y una para almacenar los datos del transform del robot.
  </p>
  <p>
    El método "volar" se creó para tener una referencia de cuándo se activaba o no el vuelo, dependiendo del valor de la lever, si era true o false; en cualquiera de los 2 casos, al final acaba llamando al método "Altura". 
  </p>
  <img width="620" height="481" alt="Fly1" src="https://github.com/user-attachments/assets/bdce88c6-e4b2-4c7d-9bed-81e8b31b75f7" />
  <p>
    Luego, en el método llamado "Altura", se crean dos variables: una para saber la altura actual, que será igual al valor del slider, y la posición, que será igual a la posición actual del robot.
  </p>
  <img width="429" height="648" alt="Fly2" src="https://github.com/user-attachments/assets/1a4d66c9-954b-41d3-950b-119bf1badd1b" />
  

<h3>
  Agarrar/Soltar/Escalar bloques
</h3>

  <img width="359" height="166" alt="Block1" src="https://github.com/user-attachments/assets/7fadc94e-7eb0-4ae8-91bb-81a94a42fc4b" />


  <img width="816" height="631" alt="Block2" src="https://github.com/user-attachments/assets/0a203607-1bd3-4748-aca0-84e1e8f870b0" />


  <img width="573" height="223" alt="Block3" src="https://github.com/user-attachments/assets/4c2aebef-6843-4ba4-b0e9-dd0ecb17315c" />


  <img width="556" height="139" alt="Block4" src="https://github.com/user-attachments/assets/de50afcc-2fcc-4510-a2a1-62aed2dd9175" />


 <h2>Resultado</h2>
