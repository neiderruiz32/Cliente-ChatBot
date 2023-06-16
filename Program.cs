using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

class ClienteSocket
{
    static void Main()
    {
        // Configuración del cliente
        string serverIP = "127.0.0.1";  // IP del servidor
        int serverPort = 12345;  // Puerto del servidor

        // Crear un socket TCP/IP
        Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        try
        {
            // Conectarse al servidor
            clientSocket.Connect(new IPEndPoint(IPAddress.Parse(serverIP), serverPort));
            Console.WriteLine("Conectado al servidor: " + clientSocket.RemoteEndPoint);

            // Recibir mensaje de bienvenida del servidor
            byte[] mensajeBytes = new byte[1024];
            int bytesRecibidos = clientSocket.Receive(mensajeBytes);
            string mensajeBienvenida = Encoding.ASCII.GetString(mensajeBytes, 0, bytesRecibidos);
            Console.WriteLine(mensajeBienvenida);

            while (true)
            {
                // Leer la pregunta desde la consola
                Console.Write("Ingrese una pregunta: ");
                string pregunta = Console.ReadLine();

                // Enviar la pregunta al servidor
                byte[] preguntaBytes = Encoding.ASCII.GetBytes(pregunta);
                clientSocket.Send(preguntaBytes);

                // Verificar si se debe terminar la conexión con el servidor
                if (pregunta.ToLower() == "adios")
                break;

                // Recibir la respuesta del servidor
                bytesRecibidos = clientSocket.Receive(mensajeBytes);
                string respuesta = Encoding.ASCII.GetString(mensajeBytes, 0, bytesRecibidos).TrimEnd('\0');

                // Mostrar la respuesta en la consola
                Console.WriteLine("Respuesta del servidor: " + respuesta);

            }

            // Cerrar la conexión con el servidor
            clientSocket.Shutdown(SocketShutdown.Both);
            clientSocket.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.ToString());
        }
    }
}
