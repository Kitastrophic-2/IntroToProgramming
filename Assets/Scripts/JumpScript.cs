using JetBrains.Annotations;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;

public class JumpScript : MonoBehaviour
{
    public Vector3 direction;
    public float speed = 10f;
    public Rigidbody2D myRB;
    public float jumpForce = 100f;
    public bool isGrounded;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        isGrounded = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        direction = Vector3.zero;
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            direction += Vector3.left;
        }
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            direction += Vector3.right;
        }

        direction = direction * speed;
        direction.y = myRB.linearVelocity.y;
        myRB.linearVelocity = direction;

        if (Keyboard.current.spaceKey.isPressed && isGrounded)
        {
            myRB.AddForce(Vector3.up * jumpForce);
        }

    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Grounded")
        {
            isGrounded = false;

        }
    }
}
