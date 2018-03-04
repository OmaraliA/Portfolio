package com.example.omarali.aru.project_alarmgame;

import android.annotation.TargetApi;
import android.app.AlarmManager;
import android.app.Notification;
import android.app.NotificationManager;
import android.app.PendingIntent;
import android.content.Context;
import android.content.DialogInterface;
import android.content.Intent;
import android.os.Build;
import android.os.Bundle;
import android.support.annotation.RequiresApi;
import android.support.v7.app.AlertDialog;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.app.NotificationCompat;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;
import android.widget.TimePicker;
import android.widget.Toast;

import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.Random;
import java.util.Timer;
import java.util.TimerTask;

public class MainActivity extends AppCompatActivity {

    AlarmManager alarmManager;
    private PendingIntent pending_intent;

    private TimePicker alarmTimePicker;
    private TextView alarmTextView;

    private AlarmReceiver alarm;
    RingtonePlayingService rps;
    boolean mBound = false;
    int level,diff_hours,diff_minute;
    int hour,minute;
    int time,timeMinute;
    MainActivity inst;
    Context context;
    Intent myIntent;
    int timeDiff;
    Button stop_alarm;
    NotificationManager notificationManager;
    NotificationManager notate;
    Notification mNotifyAlarm;
    Timer updateTimer;

    // private final IBinder mBinder = new LocalBinder();


    @RequiresApi(api = Build.VERSION_CODES.JELLY_BEAN)
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        this.context = this;
        alarmTextView = (TextView) findViewById(R.id.alarmText);
       myIntent = new Intent(this.context, AlarmReceiver.class);
        final Intent newIntent = new Intent(this.context, AlarmReceiver.class);
        alarmManager = (AlarmManager) getSystemService(ALARM_SERVICE);

        final Calendar calendar = Calendar.getInstance();
       stop_alarm = (Button) findViewById(R.id.stop_alarm);
        stop_alarm.setEnabled(false);

        alarmTimePicker = (TimePicker) findViewById(R.id.alarmTimePicker);
         notate = (NotificationManager)
                getSystemService(NOTIFICATION_SERVICE);
        Calendar currentTime = Calendar.getInstance();
        SimpleDateFormat format = new SimpleDateFormat("hh:mm");
       final int hours = currentTime.get(Calendar.HOUR_OF_DAY);
       final int min = currentTime.get(Calendar.MINUTE);


        Button start_alarm = (Button) findViewById(R.id.start_alarm);
        start_alarm.setOnClickListener(new View.OnClickListener() {
            @TargetApi(Build.VERSION_CODES.M)

            @Override
            public void onClick(View v) {

                calendar.add(Calendar.SECOND, 3);
                //setAlarmText("You clicked a button");

                hour = alarmTimePicker.getCurrentHour();
                minute = alarmTimePicker.getCurrentMinute();


                if (hour >=  hours && minute >= min) {
                   // notificationManager.cancelAll();

                    //updateTimer.cancel();


                    setAlarmText("You clicked a " + hour + " and " + minute);
                    calendar.set(Calendar.HOUR_OF_DAY, alarmTimePicker.getCurrentHour());
                    calendar.set(Calendar.MINUTE, alarmTimePicker.getCurrentMinute());

                    myIntent.putExtra("extra", "yes");
                    myIntent.putExtra("time", hour);
                    myIntent.putExtra("timeMinute", minute);
                    Log.e("Clockkkk", " " + hour + minute);

                    pending_intent = PendingIntent.getBroadcast(MainActivity.this, 0, myIntent, PendingIntent.FLAG_UPDATE_CURRENT);
                    alarmManager.set(AlarmManager.RTC_WAKEUP, calendar.getTimeInMillis(), pending_intent);

                    setAlarmText("Alarm set to " + hour + ":" + minute);
                    stop_alarm.setEnabled(true);
                    updateTimer = new Timer();
                    updateTimer.schedule(new TimerTask() {
                        public void run() {

                            //Date date1 = format.parse(hour+":"+ minute);

                            Log.e("Difference ", hours + ":" + min);
                            Log.e("Difference ", hour + ":" + minute);
                            //Date date2 = format.parse("05:30");

                            diff_hours = hour - hours;
                            diff_minute = minute - min;
                            Log.e("Difference is ", diff_hours + ":" + diff_minute);


                            notificationManager = (NotificationManager) context.getSystemService(Context.NOTIFICATION_SERVICE);

                            Notification notification = new NotificationCompat.Builder(context)
                                    .setContentTitle("Alarm Notification")
                                    .setContentText("will be clocked after " + " " + diff_hours + " " + " hours and " + diff_minute + " minute")
                                    .setSmallIcon(R.drawable.clock)
                                    .setContentIntent(pending_intent)
                                    .setWhen(System.currentTimeMillis() + 5000)
                                    .build();

                            notificationManager.notify(0, notification);

                            if (diff_minute == 0 && diff_hours == 0) {
                                notificationManager.cancelAll();
                                //updateTimer.cancel();
                            }


                        }


                    }, 0, 5000);
                }
                else {
                    Toast.makeText(getApplicationContext(), "Time is up, you cannot set alarm! ",
                            Toast.LENGTH_SHORT).show();
                }
            }


        });



        stop_alarm.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                int min = 1;
                int max = 9;

                Random r = new Random();
                int random_number = r.nextInt(max - min + 1) + min;
                Log.e("random number is ", String.valueOf(random_number));


             //   myIntent.putExtra("extra", "no");

              //  sendBroadcast(newIntent);

             //   sendBroadcast(myIntent);

                alarmManager.cancel(pending_intent);
                setAlarmText("Alarm canceled");
                notificationManager.cancelAll();
                updateTimer.cancel();
                //selectLevel(v);
                //rps.stopMusic();
                //startActivity(getIntent());




                //setAlarmText("You clicked a " + " canceled");
            }
        });



    }

   /* private ServiceConnection mConnection = new ServiceConnection() {

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


    public class LocalBinder extends Binder {
        public MainActivity getService() {
            return MainActivity.this;
        }
    }*/

    public void setAlarmText(String alarmText) {
        alarmTextView.setText(alarmText);
    }

    public void selectLevel(View view) {
        final CharSequence[] items = {" Easy "," Medium "," Hard "};
// arraylist to keep the selected items
        final ArrayList seletedItems = new ArrayList();

        AlertDialog dialog = new AlertDialog.Builder(this)
                .setTitle("Select The Difficulty Level")
                .setMultiChoiceItems(items, null, new DialogInterface.OnMultiChoiceClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int indexSelected, boolean isChecked) {
                        if (isChecked) {
                            // If the user checked the item, add it to the selected items
                            seletedItems.add(indexSelected);
                            level = Integer.valueOf(indexSelected);
                          //  Toast.makeText(getApplicationContext()," " +level,
                                //    Toast.LENGTH_SHORT).show();

                        } else if (seletedItems.contains(indexSelected)) {
                        }
                    }
                }).setPositiveButton("OK", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int id) {



                        // myIntent.putExtra( "sid);
                          Bundle b = new Bundle();
                        myIntent.putExtra("selection",level);

                       // myIntent.putExtras(b);



                    }
                }).setNegativeButton("Cancel", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int id) {
                        //  Your code when user clicked on Cancel
                    }
                }).create();
        dialog.show();

    }

    @Override
    public void onStart() {
        super.onStart();
        inst = this;
    }

    @Override
    public void onDestroy() {
        super.onDestroy();

        Log.e("MyActivity", "on Destroy");
    }
}