using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement;

public class reloadscene : MonoBehaviour
{
    public static bool relscene=false;
    public Transform player;
     public string nextSceneName;
     public GameObject Textobject;
    // Start is called before the first frame update
    void Start()
    {
        relscene=false;
    }
    void Update()
    {
        if(player.position.y>=13f)
        {
          Debug.Log("Yeah it is working");
              SceneManager.LoadScene(nextSceneName);
        }
        if(Playerdeath.morse && Input.GetKeyDown( KeyCode.Return))
        {
            Textobject.SetActive(false);
             // Reload the current scene
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            SceneManager.LoadScene(nextSceneName);
        }
        
    }

    // Update is called once per frame
//    private void  OnCollisionEnter(Collision collision)
//    {
//         if(collision.gameobject.CompareTag("Player"))
//         {
//              Debug.Log("Yeah it is working");
//               SceneManager.LoadScene(nextSceneName);
//         }
//     }
}
