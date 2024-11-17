using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Changescene : MonoBehaviour
{
    // Start is called before the first frame update
    public void changeSceneShowroom()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void changeSceneInterior()
    {
        SceneManager.LoadScene("Interior");
    }
    public void changeScene360Drive()
    {
        SceneManager.LoadScene("360Drive");
    }
}
