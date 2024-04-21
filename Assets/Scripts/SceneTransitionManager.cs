using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionManager : MonoBehaviour
{
    private string currentScene;

    void Start()
    {
        currentScene = SceneManager.GetActiveScene().name;
    }

    void OnApplicationQuit()
    {
        SaveData();
    }

    void SaveData()
    {
        PlayerPrefs.SetString("CurrentScene", currentScene);
    }

    void LoadData()
    {
        currentScene = PlayerPrefs.GetString("CurrentScene");
    }

    // Example usage of loading the saved scene name
    public void LoadSavedScene()
    {
        LoadData();
        SceneManager.LoadScene(currentScene);
    }
    public void DeleteData()
    {
        PlayerPrefs.DeleteAll();
    }
}
