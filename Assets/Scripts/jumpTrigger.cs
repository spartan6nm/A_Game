using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class jumpTrigger : MonoBehaviour
{
    public static bool jumpZone = false;
    public GameObject jumpZoneEnterText;

    void OnTriggerEnter()
    {
        jumpZone = true;
        jumpZoneEnterText.SetActive(true);
        Invoke("disabler", 1f);

    }
    void disabler()
    {
        jumpZoneEnterText.SetActive(false);
    }
}
