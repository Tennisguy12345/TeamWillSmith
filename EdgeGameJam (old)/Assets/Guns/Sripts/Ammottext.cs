using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ammottext : MonoBehaviour
{
    public GameObject textObject;
    Text textField;
    public int Ammo;
    public int Ammo2;
    public GameObject textObject2;
    Text textField2;

    Image crosshair;

    public int Ammo3;    // Start is called before the first frame update
    void Start()
    {
        textField2 = textObject2.GetComponent<Text>();
        textField = textObject.GetComponent<Text>();

        crosshair = GetComponent<Image>();
        Ammo = 10;

    }

    // Update is called once per frame
    void Update()
    {

        textField.text = Ammo.ToString() + " / 10";
        if (Ammo < 11&&Ammo>0)
        {
            if (Input.GetButtonDown("Fire1"))
            {

                Ammo -= 1;
            }
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
            Ammo = 10;
            Ammo2 = 0;
            Ammo3 = 0;

        }
    }
    void DoMath()
    {
        Ammo3 += 1;
    }
}

