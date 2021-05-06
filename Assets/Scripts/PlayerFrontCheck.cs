using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFrontCheck : MonoBehaviour
{
    [SerializeField]
    bool isObjectDetected;

    Collider otherObject;

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Movable")
        {
            if (!isObjectDetected)
            {
                Debug.Log("movable object detected");
                isObjectDetected = true;
                otherObject = other;
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Movable")
        {
            isObjectDetected = false;
        }
    }

    public bool IsDetected()
    {
        return isObjectDetected;
    }

    public Collider GetCollisionObject()
    {
        return otherObject;
    }

}
