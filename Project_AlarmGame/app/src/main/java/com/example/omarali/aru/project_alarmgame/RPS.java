package com.example.omarali.aru.project_alarmgame;

import java.util.Random;
public class RPS {
    public static final String MSG_PLAYER_WIN = "You Won!";
    public static final String MSG_AI_WIN = "You Lost!";
    public static final String MSG_DRAW = "Draw!";

    public static final int ROCK = 1;
    public static final int PAPER = 2;
    public static final int SCISSOR = 3;
    public static final int DRAW = 0;
    public static final int AI = 1;
    public static final int PLAYER = 2;

    public static int generateOuputAI() {
        Random rand = new Random();
        return rand.nextInt(3) + 1;
    }

    public static int getWinner(int playerChoice, int AIChoice) {
        int winner = DRAW;
        switch(playerChoice) {
            case ROCK:
                if (AIChoice == PAPER)
                    winner = AI;
                else if (AIChoice == SCISSOR)
                    winner = PLAYER;
                break;
            case PAPER:
                if (AIChoice == ROCK)
                    winner = PLAYER;
                else if (AIChoice == SCISSOR)
                    winner = AI;
                break;
            case SCISSOR:
                if (AIChoice == ROCK)
                    winner = AI;
                else if (AIChoice == PAPER)
                    winner = PLAYER;
        }
        return winner;
    }
}
