using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    // Start is called before the first frame update
    public int health = 20;
    public float Speed = 1;
    
    void OnCollisionEnter(UnityEngine.Collision collision)
    {

        if (health>0)
        {
            if (collision.gameObject.tag == "Enemy")
            {
                health -= 1;
            }
        }

        


    }
    void Update()
    {

    }
}
