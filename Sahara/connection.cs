using System;
using System.IO;
using System.Net;
using System.Text;
using System.Net.Sockets;

public class Connection
{
    public static void main()
    {
        try
        {
            TcpClient tcpConnection = new TcpClient();
            Console.WriteLine("Connecting... \n");

            tcpConnection.Connect("127.0.0.1", 27015);

            Console.WriteLine("Connected!   \n");


        }
        catch (Exception e)
        {
            Console.WriteLine("ERROR: " + e.StackTrace);
        }
    }

}