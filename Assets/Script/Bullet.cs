using UnityEngine;
using UnityEngine.InputSystem;

public class Bullet : MonoBehaviour
{
    private Rigidbody bulletRigibody;
    public  float speed = 10f;

    void Awake()
    {
        bulletRigibody = GetComponent<Rigidbody>();
        Destroy(this.gameObject, 5f);
    }
    void Start()
    {
        bulletRigibody.linearVelocity = transform.forward*speed; 
    }
    void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
    }
}
