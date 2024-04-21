using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class letterobjectsetactive : MonoBehaviour
{
    public GameObject letterobject;
    // Start is called before the first frame update
    void Start()
    {
        letterobject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(rocketmovement.housecounter<=0)
        {
            letterobject.SetActive(true);
        }
    }
}
