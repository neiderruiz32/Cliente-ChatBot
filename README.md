A continuación se muestra el contenido del archivo README.md para los aplicativos cliente y servidor:

# Aplicativo Cliente-Servidor de Chat

Este proyecto consiste en una aplicación cliente-servidor de chat utilizando sockets en C#. El aplicativo cliente puede enviar preguntas al servidor y recibir respuestas correspondientes.

## Aplicativo Servidor

El aplicativo servidor espera a que los clientes se conecten y responde a sus preguntas. A continuación se detalla cómo utilizarlo:

1. Abre una terminal o un IDE y abre el archivo `ServidorSocket.cs`.
2. Compila y ejecuta el aplicativo servidor.
3. El servidor mostrará un mensaje de bienvenida y esperará a que los clientes se conecten.
4. Cuando un cliente se conecte, el servidor mostrará su dirección IP y puerto.
5. El cliente puede enviar preguntas al servidor y recibir las respuestas correspondientes.
6. Para finalizar la conversación, el cliente puede enviar el mensaje "adios".

## Aplicativo Cliente

El aplicativo cliente permite enviar preguntas al servidor y recibir las respuestas correspondientes. A continuación se detalla cómo utilizarlo:

1. Abre una terminal o un IDE y abre el archivo `ClienteSocket.cs`.
2. Compila y ejecuta el aplicativo cliente.
3. El cliente se conectará automáticamente al servidor y recibirá un mensaje de bienvenida.
4. El cliente puede escribir una pregunta y presionar Enter para enviarla al servidor.
5. El cliente recibirá la respuesta del servidor y podrá realizar más preguntas.
6. Para finalizar la conversación, el cliente puede escribir "adios" y presionar Enter.

## Nota

Se debe compilar primero el aplicativo servidor antes del aplicativo cliente. Recordar que se debe compilar y ejecutar los aplicativos cliente y servidor por separado en diferentes terminales o máquinas para que puedan comunicarse entre sí. Asegurarse de utilizar la misma dirección IP y puerto en ambos aplicativos.
