using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class showtext : MonoBehaviour
{
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        text.enabled=false;
    }

    // Update is called once per frame
 private void OnTriggerEnter(Collider other)
{
  text.enabled=true;
  Debug.Log("kaj hocche");
}
private void OnTriggerExit(Collider other)
{
    text.enabled=false;
}
}
