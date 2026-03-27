using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public GameObject tutorialPanel;
    public void StartGame()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void Tutorial()
    {
        tutorialPanel.SetActive(true);
    }
    public void Back()
    {
        tutorialPanel.SetActive(false);
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting...");
        Application.Quit();
    }
}
