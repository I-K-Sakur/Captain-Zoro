using UnityEngine;
using UnityEngine.Playables;

public class HouseCutsceneTrigger : MonoBehaviour
{
    public PlayableDirector cutsceneDirector;
    public bool isInside = false;
    public bool baire = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Player entered the trigger zone
            isInside = true;
            StartCutscene();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player exited the trigger zone");
            // Player exited the trigger zone
            if (isInside)
            {
                // Play exit cutscene only if the player was previously inside
                // StartExitCutscene();
                baire = true;
            }
            // isInside = false;

            StartCutscene();
        }
    }

    private void StartCutscene()
    {
        if (baire == true && isInside)
        {
            // Pause the game
            Time.timeScale = 0f;

            // Trigger the cutscene when entering the house
            cutsceneDirector.Play();

            // Deactivate dummy objects
            DeactivateDummies();
        }
    }

    private void DeactivateDummies()
    {
        GameObject[] dummies = GameObject.FindGameObjectsWithTag("Dummie");
        foreach (GameObject dummy in dummies)
        {
            dummy.SetActive(false);
        }
    }

    private void ReactivateDummies()
    {
        GameObject[] dummies = GameObject.FindGameObjectsWithTag("Dummie");
        foreach (GameObject dummy in dummies)
        {
            dummy.SetActive(true);
        }
    }

    private void StartExitCutscene()
    {
        // Pause the game
        Time.timeScale = 0f;

        // Trigger the exit cutscene when exiting the house
        // Use another PlayableDirector if needed
        cutsceneDirector.Play();
    }

    // This method is called by the Timeline to resume the game
    public void ResumeGame()
    {
        // Resume the game
        Time.timeScale = 1f;
    }
}

