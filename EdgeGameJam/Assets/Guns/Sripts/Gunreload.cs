using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunreload : MonoBehaviour
{
    // Start is called before the first frame update

    public float appercontroll;
    public float appercontroll2;
    void Appear()
    {
        appercontroll2 += 1;
    }

    public float Time3 = -1;
    public float Time4 = 0;
    public float Movement = -0.1f;
    public float Stop;
    public float rotatestop;
    public float roataetime;
    public float roataetime2 = 1;
    public GameObject Mag;
    public float Time5 = -1;
    public float Time6 = 0;
    public float Stop2;
    public float rotatestop2;
    public float rotatestop3;
    public float roataetime4;
    public float roataetime3;
    public Vector3 Start;
    public GameObject Start2;
    public int reload;


    void DoMoreMath()
    {
        roataetime += 1;
    }
    void DoMoreMath2()
    {
        roataetime4 += 1;
    }
    // Update is called once per frame
    void Update()
    {
        Start = Start2.transform.position;
        if (reload==0)
        {
            if (Input.GetButtonDown("Fire2"))
            {
                Time3 = 0;
                roataetime2 = 0;
                rotatestop3 = 0;
                reload = 1;
            }

        }

        if (roataetime2 == 0 && Stop < 1)
        {
            DoMoreMath();
        }
        if (roataetime == 1 && rotatestop < 1)
        {
            transform.Rotate(-0.893001f, 0, 0);
        }
        if (roataetime == 2 && rotatestop < 1)
        {
            transform.Rotate(-1, 0, 0);
        }
        if (roataetime == 3 && rotatestop < 1)
        {
            transform.Rotate(-1, 0, 0);
        }
        if (roataetime == 4 && rotatestop < 1)
        {
            transform.Rotate(-1, 0, 0);
        }
        if (roataetime == 5 && rotatestop < 1)
        {
            transform.Rotate(-1, 0, 0);
        }
        if (roataetime == 6 && rotatestop < 1)
        {
            transform.Rotate(-1, 0, 0);
        }
        if (roataetime == 7 && rotatestop < 1)
        {
            transform.Rotate(-1, 0, 0);
        }
        if (roataetime == 8 && rotatestop < 1)
        {
            transform.Rotate(-1, 0, 0);
            rotatestop = 1;
        }

        if (Time3 == 0 && Stop < 3)
        {
            DoMath2();
        }
        if (Time3 == 1 && Stop < 3)
        {
            DoMath2();
        }
        if (Time3 == 2 && Stop < 3)
        {
            DoMath2();
        }
        if (Time4 == 1 && Stop < 3)
        {
            transform.Translate(0, Movement, 0);
        }
        if (Time4 == 2 && Stop < 3)
        {
            transform.Translate(0, Movement, 0);
        }
        if (Time4 == 3 && Stop < 3)
        {
            transform.Translate(0, Movement, 0);
        }
        if (Time4 == 4 && Stop < 3)
        {
            transform.Translate(0, Movement, 0);
        }
        if (Time4 == 5 && Stop < 3)
        {
            transform.Translate(0, Movement, 0);
        }
        if (Time4 == 6 && Stop < 3)
        {
            transform.Translate(0, Movement, 0);
        }
        if (Time4 == 7 && Stop < 3)
        {
            transform.Translate(0, Movement, 0);
        }
        if (Time4 == 8 && Stop < 3)
        {
            transform.Translate(0, Movement, 0);
        }
        if (Time4 == 9 && Stop < 3)
        {
            transform.Translate(0, Movement, 0);
        }
        if (Time4 == 10 && Stop < 3)
        {
            transform.Translate(0, Movement, 0);
            Time3 = 1;
            Time4 = 0;
            Stop += 1;
        }
        if (Stop > 2 && rotatestop > 0)
        {
            appercontroll = 1;
            Mag.GetComponent<Renderer>().enabled = false;
            transform.Translate(0, 0, 0.025f);
            Debug.Log("Big");
            Time3 = -1;
            rotatestop = 0;
            Debug.Log("Big");
            roataetime2 = -1;
        }
       
        if (appercontroll == 1&&appercontroll2<50)
        {
            Appear();
        }
        if (Stop > 2 && appercontroll2==20)
        {

            Mag.GetComponent<Renderer>().enabled = true;
            Debug.Log("Big");
            Time5 = 0;
            Stop = 0;
        }
        if (Time5 == 0 && Stop2 < 3)
        {
            DoMath3();
        }
        if (Time5 == 1 && Stop2 < 3)
        {
            DoMath3();
        }
        if (Time5 == 2 && Stop2 < 3)
        {
            DoMath3();
        }
        if (Time5 == 3)
        {
            Time5 = -1;
        }
        if (Time6 == 1 && Stop2 < 3)
        {
            transform.Translate(0, -Movement, 0);
        }
        if (Time6 == 2 && Stop2 < 3)
        {
            transform.Translate(0, -Movement, 0);
        }
        if (Time6 == 3 && Stop2 < 3)
        {
            transform.Translate(0, -Movement, 0);
        }
        if (Time6 == 4 && Stop2 < 3)
        {
            transform.Translate(0, -Movement, 0);
        }
        if (Time6 == 5 && Stop2 < 3)
        {
            transform.Translate(0, -Movement, 0);
        }
        if (Time6 == 6 && Stop2 < 3)
        {
            transform.Translate(0, -Movement, 0);
        }
        if (Time6 == 7 && Stop2 < 3)
        {
            transform.Translate(0, -Movement, 0);
        }
        if (Time6 == 8 && Stop2 < 3)
        {
            transform.Translate(0, -Movement, 0);
        }
        if (Time6 == 9 && Stop2 < 3)
        {
            transform.Translate(0, -Movement, 0);
        }
        if (Time6 == 10 && Stop2 < 3)
        {
            transform.Translate(0, -Movement, 0);
            Time5 += 1;
            Time6 = 0;
            Stop2 += 1;
            roataetime3 = 0;
        }
        if (roataetime3 == 0 && Stop2 > 2&& roataetime4 < 10)
        {
            DoMoreMath2();
        }
        if (roataetime4 == 1 && rotatestop3 < 1 && rotatestop3 > -1)
        {
           
            transform.Rotate(0.893001f, 0, 0);
        }
        if (roataetime4 == 2 && rotatestop3 < 1 && rotatestop3 > -1)
        {
            transform.Rotate(1, 0, 0);
        }
        if (roataetime4 == 3 && rotatestop3 < 1 && rotatestop3 > -1)
        {
            transform.Rotate(1, 0, 0);
        }
        if (roataetime4 == 4 && rotatestop3 < 1 && rotatestop3 > -1)
        {
            transform.Rotate(1, 0, 0);
        }
        if (roataetime4 == 5 && rotatestop3 < 1 && rotatestop3 > -1)
        {
            transform.Rotate(1, 0, 0);
        }
        if (roataetime4 == 6 && rotatestop3 < 1 && rotatestop3 > -1)
        {
            transform.Rotate(1, 0, 0);
        }
        if (roataetime4 == 7 && rotatestop3 < 1 && rotatestop3 > -1)
        {
            transform.Rotate(1, 0, 0);
        }
        if (roataetime4 == 8 && rotatestop3 < 1&& rotatestop3 > -1)
        {
            transform.Rotate(1, 0, 0);
            rotatestop3 = -1;
            Stop2 = 0;
            roataetime3 = 1;
            roataetime4 = 0;
            Mag.transform.position = Start;
            reload = 0;
        }
        if (appercontroll2==50&& appercontroll==1)
        {
            appercontroll2 = 0;
            appercontroll = 0;
            roataetime = 0;
            
        }

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
