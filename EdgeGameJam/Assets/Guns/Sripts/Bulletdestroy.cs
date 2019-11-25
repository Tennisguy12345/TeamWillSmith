using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletdestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(GameObject.Find("bullet(Clone)"));
        }
        if (collision.gameObject.tag == "Ground")
        {
            Destroy(GameObject.Find("bullet(Clone)"));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
