using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private Rigidbody2D rb;
    
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        Vector2 movementVector = new Vector2();


        movementVector.x = Input.GetAxis("Horizontal") * speed;

    {
        
        movementVector.y = jumpForce;
    }
    if(movementVector.x < 0) {
        this.gameObject.transform.localScale = new Vector3(-1f, 1f, 1f);
    } else{
        this.gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
    }


        rb.AddForce(movementVector);
    }
}
