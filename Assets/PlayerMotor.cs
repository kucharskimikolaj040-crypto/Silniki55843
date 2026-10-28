using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.Rendering.DebugUI;

public class PlayerMotor : MonoBehaviour
{
    public float jumpForce = 10.0f;
    public float Acceleration = 10.0f;
    private Rigidbody2D rigidbody2D;
    private Vector2 direction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void FixedUpdate()
    {
        
        rigidbody2D.AddForce(new Vector2(direction.x,0) * Acceleration);


    }

    void OnJump()
    {
        
        rigidbody2D.AddForce(Vector2.up * jumpForce,ForceMode2D.Impulse);
    }    




    void OnMove(InputValue value)
    {
        direction = value.Get<Vector2>();
    }

}
