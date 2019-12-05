using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    // Start is called before the first frame update
    public int Health=100;
    public float Speed = 1;
    public GameObject Enemy;
    void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (Health>9)
        {
            if (collision.gameObject.tag == "Bullet")
            {
                Health -= 10;
            }
        }


    }
    void Update()
    {
        if (Health==0)
        {
            Destroy(Enemy);
        }

    }
}
