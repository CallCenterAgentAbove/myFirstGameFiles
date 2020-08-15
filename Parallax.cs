using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public float parallaxEffectMultiplier = 0.5f;
    private Transform cameraTransform;
    private Vector3 lastCameraPosition;

    private void Start(){

        cameraTransform = Camera.main.transform;
        lastCameraPosition = cameraTransform.position;
        
    }
    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 deltaMovement = cameraTransform.position - lastCameraPosition;
        transform.position += deltaMovement * parallaxEffectMultiplier;
        lastCameraPosition = cameraTransform.position;
    }
}
