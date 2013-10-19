import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.net.ServerSocket;
import java.net.Socket;


public class Server {
	private ServerSocket mSocket;
	public Server() {

	}
	public void start() {
		String inputLine;
		try {
			mSocket = new ServerSocket(9999);
			
			while(true){
				Socket clientSocket = mSocket.accept();
				PrintWriter out = new PrintWriter(clientSocket.getOutputStream(), true);
				BufferedReader in = new BufferedReader(new InputStreamReader(clientSocket.getInputStream()));
				while ((inputLine = in.readLine()) != null) {
					System.err.println(inputLine);
				}
			}
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	public static void main(String[] args) {

		Server server = new Server();
		server.start();
	}
}
