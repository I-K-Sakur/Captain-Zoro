using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement;

public class nextscene : MonoBehaviour
{
    public Transform player;
     public string nextSceneName;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        if(player.position.y>=13f)
        {
          Debug.Log("Yeah it is working");
              SceneManager.LoadScene(nextSceneName);
        }
        if(Playerdeath.morse==true && Input.GetKeyDown(KeyCode.Return))
        {
             // Reload the current scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
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
