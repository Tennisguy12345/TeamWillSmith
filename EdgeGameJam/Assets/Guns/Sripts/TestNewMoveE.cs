using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestNewMoveE : MonoBehaviour
{
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {

    }
    void Update()
    {
        transform.LookAt(player);
        transform.Translate(0, 0, 0.009f);
    }

}
