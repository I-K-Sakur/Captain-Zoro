﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class aboutobject : MonoBehaviour
{
     public string nextSceneName;
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene(nextSceneName);
    }

    // Update is called once per frame
  
}
