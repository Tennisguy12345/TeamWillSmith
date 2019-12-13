using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyCheck : MonoBehaviour
{
    // Start is called before the first frame update
    public int show;
    public int show2;
    public int show3;
    Text jump;
 
 void Update()
    {
        if (show2==0)
        {
            if (GameObject.Find("enemy cube(Clone)") == null)
            {
                show += 1;
                Debug.Log("show");
            }
            if (GameObject.Find("enemy cube") == null)
            {
                show += 1;
                Debug.Log("show");
                show2 = 1;
            }
        }

        if (GameObject.Find("enemy cube") == null)
        {
            show += 1;
            Debug.Log("show");
        }
        if (show > 100)
        {
            Destroy(GameObject.Find("Plane (3)"));
            
            GameObject.Find("Text (TMP)").transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            GameObject.Find("Text (TMP)").transform.localScale = new Vector3(0, 0, 0);

        }
    }
}
