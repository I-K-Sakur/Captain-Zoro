// Beginning_next_Sene.cs
using UnityEngine;
using UnityEngine.SceneManagement;

public class Beginning_next_Sene : MonoBehaviour
{
    public string nextscene;
    public static bool beginningscene = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Set beginningscene to true when the space key is pressed
         beginningscene = true;
            LoadNextScene();
        }
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene(nextscene);
    }
}
