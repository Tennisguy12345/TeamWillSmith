using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyscript : MonoBehaviour
{
    public GameObject target; //the enemy's target
    public float moveSpeed = 5; //move speed
    public float rotationSpeed = 5; //speed of turning
    private Vector3 mytransform;

    // Start is called before the first frame update
    void Start()
    {
        mytransform = target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(mytransform
            - transform.position), rotationSpeed * Time.deltaTime);
        transform.position += transform.forward* Time.deltaTime * moveSpeed;
    }

}
