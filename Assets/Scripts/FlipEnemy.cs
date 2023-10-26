using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipEnemy : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D enemy)
    {
        if(enemy.tag == "Enemy")
        {
            print("hello world");
            enemy.transform.Rotate(0f, 180f, 0f);
        }
    }
}