using UnityEngine;

public class Ball_Script : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float initialAngle = 0.67f;
    void Start()
    {
        BallMovement();
    }

    private void BallMovement()
    {
        // Vector2 dir = Random.value < 0.5f ? Vector2.left : Vector2.right;

        // dir.y  = Random.Range(-initialAngle, initialAngle);
        rb.linearVelocity = Vector2.left * speed;
    }

    private void ResetBall()
    {
        //float posY = Random.Range();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }

}
