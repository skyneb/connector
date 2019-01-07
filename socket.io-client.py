import socketio

sio = socketio.Client()

@sio.on('connect')
def on_connect():
    print('connection established')

@sio.on('channelname')
def on_message(data):
    print(data)

@sio.on('disconnect')
def on_disconnect():
    print('disconnected from server')

sio.connect('wss://serviceaddress:portnumber')
sio.wait()
