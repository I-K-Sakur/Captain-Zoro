using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class heartmilitarythelast : MonoBehaviour
{
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
       militarythelastrun militarythelastrun = FindObjectOfType<militarythelastrun>();
      militarythelastrun.bulletsToKillPlayer=300;
    }

    // Update is called once per frame
    void Update()
    {
        int playerheart=militarythelastrun.bulletsToKillPlayer;
        slider.value=playerheart;
    }
}
