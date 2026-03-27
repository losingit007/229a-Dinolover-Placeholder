using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverMenu : MonoBehaviour
{

    public GameObject gameover;
    public ScoreGetSystem scoreGetSystem;
    public TMP_Text scoreText;
    public int totalScore;

    public void UpdateGameoverSocre()
    {
        totalScore = scoreGetSystem.score;
        scoreText.text  = totalScore.ToString();
    }   
    public void Replay()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level 1");
        
    }
    public void LoadMainMenu()
    {    
        SceneManager.LoadScene("MainMenu");
    }
}
