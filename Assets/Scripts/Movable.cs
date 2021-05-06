using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movable : MonoBehaviour
{
    public Transform destination;
    [SerializeField]
    float moveSpeed = 1f;

    [SerializeField]
    bool isActive = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive)
        {
            Vector3 newPosition = new Vector3(destination.position.x, transform.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, newPosition, moveSpeed * Time.deltaTime);
        }
    
               
    }

    public void MoveObjectToTarget()
    {
        isActive = true;
    }
}
