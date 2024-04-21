using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class distance : MonoBehaviour
{
     public Transform player;
     public Text pressv;
    public Transform objectToMeasure;
    public Text distanceText;
    public  Text failtext;
 public Text WinText;

    void Start()
    {
        reloadscene reloadscene=GetComponent<reloadscene>();
          spcaecontrol.uthse=false;
           Spaceship.consta=false;
           theend.end=false;
        WinText.enabled=false;
       pressv.enabled=false;
       failtext.enabled=false;
        // Initialize failtext if it's not assigned in the Inspector
        if (failtext == null)
        {
            failtext = GameObject.Find("Text1").GetComponent<Text>();
            
        }

       if (WinText != null)
        {
            WinText.enabled = false;
        }
        // Ensure failtext is disabled at the start
        if (failtext != null)
        {
            failtext.enabled = false;
        }
    }

    void Update()
    {
        if(Spaceship.namse==true && player.position.z<=310f)
        {
            pressv.enabled=true;
        }
        DisplayDistance();
        if ( AutoFPSMovementWithObject.enter==true /*spcaecontrol.uthse==true*/ && Input.GetKeyDown(KeyCode.Return)|| Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            spcaecontrol.uthse=false;
            Spaceship.consta=false;
           theend.end=false;
        //  AutoFPSMovementWithObject.enter == false;
          //RestartCurrentScene();
        }
        //  if(AutoFPSMovementWithObject.gameover==true && Input.GetKeyDown(KeyCode.Return)|| Input.GetKeyDown(KeyCode.KeypadEnter))
        // {
        //     RestartCurrentScene();
        // }
    }

    void DisplayDistance()
    {
        float zDistance = Mathf.Abs(772f-( 380f + Mathf.Abs(objectToMeasure.position.z - transform.position.z)));

        if (objectToMeasure != null && distanceText != null)
        {
            //WinText.enabled=false;
            distanceText.text = "SpaceShip Distance: " +  zDistance.ToString("F0") + "Km";//F0 use hoiche karon float number er dosomiker value dekhbo na
            Debug.Log(zDistance);
        }

        if (AutoFPSMovementWithObject.enter==false /* spcaecontrol.uthse==false*/ && objectToMeasure.position.z <= -400f)
        {
            distanceText.enabled = false;
            WinText.enabled=false;
            // failtext.enabled=true;
            // Ensure failtext is not null before attempting to enable it
            if (failtext != null)
            {
                failtext.enabled = true;
                reloadscene.relscene=true;
            }

            Debug.Log("YOU LOST");
        }
       if(AutoFPSMovementWithObject.enter==true /* spcaecontrol.uthse==true*/ && WinText!=null)
        {
            
            
                //WinText.enabled=true;
              distanceText.enabled=false;
              failtext.enabled=false;
            Debug.Log("Collision");

        }
         if(AutoFPSMovementWithObject.gameover==true && failtext!=null)
        {
            failtext.enabled=true;
            reloadscene.relscene=true;
        }
    
    
    }
    // void RestartCurrentScene()
    //     {
    //        int currentScene=SceneManager.GetActiveScene().buildIndex;
    //         SceneManager.LoadScene(currentScene);
    //         Debug.Log("Restarting");
            
    //     }
}
