<script src="https://cdnjs.cloudflare.com/ajax/libs/socket.io/2.1.1/socket.io.js"></script>
<script>
var socket = io.connect('wss://serviceaddress:portnumber');
socket.on("channelname",function (data){
  console.log(data);
}); 
</script>