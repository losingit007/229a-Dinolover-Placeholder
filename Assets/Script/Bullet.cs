using UnityEngine;
using UnityEngine.InputSystem;

public class Bullet : MonoBehaviour
{
    private Rigidbody bulletRigibody;

    void Awake()
    {
        bulletRigibody = GetComponent<Rigidbody>();
        
    }
    void Start()
    {
        float speed = 10f;
        bulletRigibody.linearVelocity = transform.forward*speed; 
    }
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
