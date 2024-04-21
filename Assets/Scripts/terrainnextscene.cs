// Beginning_next_Sene.cs
using UnityEngine;
using UnityEngine.SceneManagement;

public class terrainnextscene : MonoBehaviour
{
    public string nextscene;
    public static bool terrainscene = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Set beginningscene to true when the space key is pressed
         terrainscene = true;
            LoadNextScene();
        }
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene(nextscene);
    }
}
