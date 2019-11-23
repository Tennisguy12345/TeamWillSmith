using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody Player;
    public GameObject nodoublejump;
    private bool isgrounded;

    // Start is called before the first frame update
    void Start()
    {
        if (isgrounded == true)
        {
            
            if (Input.GetButtonDown("Jump"))
            {
                Player.AddRelativeForce(new Vector3(0, 100000, 0));

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKey("d"))
            Player.transform.Translate(new Vector3(10, 0, 0));
        if (Input.GetKey("a"))
            Player.transform.Translate(new Vector3(-10, 0, 0));


    }
    void OnCollisionEnter(Collision theCollision)
    {
        if (theCollision.gameObject.name == "Grass Level")
        {
            isgrounded = true;
            
        }
    }
    void OnCollisionExit(Collision theCollision)
    {
        if (theCollision.gameObject.name == "Grass Level")
        {
            isgrounded = false;
        }
    }
}
