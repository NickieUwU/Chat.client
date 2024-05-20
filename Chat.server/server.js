const WebSocket = require("ws");
const server = new WebSocket.Server({ port: 7000 }, () => {
    console.log("Running on ws://localhost:7000");
});

server.on('connection', socket => {
    console.log("Client connected");

    socket.on('message', message => {

    });
    socket.on('close', () => {
        console.log("Disconnected");
    });
});