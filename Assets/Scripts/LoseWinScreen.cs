using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseWinScreen : MonoBehaviour
{
    public GameObject losescreenUI;
    public GameObject winscreenUI;

    public void LoseGame()
    {
        losescreenUI.SetActive(true);
    }

    public void WinGame()
    {
        winscreenUI.SetActive(true);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void RestartGame()
    {
        Debug.Log("prest");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame()
    {
        Debug.Log("Game has Quit");
        Application.Quit();
    }

  
}
