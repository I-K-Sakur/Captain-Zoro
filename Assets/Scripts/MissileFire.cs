using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileFire : MonoBehaviour
{
//    public static Vectro3 particledestination;

    public GameObject redmissile;
    public AudioSource missilefire;
    public AudioClip missilesound;

    public GameObject greenmissile;
    public  bool tarhit=false;
  public static Vector3 particle_postion;
 
    // public Transform SpaceShip;
    // public Transform Missile;

    // Start is called before the first frame update
 

    // Update is called once per frame

    void Update()
    {
      
        if(Input.GetKeyDown(KeyCode.Return))
        {
            
            if(Camera.main!=null)
            {
                 Vector3 cameraPosition = Camera.main.transform.position;
           Ray ray = new Ray(cameraPosition, Camera.main.transform.forward);
            Debug.DrawRay(ray.origin, ray.direction * 100f, Color.red, 1f);
            RaycastHit hit;
            
            if(Physics.Raycast(ray,out hit))
            {
                if(hit.collider.CompareTag("House"))
                {
                    Debug.Log("HOuse hitted perfectly");
                    tarhit=true;
                    missilefire.PlayOneShot(missilesound);
                    rocketmovement.target=hit.transform;
                    particle_postion=hit.transform.position;
                    // if(housecounter>=1)
                    // {
                    //     housecounter--;
                    // }
                    // else{
                    //     Debug.Log("Next scene starts");
                    // }
                    
                }
                else{
                    Debug.Log("Raycast not hit");
                }
            }
            }
        }
        // if(SpaceShip!=null && Missile!=null)
        // {
        //     SpaceShip=Missile;
        // }
        if(tarhit==true && Input.GetMouseButtonDown(0))
        {
            LaunchRedMissile();
        
            //missilehitsound.PlayOneShot(missilehitsoundclip);
            tarhit=false;
          
        }
        if(tarhit==true && Input.GetMouseButtonDown(1))
        {
            LaunchGreenMissile();
            
           //missilehitsound.PlayOneShot(missilehitsoundclip);
            tarhit=false;
           
        }
        
    
      
       
    }
    void LaunchRedMissile()
    {
        Instantiate(redmissile,transform.position,transform.rotation);
    }
     void LaunchGreenMissile()
    {
        Instantiate(greenmissile,transform.position,transform.rotation);
    }
  
}
