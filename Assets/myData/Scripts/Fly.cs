using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{    public float playerSpeed;
    /*public Vector3 position;
    public Vector3 rotation;
    private void Start()
    {
        transform.position = position;
        transform.eulerAngles = rotation;
    }*/
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Vector3 v3 = Camera.main.transform.forward * playerSpeed * Time.deltaTime;
            v3.y = 0;

            transform.position += v3;
        }
    }
}
