using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{

    public float speed;
    public float jumpHeight = 10;


    [SerializeField]
    private float jumpDelay = 0.3f;

    private Rigidbody rb;       
    private GroundCheck gc;
    private PlayerFrontCheck fc;
    private float jumped;

    

   
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (!rb)
        {
            Debug.Log("Couldn't find Rigidbody Component on Player");
        }
        gc = GetComponentInChildren<GroundCheck>();
        if (!gc)
        {
            Debug.Log("Couldn't find GroundCheck Component in Player's Children");
        }
        fc = GetComponentInChildren<PlayerFrontCheck>();
        if (!fc)
        {
            Debug.Log("Couldn't find FrontCheck Component in Player's Children");
        }
        jumped = Time.time;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Jump"))
        {
            if (gc.IsGrounded() && Time.time > jumped + jumpDelay)
            {
                jumped = Time.time;
                rb.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
                Debug.Log("jumping");

            }

        }

        if(Input.GetKeyDown(KeyCode.E) || Input.GetButtonDown("Fire1"))
        {
            if (fc.IsDetected())
            {
                Debug.Log("Moving the object");
                Collider other = fc.GetCollisionObject();
                if (other)
                {
                    other.GetComponent<Movable>().MoveObjectToTarget();

                }
            }
        }

    }

   void FixedUpdate()
    {


        //Store the current horizontal input in the float moveHorizontal.
        float moveHorizontal = Input.GetAxis("Horizontal");

        //Store the current vertical input in the float moveVertical.
        float moveVertical = Input.GetAxis("Vertical");

        //Use the two store floats to create a new Vector2 variable movement.
        Vector3 movement;
        movement.x = moveHorizontal;
        movement.y = 0;
        movement.z = moveVertical;
        

        // rotate the player
        if (movement != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement.normalized), 0.2f);
        }

        // Move the player
        transform.Translate(movement * speed * Time.deltaTime, Space.World);

    }
}