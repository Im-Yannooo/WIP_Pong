using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int scorePlayer1, scorePlayer2;
    public ScoreText scoreText_L, scoreText_R;

    public void OnScoreZoneReached(int id)
    {
        if(id == 1) scorePlayer1++;
        if(id == 2) scorePlayer2++;

        UpdateScores();
    }

    private void UpdateScores()
    {
        scoreText_L.setScore(scorePlayer1);
        scoreText_R.setScore(scorePlayer2);
    }
}
