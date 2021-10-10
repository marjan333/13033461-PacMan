using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class InputManger : MonoBehaviour
{
    public void Exit() {
         if (GameManager.currentGameState == GameManager.GameState.PacMan)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
}
