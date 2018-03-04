package com.example.omarali.aru.project_alarmgame;

import android.content.Intent;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.TextView;

import com.daimajia.androidanimations.library.Techniques;
import com.daimajia.androidanimations.library.YoYo;

public class WelcomeActivity extends AppCompatActivity {
    String level;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_welcome);

        TextView text = (TextView)findViewById(R.id.textView);
        YoYo.with(Techniques.Wobble)
                .duration(800)
                .repeat(10000)
                .playOn(text);
    }


    public void addAlarm(View view) {

        Intent i = new Intent (WelcomeActivity.this,MainActivity.class);
        startActivity(i);
    }
    public void viewList(View view) {
        Intent i = new Intent (WelcomeActivity.this,MainActivity.class);
        startActivity(i);
    }

}
