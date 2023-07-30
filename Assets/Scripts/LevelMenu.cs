using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class LevelMenu : MonoBehaviour
{
    public LevelManager levelManager;
    public GameObject panel2;
    public GameObject panel3;
    public void ContinueGame()
    {
        Time.timeScale = 1.0f;
        levelManager.NextLevel();
        SceneManager.GetActiveScene();
        
        panel2.SetActive(false);
    }
    
    public void restartGame()
    {
        
        levelManager.RestartGame();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
        
        panel3.SetActive(false);
    }

    public void ExitGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
}
