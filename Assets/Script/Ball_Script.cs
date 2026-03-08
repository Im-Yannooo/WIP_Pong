using UnityEngine;

public class Ball_Script : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private Game_Manager GM;
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float initialAngle = 1.0f;
    [SerializeField] private float angleY;
    void Start()
    {
        BallMovement();
    }

    private void BallMovement()
    {
        Vector2 dir = Random.value < 0.5f ? Vector2.left : Vector2.right;
        dir.y = Random.Range(-initialAngle, initialAngle);
        rb.linearVelocity = dir * speed;
    }

    private void ResetBall()
    {
        float positionY = Random.Range(-angleY, angleY);
        Vector2 startPos = new Vector2(0f,positionY);
        transform.position = startPos;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score_Zone_Script SZ = collision.GetComponent<Score_Zone_Script>();

        if (SZ)
        {
            GM.BallReachedToZone(SZ.ID);
            ResetBall();
            BallMovement();
        }
        
    }



}
