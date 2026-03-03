using UnityEngine;using UnityEngine.UIElements;

public class Paddle : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed = 2f;
    // Update is called once per frame
    private void FixedUpdate()
    {
        Movement();
    }

    private void Movement()
    {
        float posY = Input.GetAxis("Vertical");
        rb.linearVelocityY = posY * speed;
    }
}
