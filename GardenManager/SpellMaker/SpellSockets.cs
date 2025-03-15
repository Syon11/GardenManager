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
        string spellsJson = String.Empty;
        var buffer = new byte[1024];
        // Avons-nous des données? clientSocket.Available
        var bytesRead = clientSocket.Receive(buffer);
        if (bytesRead > 0)
        {
            var message = Encoding.UTF8.GetString(buffer);
            try
            {
                var json = message.Substring(message.IndexOf('['));
                SpellManager spellManager = new SpellManager(json); 
                spellsJson = spellManager.GetSpellsAsJson();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("HTTP/1.1 200 OK");
            sb.AppendLine("Content-Type: application/json");
            sb.AppendLine($"Content-Length: {message.Length}");
            sb.AppendLine();
            sb.AppendLine(spellsJson);
            
            clientSocket.Send(Encoding.UTF8.GetBytes(sb.ToString()));

            if (string.IsNullOrEmpty(spellsJson))
            {
                Console.WriteLine("Malformed JSON received");
            }
            Console.WriteLine($"Received {spellsJson}");
            
        }

        clientSocket.Close();
    }
    
}