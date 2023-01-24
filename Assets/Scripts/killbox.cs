using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killbox : MonoBehaviour
{

    public string playerTag;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            other.gameObject.SetActive(false);
            other.transform.position = other.GetComponent<playerCheckPointSaver>().checkpoint;
            other.gameObject.SetActive(true);
        }
    }
}
