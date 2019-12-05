using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawn : MonoBehaviour
{
    public Transform enemy;
    public int amount = 30;
    public float offset = 2; 
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Afterwait", 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void Afterwait()
    {
        for (int enemycount = 0; enemycount<amount; enemycount++)
         {
            Debug.Log(enemycount);
            Instantiate(enemy, new Vector3(transform.position.x + (enemycount* offset), transform.position.y, transform.position.z), Quaternion.identity);
            
        }
    }
}   
    