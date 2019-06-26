using UnityEngine;
using System.Collections;


public class Click : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //transform.position.x = 10f;
            Debug.Log("Entered mouse click");

        }

    }
    /*public void MoveBoxUp(){
    transform.position += new Vector3(0f, 2f, 0f);
    }*/
   
}