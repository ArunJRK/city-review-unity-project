using System.Collections;

//Change this script's execution to negative in Edit > Project Settings > Execution Order
//(change it to something like -100 I suppose

using System.Collections.Generic;
using UnityEngine;

public class MainGameCameraRaycast : MonoBehaviour
{

    public RaycastHit raycastHit;

    void Update()
    {
        Ray forwardRay = new Ray(transform.position, transform.forward);
        Physics.Raycast(forwardRay, out raycastHit);
    }
}
