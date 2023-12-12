using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lvl1to2 : MonoBehaviour
{

    public void OnTriggerEnter2D(Collider2D collision)
    {
        
        SceneManager.LoadScene("Game2");

    }
      
}

