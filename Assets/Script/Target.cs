using UnityEditor;
using UnityEngine;

public class Target : MonoBehaviour
{
    public ScoreGetSystem getScore;
    void OnTriggerEnter(Collider other)
    {
        
        Bullet  hit = other.GetComponent<Bullet>();
        if(hit != null)
        {
            getScore.UpdateUI();
            Destroy(this.gameObject);
        }
    }
}
