## connector
SkyNeb / Oasis Financial Network RealTime Price Feeder Connector


See also: [EngineIoClientDotNet](https://github.com/Quobject/EngineIoClientDotNet)

## For Installation (Recommended Component)
[Nuget install](https://www.nuget.org/packages/SocketIoClientDotNet/):
```
Install-Package SocketIoClientDotNet
```



## Skyneb Connector Example Code (C#)

```cs
using System;
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
```
## Skyneb Connector Example Code (JS)

```js
<script src="https://cdnjs.cloudflare.com/ajax/libs/socket.io/2.1.1/socket.io.js"></script>
<script>
var socket = io.connect('wss://serviceaddress:portnumber');
socket.on("channelname",function (data){
  console.log(data);
}); 
</script>
```

## Skyneb Connector Example Code (JS) - Server Side with socket.io-client

```js
const
io = require("socket.io-client"),
ioClient = io.connect("wss://serviceaddress:portnumber", { transports: ['websocket'], rejectUnauthorized: false });
ioClient.on("channelname", (msg) => console.info(msg));
```

## For Installation (socket.io-client)
for use "socket.io-client" in server side you have to install "socket.io-client" with npm.

```
npm install socket.io-client --save
```




