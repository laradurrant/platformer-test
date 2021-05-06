using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOutOfBounds : MonoBehaviour
{
    [SerializeField]
    string levelName;
    LevelManager lm;

    private void Start()
    {
        lm = FindObjectOfType<LevelManager>();
        if (!lm)
        {
            Debug.Log("Couldn't find level manager");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        lm.LoadLevel(levelName);
    }
}
