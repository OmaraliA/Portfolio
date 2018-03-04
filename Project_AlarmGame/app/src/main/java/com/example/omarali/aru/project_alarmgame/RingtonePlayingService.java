package com.example.omarali.aru.project_alarmgame;

import android.app.Notification;
import android.app.NotificationManager;
import android.app.PendingIntent;
import android.app.Service;
import android.content.Context;
import android.content.Intent;
import android.content.ServiceConnection;
import android.media.MediaPlayer;
import android.os.Binder;
import android.os.Build;
import android.os.IBinder;
import android.support.annotation.RequiresApi;
import android.util.Log;

import java.util.Random;



public class RingtonePlayingService extends Service {

    private boolean isRunning;
    private Context context;
    MediaPlayer mMediaPlayer;
    private int startId;
    int count = 0;
    int levels;
    int time,timeMinute;
    String state;

    private final IBinder mBinder = new LocalBinder();
    public void stopMusic(){

        mMediaPlayer.pause();
    }

    public void startMusic(){

        int min = 1;
        int max = 9;
        int maxPlayTime=1000;
        Random r = new Random();
        int random_number = r.nextInt(max - min + 1) + min;


        if (random_number == 1) {
            mMediaPlayer = MediaPlayer.create(this, R.raw.first);
        }
        else if (random_number == 2) {
            mMediaPlayer = MediaPlayer.create(this, R.raw.second);
        }
        else if (random_number == 3) {
            mMediaPlayer = MediaPlayer.create(this, R.raw.third);
        }
        else if (random_number == 4) {
            mMediaPlayer = MediaPlayer.create(this, R.raw.fourth);
        }
        else if (random_number == 5) {
            mMediaPlayer = MediaPlayer.create(this, R.raw.fourth);
        }
        else if (random_number == 6) {
            mMediaPlayer = MediaPlayer.create(this, R.raw.sixth);
        }
        else if (random_number == 7) {
            mMediaPlayer = MediaPlayer.create(this, R.raw.seventh);
        }
        else if (random_number == 8) {
            mMediaPlayer = MediaPlayer.create(this, R.raw.first);
        }
        else if (random_number == 9) {
            mMediaPlayer = MediaPlayer.create(this, R.raw.second);
        }
        else {
            mMediaPlayer = MediaPlayer.create(this, R.raw.fourth);
        }
        //mMediaPlayer = MediaPlayer.create(this, R.raw.richard_dawkins_1);

         /*   mMediaPlayer.setOnCompletionListener(new MediaPlayer.OnCompletionListener() {
                int maxCount = 3;

                @Override
                public void onCompletion(MediaPlayer mp) {
                    if (count < maxCount) {
                        count++;
                        mp.seekTo(0);
                        mp.start();
                    }
                }
            });*/
        mMediaPlayer.start();
        mMediaPlayer.setLooping(true);

    }




    public class LocalBinder extends Binder {
        public RingtonePlayingService getService() {
            return RingtonePlayingService.this;
        }
    }


