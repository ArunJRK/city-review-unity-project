using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDown : MonoBehaviour
{

    public Vector3 newv3, oldv3;
    private bool a = true;
    public void zap()
    {
        if (a)
        {
            oldv3 = transform.position;
            transform.position = newv3;
            a = false;
        }

        else
        {
            transform.position = oldv3;
            a = true;
        }
    }
}
