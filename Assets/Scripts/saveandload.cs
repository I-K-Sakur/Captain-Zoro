using UnityEngine;
using UnityEngine.SceneManagement;

public class saveandload : MonoBehaviour
{
    // Define keys for PlayerPrefs
    private const string BEGINNING_KEY = "Beginning";
    private const string TERRAIN_KEY = "Terrain";
    private const string BASECAMP_KEY = "BaseCamp";
    private const string HELICOPTER_KEY = "Helicopter";

    void OnApplicationQuit()
    {
        SaveGame();
    }

    public void SaveGame()
    {
    
        // Save the game state using PlayerPrefs
        PlayerPrefs.SetInt(BEGINNING_KEY, Beginning_next_Sene.beginningscene ? 1 : 0);
        PlayerPrefs.SetInt(TERRAIN_KEY, terrainnextscene.terrainscene ? 1 : 0);
        PlayerPrefs.SetInt(BASECAMP_KEY, inthebasecampnextscene.inthebasecamp ? 1 : 0);
        PlayerPrefs.SetInt(HELICOPTER_KEY, insidethehelicopternextscene.insidethehelicopter ? 1 : 0);
             Debug.Log("Saving game...");
       Debug.Log("beginning: " + BEGINNING_KEY);
      Debug.Log("terrain: " + TERRAIN_KEY);
        // Save PlayerPrefs data to disk
        PlayerPrefs.Save();
        Debug.Log("save game kaj kortese");
    }

    public void LoadGame()
    {
        //Debug.Log("kaj hocche");
        // Load the game state from PlayerPrefs
        Beginning_next_Sene.beginningscene = PlayerPrefs.GetInt(BEGINNING_KEY) == 1;
        terrainnextscene.terrainscene = PlayerPrefs.GetInt(TERRAIN_KEY) == 1;
        inthebasecampnextscene.inthebasecamp = PlayerPrefs.GetInt(BASECAMP_KEY) == 1;
        insidethehelicopternextscene.insidethehelicopter = PlayerPrefs.GetInt(HELICOPTER_KEY) == 1;
        Debug.Log("load game kaj kortese");
        // Determine which scene to load based on the game state
        if (!Beginning_next_Sene.beginningscene)
        {
            SceneManager.LoadScene("Beginning");
        }
        else if (!terrainnextscene.terrainscene)
        {
            SceneManager.LoadScene("Terrain");
        }
        else if (!inthebasecampnextscene.inthebasecamp)
        {
            SceneManager.LoadScene("In the Base Camp");
        }
        else if (!insidethehelicopternextscene.insidethehelicopter)
        {
            SceneManager.LoadScene("Inside the Helicopter");
        }
        else
        {
            // Load the next scene or perform any other necessary actions
            Debug.Log("Hemlo");
        }
    }
}
