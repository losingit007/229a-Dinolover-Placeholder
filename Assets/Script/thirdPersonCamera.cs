using UnityEngine;

public class thirdPersonCamera : MonoBehaviour
{
    [Header("References")]
    public Transform orientation;
    public Transform player;
    public Transform playerObj;
    public Transform rb;

    public bool isPaused = false;

    public  Transform crosshair;
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    void Update()
    {
        Vector3 viewDir = crosshair.position - new Vector3(transform.position.x,crosshair.position.y,transform.position.z);
        orientation.forward = viewDir.normalized;
        playerObj.forward = viewDir.normalized;
        if(isPaused)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
}
