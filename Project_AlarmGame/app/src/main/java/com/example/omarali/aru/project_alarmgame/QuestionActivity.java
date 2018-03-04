package com.example.omarali.aru.project_alarmgame;

import android.annotation.SuppressLint;
import android.annotation.TargetApi;
import android.app.Activity;
import android.app.AlertDialog;
import android.content.ComponentName;
import android.content.Context;
import android.content.DialogInterface;
import android.content.Intent;
import android.content.ServiceConnection;
import android.os.Build;
import android.os.Bundle;
import android.os.CountDownTimer;
import android.os.IBinder;
import android.support.annotation.RequiresApi;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import java.util.List;
import java.util.concurrent.TimeUnit;


public class QuestionActivity extends Activity {
    List<Question> quesList;
    int score = 0;
    int qid = 0;


    Question currentQ;
    TextView txtQuestion, times, scored,txtScore;
    Button button1, button2, button3;
    RingtonePlayingService rps;
    boolean mBound = false;
    AlertDialog.Builder endDialog;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main_math);
        final Context context = this;
        AlertDialog.Builder alertDialogBuilder = new AlertDialog.Builder(
                context,R.style.MyDialogTheme);
       // TextView messageText = (TextView)alertDialogBuilder.findViewById(android.R.id.message);
        //messageText.setGravity(Gravity.CENTER);

        //AlertDialog.Builder(this,AlertDialog.)
        alertDialogBuilder.setTitle("      Math Quiz Game");
        alertDialogBuilder
                .setMessage("   In this activity user should answer to the math questions. There will be simple addition and subtraction. If the user answers to the all 21 questions then user can stop the alarm. Else if user make a mistake then user must start this activity again. ")
                .setCancelable(false)

                .setPositiveButton("Got it", new DialogInterface.OnClickListener() {
                    public void onClick(DialogInterface dialog, int id) {
                        dialog.cancel();

                    }
                });


        AlertDialog alertDialog = alertDialogBuilder.create();
        alertDialog.show();

        QuizHelper db = new QuizHelper(this);
        quesList = db.getAllQuestions();
        currentQ = quesList.get(qid);

        txtQuestion = (TextView) findViewById(R.id.txtQuestion);
        button1 = (Button) findViewById(R.id.button1);
        button2 = (Button) findViewById(R.id.button2);
        button3 = (Button) findViewById(R.id.button3);

       // rps.startMusic();



        scored = (TextView) findViewById(R.id.score);


        times = (TextView) findViewById(R.id.timers);
       txtScore= (TextView) findViewById(R.id.txtScore);

        setQuestionView();
        times.setText("00:02:00");


        CounterClass timer = new CounterClass(60000, 1000);
        timer.start();





        button1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {


                getAnswer(button1.getText().toString());
            }
        });

        button2.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                getAnswer(button2.getText().toString());
            }
        });

        button3.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                getAnswer(button3.getText().toString());
            }
        });

        Intent mIntent = new Intent(this, RingtonePlayingService.class);
        bindService(mIntent, mConnection, BIND_AUTO_CREATE);
    }

    private ServiceConnection mConnection = new ServiceConnection() {

        @RequiresApi(api = Build.VERSION_CODES.JELLY_BEAN)
        @Override
        public void onServiceConnected(ComponentName className,
                                       IBinder service) {
            // We've bound to LocalService, cast the IBinder and get LocalService instance
            RingtonePlayingService.LocalBinder binder = (RingtonePlayingService.LocalBinder) service;
            rps = binder.getService();
           // rps.startMusic();
            mBound = true;
        }

        @Override
        public void onServiceDisconnected(ComponentName arg0) {
            mBound = false;
        }
    };
    public void getAnswer(String AnswerString) {
        if (currentQ.getANSWER().equals(AnswerString)) {


            score++;
            scored.setText("Score : " + score);
        } else {



            Intent intent = new Intent(QuestionActivity.this,
                    ResultActivity.class);


            Bundle b = new Bundle();
            b.putInt("score", score);
            intent.putExtras(b);
            startActivity(intent);
            finish();
        }
        if (qid < 21) {


            currentQ = quesList.get(qid);
            setQuestionView();
        } else {


            // Intent intent = new Intent(QuestionActivity.this,won.class);
            // Bundle b = new Bundle();
            // b.putInt("score",score);
            // intent.putExtras(b);
            // startActivity(intent);

            txtScore.setText("FINAL SCORE:" + score);

            endDialog = new AlertDialog.Builder(this);
            endDialog.setCancelable(false);

            endDialog.setPositiveButton("OK", new DialogInterface.OnClickListener() {

                @Override
                public void onClick(DialogInterface dialog, int id) {
                    // End this Activity upon clicking "OK"
                   Intent i = new Intent(QuestionActivity.this, WelcomeActivity.class);
                    startActivity(i);
                    //Intent refresh = new Intent(QuestionActivity.this, MainActivity.class);
                    //startActivity(refresh);

                }
            });
            endGame("You Win!", "You completed the quiz correctly");//notification window

            rps.stopMusic();

        }

    }
    private void endGame(String title, String message) {
        // Set the message and title and display the AlertDialog
        endDialog.setTitle(title);
        endDialog.setMessage(message);
        AlertDialog dialogBox = endDialog.create();
        dialogBox.show();
    }


    @TargetApi(Build.VERSION_CODES.GINGERBREAD)
    @SuppressLint("NewApi")
    public class CounterClass extends CountDownTimer {

        public CounterClass(long millisInFuture, long countDownInterval) {
            super(millisInFuture, countDownInterval);
            // TODO Auto-generated constructor stub
        }


        @Override
        public void onFinish() {
            times.setText("Time is up");

        }

      @Override
        public void onTick(long millisUntilFinished) {
            // TODO Auto-generated method stub

            long millis = millisUntilFinished;
            String hms = String.format(
                    "%02d:%02d:%02d",
                    TimeUnit.MILLISECONDS.toHours(millis),
                    TimeUnit.MILLISECONDS.toMinutes(millis)
                            - TimeUnit.HOURS.toMinutes(TimeUnit.MILLISECONDS
                            .toHours(millis)),
                    TimeUnit.MILLISECONDS.toSeconds(millis)
                            - TimeUnit.MINUTES.toSeconds(TimeUnit.MILLISECONDS
                            .toMinutes(millis)));
            System.out.println(hms);
            times.setText(hms);
        }


    }

    private void setQuestionView() {

        // the method which will put all things together
        txtQuestion.setText(currentQ.getQUESTION());
        button1.setText(currentQ.getOPTA());
        button2.setText(currentQ.getOPTB());
        button3.setText(currentQ.getOPTC());

        qid++;
    }


}

