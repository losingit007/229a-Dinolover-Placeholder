using UnityEngine;

public class Gameover : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameOverMenu gameOverMenu;
    public thirdPersonCamera playerMouse;
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            GameoverMethod();
        }
    }
    public void GameoverMethod()
    {
        gameOverMenu.UpdateGameoverSocre();
        playerMouse.isPaused = true;
        Time.timeScale = 0f;
        gameOverPanel.SetActive(true);
    }
}
