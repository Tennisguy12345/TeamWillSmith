using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleFire : MonoBehaviour
{
    // Start is called before the first frame update

    //public GameObject ammo;
    //public Vector3 Location;
    //public GameObject exitlocation;
    //public Rigidbody my;
    //public float speed = 1000;

    //// Update is called once per frame
    //void Update()
    //{

    //    Location = exitlocation.transform.position;

    //    if (Input.GetButtonDown("Fire1"))
    //    {
    //        Debug.Log("Get input");
    //        Instantiate(ammo, Location, Quaternion.identity);
    //        Debug.Log("Fired");

    //        Debug.Log("Fired");
    //    }

    //}
    //void FixedUpdate()
    //{
    //    if (Input.GetButtonDown("Fire1"))
    //    {
    //        my.AddRelativeForce(0, 0, speed * Time.fixedDeltaTime, ForceMode.Impulse);
    //    }

    //}
    public GameObject projectile;
    public GameObject Bullet2;
    public Transform Fire;
    public Vector3 Bullet;
    public int Ammo;
    public int Ammo2;
    public int Ammo3;
    public int Destroy1;
    public int Destroy2;
    public int check;

    void Update()
    {
        Bullet = Bullet2.transform.position;
        if (check==0)
        {
            if (Ammo < 10)
            {
                if (Input.GetButtonDown("Fire1"))
                {
                    GameObject bullet = Instantiate(projectile, Bullet2.transform.position, Quaternion.identity) as GameObject;

                    bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 10);

                    bullet.transform.parent = Fire;
                    bullet.transform.localRotation = Quaternion.identity;
                    bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 20);

                    Ammo += 1;
               

                }
            }
        
        }
        if (Ammo==10)
        {
            check = 1;
        }
        if (Input.GetButtonDown("Fire2"))
        {
            Ammo2 = 1;
        }
        if (Ammo2 == 1)
        {
            DoMath();
        }
        if (Ammo3 == 76)
        {
            Ammo = 0;
            Ammo2 = 0;
            Ammo3 = 0;
            check = 0;
        }
    }
    void DoMath()
    {
        Ammo3 += 1;
    }
    void DoBigMath()
    {
        Destroy2 += 1;
    }

}
