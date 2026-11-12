<img width="502" height="372" alt="image" src="https://github.com/user-attachments/assets/5dfeaff8-f1b2-49fe-aabb-4097d787ee33" /><h1>
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
  
  <p>
    <img width="453" height="686" alt="encender1" src="https://github.com/user-attachments/assets/ff0b9374-7471-4971-9d63-7bf4fbaf3a2b" />
  </p>
  
  <p>
    Y, por último, se crean dos métodos, "Activar" y "Desactivar". Lo que sucede es que, al colocar o quitar la batería en el espacio de atrás del mando, llama a uno de los dos métodos, los cuales, dependiendo de cuál sea el caso, todos los componentes (scripts) que contiene el mando se activarán o desactivarán.
  </p>
  
  <p>
    <img width="314" height="330" alt="encender2" src="https://github.com/user-attachments/assets/86c8331e-74f9-4fc9-aaf1-8afe9288484d" />
  </p>

<h3>
  Movimiento y vuelo del robot
</h3>
  <p>
    <img width="502" height="372" alt="Move1" src="https://github.com/user-attachments/assets/8f9777e1-5da0-48c1-9c88-bd15b654601c" />
  </p>
  <p>
    <img width="802" height="636" alt="Move2" src="https://github.com/user-attachments/assets/aab0a0c1-423f-4ebc-a69c-8786444688c2" />
  </p>
  <p>
    <img width="620" height="481" alt="Fly1" src="https://github.com/user-attachments/assets/bdce88c6-e4b2-4c7d-9bed-81e8b31b75f7" />
  </p>
  <P>
    <img width="429" height="648" alt="Fly2" src="https://github.com/user-attachments/assets/1a4d66c9-954b-41d3-950b-119bf1badd1b" />
  </P>

<h3>
  Agarrar/Soltar/Escalar bloques
</h3>
  
 <h2>Resultado</h2>
