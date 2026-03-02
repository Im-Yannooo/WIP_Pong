using UnityEngine;

public class Score_Zone_Script : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Debug.Log("SCORE");
        }
    }
}
