const
io = require("socket.io-client"),
ioClient = io.connect("wss://serviceaddress:portnumber", { transports: ['websocket'], rejectUnauthorized: false });
ioClient.on("channelname", (msg) => console.info(msg));
