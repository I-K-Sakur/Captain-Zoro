using UnityEngine;
using UnityEngine.UI;

public class housecountertext : MonoBehaviour
{
    public Text housecounter;
// void Start()
// {
//     //eta use kore script Ze object er sathe add take active/deactive kora zay
//     gameObject.SetActive(false);
// }
    void Update()
    {
        // Make sure to include the UnityEngine.UI namespace for Text
        housecounter.text = "Camp Remain: " + rocketmovement.housecounter.ToString();
    }
}
