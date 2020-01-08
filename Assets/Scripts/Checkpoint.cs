using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public CheckpointManger chMgr;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Ball") 
        {
            chMgr.SetNewCheckpoint(transform.position);
            Debug.Log("Checkpoint reached!");
        }
    }
}
