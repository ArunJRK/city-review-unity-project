using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewHelperRotation : MonoBehaviour
{
    Camera cam;
    float y;
    Vector3 v3;
    
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        y = cam.transform.eulerAngles.y;

        v3.y = y;
        v3.x = 0;
        v3.z = 0;

        Debug.Log(v3);
            transform.eulerAngles = v3;
    }
}
