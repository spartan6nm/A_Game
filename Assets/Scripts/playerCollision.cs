using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public playerController playercontroller;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "obstacle")
        {
            playercontroller.enabled = false;
            FindObjectOfType<gameManager>().endGame();
        }
    }
}
