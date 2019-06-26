using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Borders : MonoBehaviour
{
    private Color startcolor;
  public  void newcolor()
    {
        startcolor = GetComponent<Renderer>().material.color;
        GetComponent<Renderer>().material.color = Color.yellow;
        Debug.Log("Enter");
    }
   public void oldcolor()
    {
        Debug.Log("Exit");
        GetComponent<Renderer>().material.color = startcolor;
    }
}
