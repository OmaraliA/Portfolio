package com.example.omarali.aru.project_alarmgame;

import android.app.Activity;
import android.app.AlertDialog;
import android.content.Context;
import android.content.DialogInterface;
import android.content.Intent;
import android.os.Bundle;
import android.view.Menu;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;

public class sudoku extends Activity implements OnClickListener{
	// Level 1 and Level 2 buttons
	Button btn_level_1, btn_level_2;


	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main_sudo);
		
		btn_level_1 = (Button)findViewById(R.id.btn_level_1);
		btn_level_2 = (Button)findViewById(R.id.btn_level_2);
		
		btn_level_1.setOnClickListener(this);
		btn_level_2.setOnClickListener(this);
		final Context context = this;
		AlertDialog.Builder alertDialogBuilder = new AlertDialog.Builder(
				context,R.style.MyDialogTheme);


		//AlertDialog.Builder(this,AlertDialog.)
		alertDialogBuilder.setTitle("       Sudoku Game");
		alertDialogBuilder
				.setMessage("	Sudoku is a puzzle game designed for a single player, much like a crossword puzzle. The puzzle itself is nothing more than a grid of little boxes called “cells”. ")
				.setCancelable(false)
				.setPositiveButton("Got it", new DialogInterface.OnClickListener() {
					public void onClick(DialogInterface dialog, int id) {
						dialog.cancel();

					}
				});


		AlertDialog alertDialog = alertDialogBuilder.create();
		alertDialog.show();
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		getMenuInflater().inflate(R.menu.main, menu);
		return true;
	}
	
	@Override
	public void onClick(View v) {
		Intent intent;
		switch (v.getId()) {
			// Change page to according to the buttton press
			case R.id.btn_level_1:
				intent = new Intent(getBaseContext(), LevelOne.class);
				startActivity(intent);
				break;
			case R.id.btn_level_2:
				intent = new Intent(getBaseContext(), LevelTwo.class);
				startActivity(intent);
				break;
		}
	}
}
