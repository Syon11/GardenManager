using System.Net;
using System.Net.Sockets;
using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace GardenManager.SpellMaker;

public class SpellSockets
{
    private const int port = 26900;
    private bool running = true;
    
    private IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Any, port);
    private Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

    public SpellSockets()
    {
        serverSocket.Bind(ipEndPoint);
        serverSocket.Listen(10);
        
        Console.WriteLine($"Server Started on port {port}");

        Console.CancelKeyPress += (sender, eventArgs) =>
        {
            Console.WriteLine($"{Environment.NewLine}Shutting down...");
            running = false;
            serverSocket.Close();
            Environment.Exit(0);
        };

        while (running)
        {
            var clientSocket = serverSocket.Accept();
            HandleClientRequest(clientSocket);
        }
    }

    private void HandleClientRequest(Socket clientSocket)
    {
        var buffer = new byte[1024];
        // Avons-nous des données? clientSocket.Available
        var bytesRead = clientSocket.Receive(buffer);
        if (bytesRead > 0)
        {
            var message = Encoding.UTF8.GetString(buffer);
            
            Console.WriteLine(message);
            
            const string html = "<h1>Hello world!</h1>";
            
            var sb = new StringBuilder();
            sb.AppendLine("HTTP/1.1 200 OK");
            sb.AppendLine("Content-Type: text/html");
            sb.AppendLine($"Content-Length: {html.Length}");
            sb.AppendLine();
            sb.AppendLine(html);

            clientSocket.Send(Encoding.UTF8.GetBytes(sb.ToString()));
        }
    }
    
}