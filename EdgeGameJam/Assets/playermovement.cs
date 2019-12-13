using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody Player;
    public GameObject theCollision;
    public bool isgrounded;
    public GameObject level2;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.D))
        {
            Player.transform.Rotate(new Vector3(0, 2, 0));

        }

        if (Input.GetKey(KeyCode.A))
        {
            Player.transform.Rotate(new Vector3(0, -2, 0));

        }
        if (Input.GetKey(KeyCode.W))
        {
            Player.transform.Translate(new Vector3(0, 0, 0.1f));

        }

        if (Input.GetKey(KeyCode.S))
        {
            Player.transform.Translate(new Vector3(0,0,-0.1f));

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Player.transform.Rotate(new Vector3(0, 2, 0));
 
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Player.transform.Rotate(new Vector3(0, -2, 0));

        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Player.transform.Translate(new Vector3(0, 0, 0.1f));
           
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            Player.transform.Translate(new Vector3(0, 0, -0.1f));
        
        }


    }
    private void FixedUpdate()
    {
        if (isgrounded == true)
        {
            //Debug.Log("you can now jump");

            if (Input.GetButtonDown("Jump"))
            {
                Player.AddRelativeForce(new Vector3(0, 200, 0));

            }
        }
    }
    void OnCollisionEnter(Collision theCollision)
    {
        if (theCollision.gameObject.tag == "Ground")
        {
            isgrounded = true;

        }
        if (theCollision.gameObject.tag == "transporter")
        {
            player.transform.position = level2.transform.position;
            

        }
    }
    void OnCollisionExit(Collision theCollision)
    {
        if (theCollision.gameObject.tag == "Ground")
        {
            isgrounded = false;
        }
    }
    
}   


