package com.example.omarali.aru.project_alarmgame;

import android.content.ComponentName;
import android.content.Context;
import android.content.DialogInterface;
import android.content.Intent;
import android.content.ServiceConnection;
import android.os.Bundle;
import android.os.IBinder;
import android.support.v7.app.AlertDialog;
import android.support.v7.app.AppCompatActivity;
import android.util.Log;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.View.OnClickListener;
import android.view.Window;
import android.view.WindowManager;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.TextView;


public class MainActivity_paper extends AppCompatActivity implements OnClickListener{
    private static final String TAG = "MainActivity";
    TextView lblAICount, lblPlayerCount, lblWinner;
    ImageView imgAI, imgPlayer;
    Button btnRock, btnPaper, btnScissor;


    int AICount = 0, playerCount = 0;
    AlertDialog.Builder endDialog;
    RingtonePlayingService rps;
    boolean mBound = false;


    @Override
    protected void onCreate(Bundle savedInstanceState) {

        final Context context = this;
        AlertDialog.Builder alertDialogBuilder = new AlertDialog.Builder(
                context,R.style.MyDialogTheme);

        //AlertDialog.Builder(this,AlertDialog.)
        alertDialogBuilder.setTitle("       Rock-Paper-Scissors Game");
        alertDialogBuilder
                .setMessage("	Rock-paper-scissors is a hand game usually played between two people, in which each player simultaneously forms one of three shapes with an outstretched hand. These shapes are \"rock\" (a closed fist), \"paper\" (a flat hand), and \"scissors\"" +
                        " (a fist with the index and middle fingers extended, forming a V). " +
                        "\"Scissors\" is identical to the two-fingered V sign (aka \"victory\"" +
                        " or \"peace sign\") except that it is pointed horizontally instead of being held upright in the air. ")
                .setCancelable(false)
                .setPositiveButton("Got it", new DialogInterface.OnClickListener() {
                    public void onClick(DialogInterface dialog, int id) {
                        dialog.cancel();

                    }
                });


        AlertDialog alertDialog = alertDialogBuilder.create();
        alertDialog.show();
        requestWindowFeature(Window.FEATURE_NO_TITLE);
        getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,
                WindowManager.LayoutParams.FLAG_FULLSCREEN);
                super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main_paper);

        imgAI = (ImageView) findViewById(R.id.imgAI);
        imgPlayer = (ImageView) findViewById(R.id.imgPlayer);

        lblAICount = (TextView) findViewById(R.id.lblAICount);
        lblPlayerCount = (TextView) findViewById(R.id.lblPlayerCount);
        lblWinner = (TextView) findViewById(R.id.lblWinner);

        btnRock = (Button) findViewById(R.id.btnRock);
        btnPaper = (Button) findViewById(R.id.btnPaper);
        btnScissor = (Button) findViewById(R.id.btnScissor);

        btnRock.setOnClickListener(this);
        btnPaper.setOnClickListener(this);
        btnScissor.setOnClickListener(this);
        Intent mIntent = new Intent(this, RingtonePlayingService.class);
        bindService(mIntent, mConnection, BIND_AUTO_CREATE);
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        getMenuInflater().inflate(R.menu.level_one, menu);
        return true;
    }

    private ServiceConnection mConnection = new ServiceConnection() {

        @Override
        public void onServiceConnected(ComponentName className,
                                       IBinder service) {
            // We've bound to LocalService, cast the IBinder and get LocalService instance
            RingtonePlayingService.LocalBinder binder = (RingtonePlayingService.LocalBinder) service;
            rps = binder.getService();
            mBound = true;
        }

        @Override
        public void onServiceDisconnected(ComponentName arg0) {
            mBound = false;
        }
    };

    public void onClick(View v) {
        int winner = RPS.DRAW;
        int AIChoice = RPS.generateOuputAI();
        choosePicture(RPS.AI, AIChoice);

        switch (v.getId()) {
            // determine winner
            case R.id.btnRock:
                winner = RPS.getWinner(RPS.ROCK, AIChoice);
                choosePicture(RPS.PLAYER, RPS.ROCK);
                Log.d(TAG, "Rock");
                break;
            case R.id.btnPaper:
                winner = RPS.getWinner(RPS.PAPER, AIChoice);
                choosePicture(RPS.PLAYER, RPS.PAPER);
                Log.d(TAG, "Paper");
                break;
            case R.id.btnScissor:
                winner = RPS.getWinner(RPS.SCISSOR, AIChoice);
                choosePicture(RPS.PLAYER, RPS.SCISSOR);
                Log.d(TAG, "Scissor");
                break;

        }

        if (winner == RPS.PLAYER) {
            playerCount++;
            lblPlayerCount.setText(Integer.toString(playerCount));
            lblWinner.setText(RPS.MSG_PLAYER_WIN);
        } else if (winner == RPS.AI) {
            AICount++;
            lblAICount.setText(Integer.toString(AICount));
            lblWinner.setText(RPS.MSG_AI_WIN);
        } else if (winner == RPS.DRAW) {
            lblWinner.setText(RPS.MSG_DRAW);
        }

        if (playerCount==5){
            lblWinner.setText("Congratulations! You win!");
            endDialog = new AlertDialog.Builder(this);
            endDialog.setCancelable(false);

            endDialog.setPositiveButton("OK", new DialogInterface.OnClickListener() {

                @Override
                public void onClick(DialogInterface dialog, int id) {
                    // End this Activity upon clicking "OK"
                    Intent i = new Intent (MainActivity_paper.this, WelcomeActivity.class);
                    startActivity(i);

                }
            });
            endGame("You Win!", "You completed the activity correctly");//notification window
            rps.stopMusic();
            Intent refresh = new Intent(this, MainActivity.class);
            startActivity(refresh);
        }
    }
    private void endGame(String title, String message) {
        // Set the message and title and display the AlertDialog
        endDialog.setTitle(title);
        endDialog.setMessage(message);
        AlertDialog dialogBox = endDialog.create();
        dialogBox.show();

    }

    public void choosePicture(int player, int choice) {
        lblAICount = (TextView) findViewById(R.id.lblAICount);
        lblPlayerCount = (TextView) findViewById(R.id.lblPlayerCount);

        switch (choice) {
            case RPS.ROCK:
                if (player == RPS.PLAYER)
                   imgPlayer.setImageResource(R.drawable.prock);
                else
                    imgAI.setImageResource(R.drawable.airock);
                break;
            case RPS.PAPER:
                if (player == RPS.PLAYER)
                    imgPlayer.setImageResource(R.drawable.ppaper);
                else
                    imgAI.setImageResource(R.drawable.aipaper);
                break;
            case RPS.SCISSOR:
                if (player == RPS.PLAYER)
                    imgPlayer.setImageResource(R.drawable.pscissor);
                else
                    imgAI.setImageResource(R.drawable.aiscissor);
                break;
        }
    }


    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();

        //noinspection SimplifiableIfStatement
        if (id == R.id.action_settings) {
            return true;
        }

        return super.onOptionsItemSelected(item);
    }
}
