use std::time::Duration;
use std::{env, thread::sleep};

use futures_util::{StreamExt, SinkExt, stream::{SplitSink, SplitStream}};
use tokio::io::{AsyncRead, AsyncWrite};
use tokio_tungstenite::{connect_async, tungstenite::Message, WebSocketStream};

// handle_incoming_messages takes in the read input and will run infinitly till a break is introduced.
// even if an error is introduced in the function, it wont cause the program to panic and shit itself
// all this does is print any message that come in.
// This leads to unintended things like trying to display the closing connection.

//TODO: add message types like pings, close and opens
async fn handle_incoming_messages(mut read: SplitStream<WebSocketStream<impl AsyncRead + AsyncWrite + Unpin>>) {
    while let Some(message) = read.next().await {
        match message {
            Ok(msg) => println!("Received a message: {}", msg),
            Err(e) => eprintln!("Error receiving message: {}", e),
        }
    }
}

//our heartbeat sender! every second it will send a heart beat till it goes over 5, where it will then close the connection and exit/break
async fn heartbeat(mut write: SplitSink<WebSocketStream<impl AsyncRead + AsyncWrite + Unpin>, Message>){
    let mut number = Some(0);
    while let Some(i) = number {
        if i >= 5 {
            println!("Heartbreat success!");
            write.close().await.expect("Cant close connection");
            break;
        }
        else {
            write.send(Message::Ping("Ping!".into())).await.expect("Couldnt sent message :(");
            sleep(Duration::from_secs(1));
            number = Some(i + 1)
        }
    }
}


// this is where the magic happens!
#[tokio::main]
async fn main() {
    // this 'env" takes in a url to a server through the cli! "ws://" is already added in, though I'm not sure if this will affect anything later
    let connection_url: String = env::args()
        .nth(1)
        .unwrap_or_else(|| panic!("put in a url dummy"));
    let url: String = format!("ws://{}", connection_url);
    // dont ask why the url and connection url cant be one thing. i just dont wanna teal with ".clone"

    // Connecting to the server. connect_async is from tokio tungstenite, making things a lot easier for us!
    println!("Connecting to server {}...", connection_url);
    let (ws_stream, _) = connect_async(url).await.expect("failed to connect :( --> ");

    println!("Connected to {}!", connection_url);
    let (write, read) = ws_stream.split();

    // starts up the handler for incoming messages and looks at the read input
    let read_handle = tokio::spawn(handle_incoming_messages(read));

    // later someone will need to replace this with a way to send messages as this only sends heartbeats
    let heartbeat_handle = tokio::spawn(heartbeat(write));

    let _ = tokio::try_join!(read_handle, heartbeat_handle);

}
