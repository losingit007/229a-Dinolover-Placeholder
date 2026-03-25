using System;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class ThirdPersonShootingSystem : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    [SerializeField] private LayerMask aimColliderLayerMask = new LayerMask();
    
    [SerializeField] private Transform perfabBulletprojectile;
    [SerializeField] private Transform spawnBulletPosition;
    


    void Update()
    {   
        Vector3 mouseWorldPosition = Vector3.zero;
        Vector2 screenCenterPoint = new Vector2(Screen.width/2f,Screen.height/2f);
        Ray ray = mainCamera.ScreenPointToRay(screenCenterPoint);
        if(Physics.Raycast(ray,out RaycastHit raycastHit,999f,aimColliderLayerMask))
        {
            
            mouseWorldPosition = raycastHit.point;

        }

        if(Input.GetMouseButtonDown(0))
        {
            Vector3 aimDir = (mouseWorldPosition - spawnBulletPosition.position).normalized;
            Instantiate(perfabBulletprojectile,spawnBulletPosition.position,Quaternion.LookRotation(aimDir,Vector3.up));
        }
    }
}
