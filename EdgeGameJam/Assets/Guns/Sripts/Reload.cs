using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reload : MonoBehaviour
{
    public GameObject Mag;
    public float Movement = -0.01f;
    public float Time=1;
    public float Time2 = 0;
    public float Time3 = 1;
    public float Time4 = 0;
    public float Time5 = 1;
    public float Time6 = 0;
    public float Activation = 0;
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {

            Activation = 1;
        }
        if (Activation==1)
        {
            transform.Rotate(-0.893001f, 0, 0);
            transform.Rotate(-1f, 0, 0);
            transform.Rotate(-1f, 0, 0);
            transform.Rotate(-1f, 0, 0);
            transform.Rotate(-1f, 0, 0);
            transform.Rotate(-1f, 0, 0);
            transform.Rotate(-1f, 0, 0);
            transform.Rotate(-1f, 0, 0);
            Debug.Log("Rotate Complete");
            Time3 = 0;
            if (Time3 == 0)
            {
                DoMath2();
            }
            if (Time4 == 1)
            {
                transform.Translate(0, Movement, 0);
            }
            if (Time4 == 16)
            {
                transform.Translate(0, Movement, 0);
            }
            if (Time4 == 31)
            {
                transform.Translate(0, Movement, 0);
            }
            if (Time4 == 46)
            {
                transform.Translate(0, Movement, 0);
            }
            if (Time4 == 61)
            {
                transform.Translate(0, Movement, 0);
            }
            if (Time4 == 76)
            {
                transform.Translate(0, Movement, 0);
            }
            if (Time4 == 91)
            {
                transform.Translate(0, Movement, 0);
            }
            if (Time4 == 106)
            {
                transform.Translate(0, Movement, 0);
            }
            if (Time4 == 121)
            {
                transform.Translate(0, Movement, 0);
            }
            if (Time4 == 136)
            {
                transform.Translate(0, Movement, 0);
                Time3 = 1;
                Time4 = 0;
            }
            Debug.Log("MOvement Complete");
            Mag.SetActive(false);
            Time = 0;
            if (Time == 0)
            {
                DoMath();
            }
            if (Time2 == 20)
            {
                Time = 1;
                Mag.SetActive(true);
                Time5 = 0;
                if (Time5 == 0)
                {
                    DoMath3();
                }
                if (Time6 == 1)
                {
                    transform.Translate(0, -Movement, 0);
                }
                if (Time6 == 16)
                {
                    transform.Translate(0, -Movement, 0);
                }
                if (Time6 == 31)
                {
                    transform.Translate(0, -Movement, 0);
                }
                if (Time6 == 46)
                {
                    transform.Translate(0, -Movement, 0);
                }
                if (Time6 == 61)
                {
                    transform.Translate(0, -Movement, 0);
                }
                if (Time6 == 76)
                {
                    transform.Translate(0, -Movement, 0);
                }
                if (Time6 == 91)
                {
                    transform.Translate(0, -Movement, 0);
                }
                if (Time6 == 106)
                {
                    transform.Translate(0, -Movement, 0);
                }
                if (Time6 == 121)
                {
                    transform.Translate(0, -Movement, 0);
                }
                if (Time6 == 136)
                {
                    transform.Translate(0, -Movement, 0);
                    Time5 = 1;
                    Time6 = 0;
                }
                transform.Rotate(0.893001f, 0, 0);
                transform.Rotate(1f, 0, 0);
                transform.Rotate(1f, 0, 0);
                transform.Rotate(1f, 0, 0);
                transform.Rotate(1f, 0, 0);
                transform.Rotate(1f, 0, 0);
                transform.Rotate(1f, 0, 0);
                transform.Rotate(1f, 0, 0);
                Debug.Log("Finished");
                Time2 = 0;
                
            }
            Activation = 0;
        }
    }
        void DoMath()
        {
            Time2 += 1;
        }
        void DoMath2()
        {
            Time4 += 1;
        }
        void DoMath3()
        {
            Time6 += 1;
        }
    

    
}
