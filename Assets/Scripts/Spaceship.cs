using UnityEngine;
using UnityEngine.SceneManagement;

public class Spaceship : MonoBehaviour
{
    public static bool consta = false;
    public Transform Space;
    public float rotationSpeed = -2.0f;
    public float movespeed = -10f;
    public float newYSpeed = -2f; // Y-axis movement speed
    public float newYMin = 80f;
    public static bool namse = false;
    public GameObject camera;
    public GameObject fpsplayer;
    public string nextScene="DESTROY EVERYTHING";
 void Start()
 {
  namse=false;
   // camera.SetActive(false);
 }
    void Update()
    {
        // Check if the spaceship hasn't entered yet and hasn't reached the stopping position along the Z-axis
        if (!consta )
        {
            if( Space.position.z >= -380f || namse==true)
            {
            // Move the spaceship along the Z-axis
            float newZ = Space.position.z + movespeed * Time.deltaTime;
            Vector3 newPosition = new Vector3(Space.position.x, Space.position.y, newZ);
            Space.position = newPosition;
            }
          if(Space.position.z<=381f && Space.position.z>-385f && namse==true)
          {
            movespeed=-0.5f;
             // Move the spaceship along the Z-axis
            float newZ = Space.position.z + movespeed * Time.deltaTime;
            Vector3 newPosition = new Vector3(Space.position.x, Space.position.y, newZ);
            Space.position = newPosition;
          }
        // Check if the spaceship hasn't entered yet and has reached the stopping position along the Z-axis
        if ( Space.position.z < -380f && Space.position.y >= newYMin && !namse)
        {
            // Move the spaceship only along the Y-axis
            float newY = Space.position.y + newYSpeed * Time.deltaTime;
            Vector3 newYPosition = new Vector3(Space.position.x, newY, Space.position.z);
            Space.position = newYPosition;

            // Check if the spaceship has reached its limitation on the Y-axis
            if (Space.position.y <= newYMin)
            {
                namse = true;
                
            }
        }
        }

        // Check if the player has entered the spaceship
        if (AutoFPSMovementWithObject.enter)
        {
            consta = true;
            fpsplayer.SetActive(false);
            //camera.SetActive(true);
            SceneManager.LoadScene(nextScene);
            // // Rotate the spaceship based on horizontal input
            // float y = Input.GetAxis("Horizontal");
            // transform.Rotate(Vector3.up * y * Mathf.Abs(rotationSpeed) * Time.deltaTime);

            // // Move the spaceship forward based on vertical input
            // float verticalInput = Input.GetAxis("Vertical");
            // Space.Translate(Vector3.forward * movespeed * Time.deltaTime);
        }
    }
}
