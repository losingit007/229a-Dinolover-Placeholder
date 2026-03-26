using UnityEditor;
using UnityEngine;

public class Target : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        
        Bullet  hit = other.GetComponent<Bullet>();
        if(hit != null)
        {
            Destroy(this.gameObject);
        }
    }
}
