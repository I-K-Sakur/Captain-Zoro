using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class heart : MonoBehaviour
{
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
      Military  Military = FindObjectOfType<Military>();
      Military.bulletsToKillPlayer=300;
    }

    // Update is called once per frame
    void Update()
    {
        int playerheart=Military.bulletsToKillPlayer;
        slider.value=playerheart;
    }
}
