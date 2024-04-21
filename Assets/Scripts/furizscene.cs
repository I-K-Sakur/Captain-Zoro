using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class furizscene : MonoBehaviour
{
    public GameObject player;
    public GameObject player2;
    private bool fin=false;
    public PlayableDirector timelineDirector; // Reference to the PlayableDirector component of your Timeline

    void Start()
    {
        player.SetActive(false);
        // Play the Timeline when the scene starts
        if (timelineDirector != null)
        {
            timelineDirector.Play(); //  can also use timelineDirector.Play(timelineAsset); to specify a specific Timeline asset
            fin=true;
        }
    }
    void Update()
    {
        if(fin==true)
        {
            player2.SetActive(false);
            if(player!=null) player.SetActive(true);

        }
    }
}

