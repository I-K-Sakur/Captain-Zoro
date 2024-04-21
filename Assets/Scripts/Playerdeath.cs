using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerdeath : MonoBehaviour
{
    public static bool morse=false;
    public GameObject Text;
    public GameObject playercamera;
    private Military military; // Reference to the Military script
     private militarythelastrun militaryone; // Reference to the Military script
    public Transform player;
   public void Start()
    {
       militaryone=GetComponent<militarythelastrun>();
        military = GetComponent<Military>(); // Get the Military component on the same GameObject
    }

 public   void Update()
    {
        if (military != null && military.yes == true|| militaryone.yes==true)
        {
            KillPlayer();
        }
        //   playercamera.SetActive(false);
    }

  public  void KillPlayer()
    {
        player.rotation=Quaternion.Euler(90f,player.rotation.eulerAngles.y,player.rotation.eulerAngles.z);
         playercamera.SetActive(false);
         
         Text.SetActive(true);
         morse=true;
        // Your kill player logic
         Debug.Log("The player is dead");
    }
}
