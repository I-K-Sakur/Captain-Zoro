using UnityEngine;
using UnityEngine.Playables;

public class Furizkillingscene : MonoBehaviour
{
     public string tagToDestroy;
    public static bool scenefinished = false;
    public GameObject Thelastrun;
    public GameObject cutscene;
    public PlayableDirector timelineDirector;
    public Transform Player;
    public GameObject ShooterPlayer;
    public GameObject player;
    //private BoxCollider boxcoll;
    public static bool stopgun = false;
//   public GameObject gunscript;
    void Start()
    {
        cutscene.SetActive(false);
        player.SetActive(false);
        // Get the BoxCollider component attached to this GameObject
        //boxCollider = GetComponent<BoxCollider>();
    }

    void Update()
{
    if (Player.position.x <= 360f)
    {
        stopgun = true;
        DestroyGameObjectsWithTag(tagToDestroy);
        
        //alternate way eita object deletion er
        // GameObject objectdelete2=GameObject.Find("NewGun_auto(Clone)");
        // // Finding the GameObject to delete NewGun_auto(Clone)
        // GameObject objectToDelete = GameObject.Find("NewGun_semi(Clone)");

        // // Check if the object is found
        // if (objectToDelete != null)
        // {
        //     // Delete the object
        //     Destroy(objectToDelete);
        //     Destroy(objectdelete2);
        //     Debug.Log("Deleted NewGun_semi(Clone)");
        // }
        // else
        // {
        //     Debug.Log("Object 'NewGun_semi(Clone)' not found");
        // }

        //Debug.Log("Player entered trigger zone");
        cutscene.SetActive(true);
        ShooterPlayer.SetActive(false);
       scenefinished = true;
        // Activating the player GameObject
        if (timelineDirector != null)
        {
            // Playing the timeline
           // Debug.Log("Playing timeline");
            //timelineDirector.Play();
            player.SetActive(true);
            //
        }
        else
        {
            ShooterPlayer.SetActive(true);
            Debug.Log("Timeline director not assigned");
        }
    }
}
void DestroyGameObjectsWithTag(string tag)
    {
        // Find all game objects with the specified tag
        GameObject[] gameObjectsWithTag = GameObject.FindGameObjectsWithTag(tag);

        // Loop through each game object and destroy it
        foreach (GameObject gameObjectWithTag in gameObjectsWithTag)
        {
            Destroy(gameObjectWithTag);
        }
    }

}
