package com.example.omarali.aru.project_alarmgame;

import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.util.Log;



public class AlarmReceiver extends BroadcastReceiver {

    @Override
    public void onReceive(Context context, Intent intent) {
        String state = intent.getExtras().getString("extra");
        Integer time = intent.getIntExtra("time",0);
        Integer timeMinute = intent.getIntExtra("timeMinute",0);
        //Integer levels = intent.getExtras().getInt("selection");
        Integer levels = intent.getIntExtra("selection",0);

        Log.e("MyActivity", "In the receiver with " + state + levels);
        Log.e("Clock time", " " + time + timeMinute);
        Intent serviceIntent = new Intent(context,RingtonePlayingService.class);
        serviceIntent.putExtra("extra", state);
        serviceIntent.putExtra("selection",levels);
        serviceIntent.putExtra("time",time);
        serviceIntent.putExtra("timeMinute",timeMinute);
        context.startService(serviceIntent);




    }
}
