using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject GameOverScreen;

   
    [ContextMenu("Increase score")]
    public void addScore( int scoreToAdd)
    {
         playerScore = playerScore + scoreToAdd;
         scoreText.text= playerScore.ToString();     
    }
    
    public void GameRest()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    public void GameOver()
    {
        GameOverScreen.SetActive(true);
    }

    public void GameQuit()
    {
          Application.Quit();   
    }
}
