using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missionquest : MonoBehaviour
{
    public GameObject ui;
    public AudioSource audiosource;
    public string targetTag = "Dummie";
    public GameObject heart;
    private GameObject[] objectsWithTag; // Define the array at the class level

    private bool ispaused = false;

    // Start is called before the first frame update
    void Start()
    {
        ui.SetActive(false);
        objectsWithTag = GameObject.FindGameObjectsWithTag(targetTag); // Find objectsWithTag only once
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (ispaused)
            {
                ResumeGame();
                EnableTarget();
                
                audiosource.enabled = true;
                 ui.SetActive(false);
            }
            else
            {
                PauseGame();
                DisableTarget();
               
                audiosource.enabled = false;
                ui.SetActive(true);
            }
        }
    }

    void DisableTarget()
    {
        foreach (GameObject obj in objectsWithTag)
        {
            obj.SetActive(false);
        }
    }

    void EnableTarget()
    {
        foreach (GameObject obj in objectsWithTag)
        {
            obj.SetActive(true);
        }
    }

    void ResumeGame()
    {
        Time.timeScale = 1f;
        ispaused = false;
    }

    void PauseGame()
    {
        Time.timeScale = 0f;
        ispaused = true;
    }
}
