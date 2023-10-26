using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public Transform GroundCheck;
    public LayerMask groundLayer;
    private Rigidbody2D rb;

    void Start()
    {
        
        rb = this.GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        //movement
        Vector2 movementVector = new Vector2();
        
        bool grounded = Physics2D.OverlapCircle(GroundCheck.position, 2f, groundLayer) != null;
        
        movementVector.x = Input.GetAxis("Horizontal") * speed;

       

        //jump
        if(Input.GetButtonDown("Jump") && grounded)
        {

            //Debug.Log("Test");
            movementVector.y = jumpForce;

        }

        rb.AddForce(movementVector);

    }
}
