using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreenCode : MonoBehaviour
{

    public void playGame()
    {
        //change to the game scene
        SceneManager.LoadScene("MainMenu");

    }
      
}
