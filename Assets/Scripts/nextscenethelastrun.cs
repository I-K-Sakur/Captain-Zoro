using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement; // Add this line to reference the SceneManager class

public class TimelineController : MonoBehaviour
{
    public PlayableDirector playableDirector;
    public int nextSceneIndex; // Index of the next Timeline scene in the build settings

    private bool sceneFinished = false;

    void Start()
    {
        // Subscribe to the Timeline's "Finished" event
        playableDirector.stopped += OnTimelineFinished;
    }

    void OnTimelineFinished(PlayableDirector director)
    {
        // Check if the director that stopped matches our playableDirector
        if (director == playableDirector)
        {
            // Set the flag to indicate that the scene is finished
            sceneFinished = true;
        }
    }

    void Update()
    {
        // Check if the scene is finished and the player triggers a key press (for example, the space bar)
        if (sceneFinished && Input.GetKeyDown(KeyCode.Space))
        {
            // Load the next Timeline scene
            LoadNextScene();
        }
    }

    void LoadNextScene()
    {
        // Load the next scene by index
        if (nextSceneIndex >= 0 && nextSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
        else
        {
            Debug.LogError("Next scene index is out of range!");
        }
    }
}
