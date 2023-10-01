using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followCamera : MonoBehaviour
{
    // method 1 
    [SerializeField] GameObject thingToFollow;

    // the cameras positions should be the same as the cars position 
    void LateUpdate()
    {
       transform.position = thingToFollow.transform.position + new Vector3(0, 0, -10);
    }
}
// Update to LateUpdate fixed the camera stutter issue 