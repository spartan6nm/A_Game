using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float speed = 1f;
    public float xSpeed = 1f;
    public float ySpeed = 1f;
    
    private Rigidbody rb;
    protected bool grounded = false;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Enviroment" && rb.position.y >=1)
        {
            grounded = true;
        }
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.collider.tag == "Enviroment")
        {
            grounded = false;
        }
    }
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
        
    }

    
    void FixedUpdate()  
    {
        
        rb.AddForce(0 , 0 , speed * Time.deltaTime);

        

        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(xSpeed * Time.deltaTime, 0, 0 , ForceMode.VelocityChange);
        }
        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-xSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.Space) && grounded && jumpTrigger.jumpZone)
        {
            rb.AddForce(0, ySpeed * Time.deltaTime, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<gameManager>().endGame();
        }
    }
}
