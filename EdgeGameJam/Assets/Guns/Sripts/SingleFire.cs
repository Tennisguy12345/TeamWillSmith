using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleFire : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject ammo;
    public Vector3 Location;
    public GameObject exitlocation;

    // Update is called once per frame
    void Update()
    {

        Location = exitlocation.transform.position;

        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Get input");
            Instantiate(ammo, Location, Quaternion.identity);
            Debug.Log("Fired");
        }
    }
}
