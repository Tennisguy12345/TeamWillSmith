using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody Player;
    public GameObject theCollision;
    protected bool isgrounded;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("d"))
            Player.transform.Translate(new Vector3(10, 0, 0));
        if (Input.GetKey("a"))
        { Player.transform.Translate(new Vector3(-10, 0, 0)); }
                Player.transform.Translate(new Vector3(-10, 0, 0));
        if (isgrounded == true)
        {
            Debug.Log("you can now jump");

            if (Input.GetButtonDown("Jump"))
            {
                Player.AddRelativeForce(new Vector3(0, 100, 0));

            }
        }


    }
    void OnCollisionEnter(Collision theCollision)
    {
        if (theCollision.gameObject.name == "Grass Level")
        {
            isgrounded = true;

        }
    }
    void OnCollisionExit(Collision theCollision)
    {
        if (theCollision.gameObject.name == "Grass Level")
        {
            isgrounded = false;
        }
    }
}
