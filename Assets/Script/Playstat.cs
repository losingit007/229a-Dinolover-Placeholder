using UnityEngine;

public class Playstat : MonoBehaviour
{
    public int playerHp;
    public bool isGameOver = false;

    public AudioSource hitObstaceSound;

    public GameObject hitObstacleParticle;
    public Gameover gameOver;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Obstacles"))
        {
            
            if(playerHp <=0 )
            {
                Debug.Log("GameOver");
                gameOver.GameoverMethod();
                isGameOver= true;
            }
            else
            {
                Debug.Log("Player Hit ");
                playerHp--;
                Destroy(collision.gameObject);
                GameObject hitEffect = Instantiate(hitObstacleParticle,transform.position,Quaternion.identity); 
                Destroy(hitEffect.gameObject,2f);
                hitObstaceSound.Play();
            }
        }
        
    }
}
