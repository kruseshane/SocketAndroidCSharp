package com.example.csharpsocketapp;

import android.os.AsyncTask;

import java.io.IOException;
import java.net.Socket;

public class ConnectionClass extends AsyncTask<Void, Void, Void> {

    Socket socket;

    @Override
    protected Void doInBackground(Void... voids) {

        System.out.println("Background process started");

        try {
            // Socket for the android app, used to connect to the socket on the specified device using the specified port
            // 10.0.2.2 is to connect to 127.0.0.1 using android emulator
            socket = new Socket("10.0.2.2", 8888);
            
            // If it connects, this will display
            System.out.println("Connected");
        } catch (IOException e) {

        }

        return null;
    }
}
