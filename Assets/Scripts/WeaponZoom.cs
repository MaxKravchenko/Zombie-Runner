using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera fpsCamera;
    [SerializeField] float zoomedOutFOV = 60f;
    [SerializeField] float zoomedInFOV = 20f;

    bool zoomedInToggle = false;

    private void OnDisable() 
    {
        ZoomOut();
    }
    
    private void Update() 
    {
        if(Input.GetMouseButtonDown(1))
        {
            if(zoomedInToggle == false)
            {
                ZoomIn();
            }
            else
            {
                ZoomOut();
            }
        }
    }

    private void ZoomIn()
    {
        zoomedInToggle = true;
        fpsCamera.m_Lens.FieldOfView = zoomedInFOV;
    }

    private void ZoomOut()
    {
        zoomedInToggle = false;
        fpsCamera.m_Lens.FieldOfView = zoomedOutFOV;
    }
}
