using System;
using UnityEngine;

public class Game_Manager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] private int P1, P2;
    [SerializeField] private Score_Text P1_Score, P2_Score;
    
    public void BallReachedToZone(int id)
    {
        if(id == 1) P1++;
        if(id == 2) P2++;

        UpdateScore();
    }

    private void UpdateScore()
    {
        P1_Score.setScore(P1);
        P2_Score.setScore(P2);
    }

    
}
