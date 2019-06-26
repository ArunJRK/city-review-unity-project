using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim : MonoBehaviour
{
    Animation anima;
    // Start is called before the first frame update
    void Start()
    {
        anima = GetComponent<Animation>();
    }


    public void animStart()
    {
        anima.Play();
    }
}
