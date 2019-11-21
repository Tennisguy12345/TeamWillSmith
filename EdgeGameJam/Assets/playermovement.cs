using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d"))
            Player.AddRelativeForce(new Vector3(10, 0, 0));
        if (Input.GetKey("a"))
            Player.AddRelativeForce(new Vector3(-10, 0, 0));


    }
}
