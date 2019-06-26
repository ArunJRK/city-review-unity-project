using System.Collections;
using UnityEngine;

public class ViewHelper : MonoBehaviour
{

    private Camera _mainCamera;
    public Vector3 offset;
    float y;
    Vector3 v3;
    void Start()
    {
        _mainCamera = Camera.main;
    

    }

    void Update()
    {
        y = transform.parent.eulerAngles.y;
        v3.x = 0;
        v3.y = y;
        v3.z = 0; 

     transform.eulerAngles = v3;
    transform.position = _mainCamera.transform.position + offset; 
            }
}