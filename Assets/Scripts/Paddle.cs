using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private int id;
    [SerializeField] private float moveSpeed = 2f;

    private void Update()
    {   
        float movement = ProcessInput();
        Move(movement);
    }

    private float ProcessInput()
    {
        float movement = 0f;
        switch (id)
        {
            case 1:
                movement = Input.GetAxis("MovePlayer1");
                break;
            case 2:
                movement = Input.GetAxis("MovePlayer2");
                break;
        }
        
        return movement;
    }

    private void Move(float movement)
    {
        rb.linearVelocityY = movement * moveSpeed;
    }
}
