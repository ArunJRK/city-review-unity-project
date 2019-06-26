using System.Collections;
using UnityEngine;

public class SlideSmooth : MonoBehaviour
{
    private Camera _mainCamera;
    float they, newy, themovingitch;
    public float speed;
    enum State { InScreen, NotInScreen, Moving };
    private State _currentState;
    public int differcence;
    Quaternion q;
    float t1;
    public float timeGap;
    void Start()
    {
        _mainCamera = Camera.main;
        they = _mainCamera.transform.eulerAngles.y;
        _currentState = State.InScreen;
        Debug.Log(_currentState);
    }

    void Update()
    {
        //Debug.Log(_currentState);
        newy = _mainCamera.transform.eulerAngles.y;
        switch (_currentState)
        {
            case State.InScreen:
                if (rotationCheck())
                {
                  _currentState = State.NotInScreen;
                    themovingitch = newy;
                    q = _mainCamera.transform.rotation;
                }
                break;

            case State.NotInScreen:
                _currentState = State.Moving;
                t1 = Time.time;
                StartCoroutine(rotate());
                break;
        }
        
    }
    private IEnumerator rotate()
    {
        while(Time.time-t1<timeGap && newy!=transform.eulerAngles.y)
        {
            var step = speed * Time.deltaTime;
            //transform.eulerAngles = new Vector3(0, _mainCamera.transform.eulerAngles.y, 0);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, _mainCamera.transform.rotation, step);
            transform.eulerAngles = new Vector3(0,transform.eulerAngles.y, 0);
            yield return null;
        }
        they = _mainCamera.transform.eulerAngles.y;
        _currentState = State.InScreen;
    }

    private bool rotationCheck()
    {
        return (Mathf.Abs(Mathf.Abs(they) - Mathf.Abs(newy)) > differcence);
    }
}
