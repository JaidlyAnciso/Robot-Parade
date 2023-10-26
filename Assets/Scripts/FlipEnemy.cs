using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipEnemy : MonoBehaviour
{

    void Start()
    {
        print("OK");
    }
    
    private void OnTriggerEnter2D(Collider2D enemy)
    {
        print("hello world");
        if (enemy.tag == "Enemy")

        {
           
            enemy.transform.Rotate(0f, 180f, 0f);
        }
    }
}