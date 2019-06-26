using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour
{
    public float spinForce = 50f;

    void Update()
    {
        transform.Rotate(0, spinForce * Time.deltaTime, 0);
    }

    public void changeSpin()
    {
        spinForce = -spinForce;
    }
}
