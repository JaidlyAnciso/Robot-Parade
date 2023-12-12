using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{

    public void Restartgame()
    {
        //change to the game scene
        SceneManager.LoadScene("Game");

    }
      
}