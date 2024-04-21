using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eithenspawn : MonoBehaviour
{
    //public GameObject eithenspaw;
    public GameObject spaceship;
    public GameObject fps;
    public GameObject playerPrefab;
    //public Vector3 spawnlocation=new Vector3(-521f,138f,-292f);
    private bool hasSpawn=false;
    // Start is called before the first frame update
    
void Start()
{
    //Keeping the player hidden until certain codition are made
    playerPrefab.SetActive(false);
}
    // Update is called once per frame
    void Update()
    {
        if (fps.transform.position.x <= transform.position.x && !playerPrefab.activeSelf)
    {
        // Instantiate the player prefab if it's not already active
        Instantiate(playerPrefab, fps.transform.position, Quaternion.identity);
        playerPrefab.SetActive(true);
        hasSpawn = true;
        //playerPrefab.transform.position.z=fps.transform.position.z-32;
    }
    
        // if(fps.transform.position.x<=transform.position.x && !hasSpawn)
        // {
        //     //Activing it from hidden
        //     playerPrefab.SetActive(true);
        //     Instantiate(playerPrefab,spawnlocation,Quaternion.identity);
        //     hasSpawn=true;
        // }
        // if(hasSpawn==true)
        // {
        //   playerPrefab.transform.position.z=fps.transform.position.z-32;
        // }
        // if(spaceship.transform.position.z<=playerPrefab.transform.position.z)
        // {
        //     Destroy(playerPrefab);
        // }
    }
}
