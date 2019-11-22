using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reload : MonoBehaviour
{
    public GameObject Magazine;
    public Vector3 Loaded;
    public GameObject unloaded;
    public GameObject loaded;
    public float ReloadControll;
    public float Release;
    public float Start1;
    public float movement = -0.01f;
    // Start is called before the first frame update
    void Start()
    {
        Start1 = 1;
        if (Start1 == 1)
        {
            Instantiate(Magazine, Loaded, Quaternion.identity);
            Debug.Log("Test1");
            Start1 = 0;
            Debug.Log("Test2");
        }
    }

    // Update is called once per frame
    void Update()
    {

        Loaded = loaded.transform.position;
        
        if (Input.GetButtonDown("Fire2"))
        {
            ReloadControll = 1;
        }
        if (ReloadControll == 1)
        {
            DoMath();
        }
        if (Release == 2)
        {
            Magazine.transform.Translate(0, movement, 0);
        }
        if (Release == 3)
        {
            Magazine.transform.Translate(0, movement, 0);
        }
        if (Release == 4)
        {
            Magazine.transform.Translate(0, movement, 0);
        }
        if (Release == 5)
        {
            Magazine.transform.Translate(0, movement, 0);
        }
        if (Release == 6)
        {
            Magazine.transform.Translate(0, movement, 0);
        }
        if (Release == 7)
        {
            Magazine.transform.Translate(0, movement, 0);
        }
        if (Release == 8)
        {
            Magazine.transform.Translate(0, movement, 0);
        }
        if (Release == 9)
        {
            Magazine.transform.Translate(0, movement, 0);
        }
        if (Release == 10)
        {
            Magazine.transform.Translate(0, movement, 0);
        }
        if (Release == 11)
        {
            Magazine.transform.Translate(0, movement, 0);
            Destroy(Magazine);
        }
        if (Release == 12)
        {
            ReloadControll = 0;
            Release = 0;
        }

    }
    void DoMath()
    {
        Release += 1;
    }
}
