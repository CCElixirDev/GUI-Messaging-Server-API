using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace ServerLibs.Server
{
    public class Server : IDisposable
    {
        public static Dictionary<string, Thread> threadHandlers = new Dictionary<string, Thread>();
        public List<Socket> sockets = new List<Socket>();
        public List<Socket> clientConnections = new List<Socket>();
        public List<byte[]> buffers = new List<byte[]>();
        public int ServerPort { get; private set; }
        public IPAddress serverAddress;

        public bool IsRunning = false;

        public enum SocketTypes
        {
            UDP,
            TCP
        }

        SocketTypes currentSocketType;

        public Server(int portNumber, SocketTypes socketType)
        {
            ServerPort = portNumber;
            currentSocketType = socketType;
            InitializeSocket(portNumber);
            TaskFactory tf = new TaskFactory(TaskScheduler.Default);
            tf.StartNew(() => WaitForClientConnection(sockets.FirstOrDefault()));
        }

        private void InitializeSocket(int port)
        {
            Socket socket = null;
            switch (currentSocketType) {
                case SocketTypes.UDP:
                    socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                    socket.Bind(new IPEndPoint(serverAddress, port));
                    break;
                case SocketTypes.TCP:
                    socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    socket.Bind(new IPEndPoint(serverAddress, port));
                    break;
            }
            IsRunning = true;
        }

        private void WaitForClientConnection(Socket socket)
        {
            socket.BeginAccept(WaitForClientConnectionCallBack, socket);
        }

        private void WaitForClientConnectionCallBack(IAsyncResult ar)
        {
            if (ar.CompletedSynchronously)
            {
                buffers.Add(new byte[4096]);
                var buffer = buffers.LastOrDefault();
                clientConnections.Add(((Socket)ar.AsyncState).EndAccept(out buffer, ar));
            }
        }

        private int RecieveDataFromClient(ref Socket socket, Socket clientsocket, ref byte[] bytes)
        {
            try
            {
                socket.BeginReceive(bytes, 0, clientsocket.ReceiveBufferSize, SocketFlags.None, RecieveDataFromClientCallback, socket);
                return 1;
            }
            catch (SocketException)
            {
                throw;
            }
        }

        private void RecieveDataFromClientCallback(IAsyncResult ar)
        {
            SocketError ErrorCode;
            var socket = (Socket)ar.AsyncState; 
            var code = socket.EndReceive(ar, out ErrorCode);

        }

        public void ExecuteCLICmd(string cmd)
        {
            var tokens = cmd.Split(' ');
            switch (tokens[0]) {
                case "Change-Port":
                    break;
                case "Reset":
                    break;
                default:
                    ServerLog("Invalid Command");
                    break;
            }
        }

        private bool ResetServer()
        {
            if (this.IsRunning)
            {
                try
                {
                    sockets.Clear();
                    clientConnections.Clear();
                    threadHandlers.Clear();
                    ServerPort = 3367;
                }
                catch (Exception)
                {
                    throw new Exception("Issue restarting server");
                }
                return true;
            }
            else
            {
                return false;

            }
        }

        private void ServerLog(string log)
        {
            
        }

        private void ChangePort(int port)
        {

        }

        public void Dispose() {

        }
    }
}
