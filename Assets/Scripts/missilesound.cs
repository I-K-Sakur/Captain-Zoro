using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missilesound : MonoBehaviour
{
    private rocketmovement rocketmovement;
    public AudioSource missilehitsound;
    public AudioClip missilehitsoundclip;

    void Start()
    {
        // Get the rocketmovement script attached to the same GameObject
        rocketmovement = GetComponent<rocketmovement>();
        if (rocketmovement == null)
        {
            Debug.Log("rocketmovement script not found!");
        }
    }

    // Update is called once per frame
    // void Update()
    // {
    //     if (rocketmovement != null && rocketmovement.particleonhoise)
    //     {
    //         missilehitsound.PlayOneShot(missilehitsoundclip);
    //     }
    //     //rocketmovement.particleonhoise=false;
    // }
}
