using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRotate : MonoBehaviour
{
    // Start is called before the first frame update
    public float Time;
    public float TimeControl;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            TimeControl = 1;
        }
        if (TimeControl == 1)
        {
            DoMath();
        }
        if (Time==1f)
        {
            transform.Rotate(5f, 0f, 0f);
        }
        if (Time == 2f)
        {
            transform.Rotate(5f, 0f, 0f);
        }
        if (Time == 3f)
        {
            transform.Rotate(5f, 0f, 0f);
        }
        if (Time == 4f)
        {
            transform.Rotate(5f, 0f, 0f);
        }
        if (Time == 5f)
        {
            transform.Rotate(5f, 0f, 0f);
        }
        if (Time == 6f)
        {
            transform.Rotate(5f, 0f, 0f);
        }
        if (Time == 7f)
        {
            transform.Rotate(5f, 0f, 0f);
        }
        if (Time == 8f)
        {
            transform.Rotate(-5f, 0f, 0f);
        }
        if (Time == 9f)
        {
            transform.Rotate(-5f, 0f, 0f);
        }
        if (Time == 10f)
        {
            transform.Rotate(-5f, 0f, 0f);
        }
        if (Time == 11f)
        {
            transform.Rotate(-5f, 0f, 0f);
        }
        if (Time == 12f)
        {
            transform.Rotate(-5f, 0f, 0f);
        }
        if (Time == 13f)
        {
            transform.Rotate(-5f, 0f, 0f);
        }
        if (Time == 14f)
        {
            transform.Rotate(-5f, 0f, 0f);
        }
        if (Time == 15f)
        {
            TimeControl=0;
            Time = 0;
        }

    }
    void DoMath()
    {
        Time += 1;
        //Debug.Log("Go");
    }
}
