using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameracontroller : MonoBehaviour
{

    public GameObject player;

    private Vector3 offset;

    void Start()
    {
        offset = transform.position - player.transform.position;
        // distance between camera and the player object in the scene view
    }


    void LateUpdate()
    { 
        transform.position = player.transform.position + offset;
        /* camera going to players position every frame
        but the vector3 offset helding it back from that position
        by the margin that was between the two objacts at the first place*/
    }
}
