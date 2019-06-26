using UnityEngine;

public class startup : MonoBehaviour
{

    Camera _main;
    // Start is called before the first frame update
    void Start()
    {
        _main = Camera.main;
        transform.eulerAngles = new Vector3(0, _main.transform.eulerAngles.y, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
