// Beginning_next_Sene.cs
using UnityEngine;
using UnityEngine.SceneManagement;

public class inthebasecampnextscene : MonoBehaviour
{
    public string nextscene;
    public static bool inthebasecamp=false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Set beginningscene to true when the space key is pressed
           inthebasecamp=true;
            LoadNextScene();
        }
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene(nextscene);
    }
}
