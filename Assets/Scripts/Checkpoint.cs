using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{

    public string playerTag;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            other.gameObject.GetComponent<playerCheckPointSaver>().checkpoint = gameObject.transform.position;
        }
    }

}
