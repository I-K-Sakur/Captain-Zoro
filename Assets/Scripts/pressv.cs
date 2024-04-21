
using UnityEngine;
using UnityEngine.UI;
public class pressv : MonoBehaviour
{
    public Text text;
    public Transform player;
    public Transform spaceship;

 void Start()
 {
    text.enabled=false;
 }   

    void Update()
    {
        // Check if Spaceship.namse is true and player's z position is less than or equal to -317
        if (Spaceship.namse && player.position.z >= -310f)
        {
            text.enabled=true;
            Debug.Log("Working well");
        }
    }
}
