using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            return;
        }

        Vector3 cameraOffset = target.transform.position;
        cameraOffset.z -= 10;
        cameraOffset.y = 4;
        this.transform.position = cameraOffset;
    }
}
