using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class destroynextscene : MonoBehaviour
{
    public string nextscene;
    public int nextSceneIndex; // Index of the next scene in the build settings

    void Start()
    {
        // Check if any GameObjects with the "House" tag are present in the scene
        if (!CheckForHouseTag())
        {
            // If no GameObjects with the "House" tag are found, load the next scene
            LoadNextScene();
        }
    }

    bool CheckForHouseTag()
    {
        // Check if any GameObjects with the "House" tag are present in the scene
        GameObject[] houseObjects = GameObject.FindGameObjectsWithTag("House");
        return (houseObjects != null && houseObjects.Length > 0);
    }

    void LoadNextScene()
    {
        // // Load the next scene by index
        // if (nextSceneIndex >= 0 && nextSceneIndex < SceneManager.sceneCountInBuildSettings)
        // {
        //     SceneManager.LoadScene(nextSceneIndex);
        // }
        // else
        // {
        //     Debug.LogError("Next scene index is out of range!");
        // }
        SceneManager .LoadScene(nextscene);
    }
}
