﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quobject.SocketIoClientDotNet.Client;

namespace SkyNeb_Socket.io
{
    class Program
    {
        static void Main(string[] args)
        {
            var socket = IO.Socket("wss://serviceaddress:portnumber");
            socket.On(Socket.EVENT_CONNECT, () =>
            {
                Console.WriteLine("connected...");
            });

            socket.On("channelname", (data) =>
            {
                Console.WriteLine(data);
            });
            Console.ReadLine();
        }
    }
}