    @Override
    public IBinder onBind(Intent intent) {
        return mBinder;
    }
    @RequiresApi(api = Build.VERSION_CODES.JELLY_BEAN)
    @Override
    public int onStartCommand(Intent intent, int flags, int startId)
    {

        final NotificationManager mNM = (NotificationManager)
                getSystemService(NOTIFICATION_SERVICE);

        Intent intent1 = new Intent(this.getApplicationContext(), MainActivity.class);
      //  int v= intent1.getIntExtra("selection",0);
        PendingIntent pIntent = PendingIntent.getActivity(this, 0, intent1, 0);

        state = intent.getExtras().getString("extra");
        time = intent.getIntExtra("time",2);
        timeMinute = intent.getIntExtra("timeMinute",0);
        Log.e("MyActivity", "Alarm time " + time + timeMinute);
       // Log.e("MyActivity", "Test " + state + levels);
       // int levels = b.getInt("Integer");

       // String state = intent.getExtras().getString("extra");

        Intent i;
       // i = new Intent (this, sudoku.class);
        //startActivity(i);



        Notification mNotify  = new Notification.Builder(this)
                .setContentTitle("Alarm is on....." + "!")
                .setContentText("Click me!")
                .setSmallIcon(R.drawable.clock)
                .setContentIntent(pIntent)
                .setAutoCancel(true)
                .build();

        //levels = intent.getExtras().getInt("selection");
       /* if (state.equals("0")){
            Toast.makeText(getApplicationContext(),state.toString(),
                    Toast.LENGTH_SHORT).show();
        }*/



        Log.e("what is going on here  ", state);

        assert state != null;
        switch (state) {
            case "no":
                startId = 0;
                break;
            case "yes":
                startId = 1;
                break;
            default:
                startId = 0;
                break;
        }


        if(!this.isRunning && startId == 1) {
            Log.e("if there was not sound ", " and you want start");
            levels = intent.getIntExtra("selection",1);


            int min = 1;
            int max = 9;
            int maxPlayTime=1000;
            Random r = new Random();
            int random_number = r.nextInt(max - min + 1) + min;


            if (random_number == 1) {
                mMediaPlayer = MediaPlayer.create(this, R.raw.first);
            }
            else if (random_number == 2) {
                mMediaPlayer = MediaPlayer.create(this, R.raw.second);
            }
            else if (random_number == 3) {
                mMediaPlayer = MediaPlayer.create(this, R.raw.third);
            }
            else if (random_number == 4) {
                mMediaPlayer = MediaPlayer.create(this, R.raw.fourth);
            }
            else if (random_number == 5) {
                mMediaPlayer = MediaPlayer.create(this, R.raw.fourth);
            }
            else if (random_number == 6) {
                mMediaPlayer = MediaPlayer.create(this, R.raw.sixth);
            }
            else if (random_number == 7) {
                mMediaPlayer = MediaPlayer.create(this, R.raw.seventh);
            }
            else if (random_number == 8) {
                mMediaPlayer = MediaPlayer.create(this, R.raw.second);
            }
            else if (random_number == 9) {
                mMediaPlayer = MediaPlayer.create(this, R.raw.second);
            }
            else {
                mMediaPlayer = MediaPlayer.create(this, R.raw.fourth);
            }
            //mMediaPlayer = MediaPlayer.create(this, R.raw.richard_dawkins_1);

         /*   mMediaPlayer.setOnCompletionListener(new MediaPlayer.OnCompletionListener() {
                int maxCount = 3;

                @Override
                public void onCompletion(MediaPlayer mp) {
                    if (count < maxCount) {
                        count++;
                        mp.seekTo(0);
                        mp.start();
                    }
                }
            });*/
            mMediaPlayer.start();
            mMediaPlayer.setLooping(true);
            Log.e("MyActivity", "Okkkk " + state + levels);
            if (String.valueOf(levels).equals("0")){
                i = new Intent (this, QuestionActivity.class);
                startActivity(i);
            }
            else if (String.valueOf(levels).equals("1")) {
                i = new Intent (this, MainActivity_paper.class);
                startActivity(i);

            }
            else if (String.valueOf(levels).equals("2")) {
                i = new Intent (this, sudoku.class);
                startActivity(i);
            }

            else if (String.valueOf(levels).equals(" ")) {
                i = new Intent (this, sudoku.class);
                startActivity(i);
            }

            mNM.notify(0, mNotify);


                this.isRunning = true;
                this.startId = 0;


        }
        else if (!this.isRunning && startId == 0){
            Log.e("if there was not sound ", " and you want end");

            this.isRunning = false;
            this.startId = 0;

        }

        else if (this.isRunning && startId == 1){
            Log.e("if there is sound ", " and you want start");

            this.isRunning = true;
            this.startId = 0;

        }
        else {
            Log.e("if there is sound ", " and you want end");

            mMediaPlayer.stop();
            mMediaPlayer.reset();

            this.isRunning = false;
            this.startId = 0;
        }


        Log.e("MyActivity", "In the service");

        return START_NOT_STICKY;

    }


    @Override
    public void onDestroy() {
        Log.e("JSLog", "on destroy called");
        super.onDestroy();
        this.isRunning = false;
    }


    @Override
    public boolean bindService(Intent service, ServiceConnection conn, int flags) {

        return super.bindService(service, conn, flags);
    }
}

