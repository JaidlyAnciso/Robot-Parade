using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillyMovement : MonoBehaviour
{
    public float speed;
    public Transform groundCheck;
    public LayerMask groundLayer;
    private Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movementVector = new Vector2();

        bool grounded = Physics2D.OverlapCircle(groundCheck.position, 2f, groundLayer) != null;

        movementVector.x = Input.GetAxis("Horizontal") * speed;

        
        if (movementVector.x < 0)
        {
            this.gameObject.transform.localScale = new Vector3(-.7f, .7f, .7f);
        }
        else
        {
            this.gameObject.transform.localScale = new Vector3(.7f, .7f, .7f);
        }

       


        rb.AddForce(movementVector);
    }
}
