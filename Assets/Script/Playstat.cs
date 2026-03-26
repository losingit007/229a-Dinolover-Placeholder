using UnityEngine;

public class Playstat : MonoBehaviour
{
    public int playerHp;
    public bool isGameOver = false;

    public AudioClip hitObstaceSound;

    public ParticleSystem hitObstacleParticle;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Obstacle"))
        {
            
            if(playerHp <=0 )
            {
                Debug.Log("GameOver");
                isGameOver= true;
            }
            else
            {
                Debug.Log("Player Hit ");
                playerHp--;
            }
        }
        
    }
}
