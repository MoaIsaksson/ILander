using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
    private static bool _isGamePaused;
    public GameObject pauseGameUI;

    public void Resume()
    {
        pauseGameUI.SetActive(false);
        Time.timeScale = 1f;
        _isGamePaused = false;
    }

    private void Pause()
    {
        pauseGameUI.SetActive(true);
        Time.timeScale = 0f;
        _isGamePaused = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneBuildIndex: 0);
    }

    public void QuitGame()
    {
        Debug.Log("The Game Has Quit");
        Application.Quit();
    }
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (_isGamePaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
}
