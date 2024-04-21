using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aikiller : MonoBehaviour
{
    public static bool bull_rec = false;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                Debug.Log("Hit object: " + hit.collider.gameObject.name);
                Debug.Log("Object tag: " + hit.collider.tag);
                Debug.Log("Object layer: " + hit.collider.gameObject.layer);

                // Check if the hit object has a specific component (replace "Military" with your actual script name)
                militarythelastrun militarythelastrun = hit.collider.gameObject.GetComponent<militarythelastrun>();
                Military militaryScript = hit.collider.gameObject.GetComponent<Military>();
                // Military militarythelastrun = hit.collider.gameObject.GetComponent<Military>();

                if (militaryScript != null)
                {
                    Debug.Log("Military hit!");
                    militaryScript.bull_rec = true;
                    militarythelastrun.bull_rec=true;
                }
                else
                {
                    Debug.Log("Not a Military.");
                }
            }
        }
    }
}
