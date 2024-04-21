using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class insidethehelicopternextscene : MonoBehaviour
{
    public string nextscene;
    public static bool insidethehelicopter = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Set beginningscene to true when the space key is pressed
            insidethehelicopter=true;
            LoadNextScene();
        }
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene(nextscene);
    }
}
