using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class PauseMenu : MonoBehaviour
{
    public GameObject pausePanel;
    public GameObject tutorialPanel;
    private bool isPaused = false;
    
    public thirdPersonCamera playerMouse;

    void Start()
    {
        pausePanel.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            TogglePause();
    }
    public void Tutorial()
    {
        tutorialPanel.SetActive(true);
    }
    public void Back()
    {
        tutorialPanel.SetActive(false);
    }
    public void TogglePause()
    {
        isPaused = !isPaused;
        playerMouse.isPaused = !playerMouse.isPaused;
        pausePanel.SetActive(isPaused);
        Time.timeScale = isPaused ? 0f : 1f;
    }
    public void Resume()
    {
        Debug.Log("resume Press");
        playerMouse.isPaused = false;
        isPaused = false;
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
    }
    public void LoadMainMenu()
    {
        Time.timeScale = 1f;           
        SceneManager.LoadScene("MainMenu");
    }
}
