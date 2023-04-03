using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

    public void QuitGame()
    {
        Debug.Log("Exited the game!");
        Application.Quit();
    }

    public void HowToPlayButton()
    {
        SceneManager.LoadScene(5);
        
    }
    public void ReturnToMainMenu()
    {
       
        SceneManager.LoadScene(0);//sahne sayýsý
        
    }
  
    public void LevelButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void AgainButton()
    {
        SceneManager.LoadScene(0);
    }

    





}
