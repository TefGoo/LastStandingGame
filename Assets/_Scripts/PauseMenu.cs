using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject pauseMenuPanel1;
    public GameObject pauseMenuPanel2;

    void Start()
    {
        // Ensure all panels are deactivated at the start
        pauseMenuUI.SetActive(false);
        pauseMenuPanel1.SetActive(false);
        pauseMenuPanel2.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        pauseMenuPanel1.SetActive(true);
        pauseMenuPanel2.SetActive(false); // Ensure panel2 is hidden when paused
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ReturnToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu"); // Ensure you have a scene named "MainMenu"
    }

    public void SwitchToPanel2()
    {
        pauseMenuPanel1.SetActive(false);
        pauseMenuPanel2.SetActive(true);
    }

    public void ReturnToPanel1()
    {
        pauseMenuPanel2.SetActive(false);
        pauseMenuPanel1.SetActive(true);
    }
}
