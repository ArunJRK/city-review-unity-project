using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int sceneIndex;
  public void PlayGame ()  // Start is called before the first frame update
  {
    SceneManager.LoadScene(sceneIndex);
  }
public void QuitGame ()
{
  Debug.Log("Quit");
  Application.Quit();
}
}
