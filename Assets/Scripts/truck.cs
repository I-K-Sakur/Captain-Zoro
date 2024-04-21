using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class truck : MonoBehaviour
{
    public GameObject player;
    public Transform trucc;
    public bool inside = false;
    public float moveSpeed = 30.0f;
    public float rotationSpeed = 10.0f;
    public Text indicatorText;
    public Text turorialtext;
    private Rigidbody playerRigidbody;
    public AudioClip myaudioclip;
     public AudioClip door;
    public AudioSource myaudiosource;

    void Start()
    {
        
        //Component ta nilam
         myaudiosource=GetComponent<AudioSource>();
         truckaudio();
         
        // myaudiosource.clip=myaudioclip;
        playerRigidbody = player.GetComponent<Rigidbody>();
        HideIndicator();
    }

    void Update()
    {
        if (inside == false && Input.GetKeyDown(KeyCode.B))
        {
            // Set player inside the truck
            inside = true;
            //code mote play korlam
            myaudiosource.Play();
            // Set player position and freeze constraints
            SetPlayerPosition();
            HideIndicator();
        }
        else if (inside == true && Input.GetKeyDown(KeyCode.B))
        {
            // Reset player position and unfreeze constraints
            ResetPlayerPosition();
             myaudiosource.Stop();
            // Set player outside the truck
            inside = false;
            HideIndicator();
        }

        // Handle player movement and rotation when inside the truck
        if (inside)
        {

            HandleInput();
        }
        else{
            if(playerneartruck())
            {
                 ShowIndicator("Press 'B' to enter and exit into the Vehicle \n Press i,k,j,l and mouse to control");
            }
            else{
             HideIndicator();
            }
        }
    }

    void HandleInput()
    {
        if (playerneartruck())
        {
            if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
            {
                trucc.Translate(Vector3.right * moveSpeed * Time.deltaTime);
                // Rotate left
                trucc.Rotate(Vector3.down * rotationSpeed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
            {
                trucc.Translate(Vector3.right * moveSpeed * Time.deltaTime);
                // Rotate right
                trucc.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.W))
            {
                // Move forward along the x-axis
                trucc.Translate(Vector3.right * moveSpeed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
            {
                // Move backward along the x-axis
                trucc.Translate(Vector3.left * moveSpeed * Time.deltaTime);
                trucc.Rotate(Vector3.down * rotationSpeed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
            {
                // Move backward along the x-axis
                trucc.Translate(Vector3.left * moveSpeed * Time.deltaTime);
                trucc.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.S) )
            {
                // Move backward along the x-axis
                trucc.Translate(Vector3.left * moveSpeed * Time.deltaTime);
                
            }
            // else if(Input.GetKey(KeyCode.I) && Input.GetKey(KeyCode.L))
            // {
            //     trucc.Translate(Vector3.right * moveSpeed * Time.deltaTime);
            //     trucc.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
            // }
        
        }
    }

    bool playerneartruck()
    {
        // Implement a check based on the truck's position and size
        // Example: Check if the player is within a specific range around the truck
        float distance = Vector3.Distance(player.transform.position, trucc.position);
        return distance <= 5f; // Adjust the value as needed
    }

    void SetPlayerPosition()
    {
        // Set player inside the truck
        player.transform.SetParent(trucc);
         player.transform.localPosition = new Vector3(0.6f, 1.2f, 0f);
        playerRigidbody.constraints = RigidbodyConstraints.FreezeAll; // Freeze position and rotation
    }

    void ResetPlayerPosition()
    {
        // Reset player position when exiting the truck
        player.transform.SetParent(null); // Unparent the player
        player.transform.position = trucc.position + new Vector3(0f, 1f, -2f); // Adjust the offset as needed
        player.transform.rotation = trucc.rotation; // Align player's rotation with the truck
        playerRigidbody.constraints = RigidbodyConstraints.None; // Unfreeze position and rotation
    }
    void ShowIndicator(string message)
    {
        indicatorText.text=message;
        indicatorText.gameObject.SetActive(true);
    }
  void HideIndicator()
  {
   indicatorText.gameObject.SetActive(false);
  }
  void truckaudio()
  {
    //Assign korlam
    myaudiosource.clip=door;
    StartCoroutine(Mycoroutine());
    
  }
  IEnumerator Mycoroutine()
  {
     yield return new WaitForSeconds(0.4f);
     //clip assigned
        myaudiosource.clip = myaudioclip;
  }
}


