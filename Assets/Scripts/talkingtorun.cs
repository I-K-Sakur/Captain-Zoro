using UnityEngine;
using UnityEngine.Playables;
public class talkingtorun : MonoBehaviour
{
    // public GameObject player;
    public GameObject thelastmilitaryrun;
    // public GameObject talking;
    // public GameObject furizz;
//public PlayableDirector timelineDirector;
    void Start()
    {
        thelastmilitaryrun.SetActive(false);
    }
    void Update()
    {
         if(Furizkillingscene.scenefinished==true)
         {
            // player.SetActive(true);
             thelastmilitaryrun.SetActive(true);
         }
    }

}
