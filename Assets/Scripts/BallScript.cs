using UnityEngine;

public class BallScript : MonoBehaviour
{
    [SerializeField] public GameManager gameManager;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] float maxInitialAngle = 0.67f;
    [SerializeField] private float speed;
    [SerializeField] private float maxStartY;
    private float startX = 0f;
    

    private void Start()
    {
        InitialPush();
    }

    private void InitialPush()
    {
        Vector2 dir = Random.value < 0.5f ? Vector2.left : Vector2.right;
        
        dir.y = Random.Range(-maxInitialAngle, maxInitialAngle);
        rb.linearVelocity = dir * speed;
    }

    private void ResetBall()
    {
        float posY = Random.Range(-maxStartY, maxStartY);
        Vector2 position = new Vector2(startX, posY);
        transform.position = position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        ScoreZone scoreZone = collision.GetComponent<ScoreZone>();

        if (scoreZone)
        {
            gameManager.OnScoreZoneReached(scoreZone.id);
            ResetBall();
            InitialPush();
        }

    }
}
