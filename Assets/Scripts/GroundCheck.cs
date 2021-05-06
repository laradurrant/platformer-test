using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    [SerializeField]
    bool grounded;

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Ground")
        {
            if (!grounded)
            {
                Debug.Log("grounded");
                grounded = true;
            }
        }
    }

   void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Ground")
        {
            grounded = false;
        }
    }

    public bool IsGrounded()
    {
        return grounded;
    }
}
