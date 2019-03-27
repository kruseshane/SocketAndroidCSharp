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
            socket = new Socket("10.0.2.2", 8888);
            System.out.println("Connected");
        } catch (IOException e) {

        }

        return null;
    }
}
