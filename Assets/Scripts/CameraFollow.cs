using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 0.1f;
    [SerializeField]
    float xOffset = 0f;
    [SerializeField]
    float yOffset = 0f;
    [SerializeField]
    float zOffset = 5f;
    public Transform target; // Drop the player in the inspector of the camera

    void Update()
    {
        Vector3 newPosition = new Vector3(target.position.x - xOffset, target.position.y + yOffset, zOffset);
        //Vector3 newPosition = new Vector3(target.position.x - xOffset, target.position.y + yOffset, target.position.z - zOffset);
        transform.position = Vector3.Lerp(transform.position, newPosition, moveSpeed * Time.deltaTime);
    }

}
