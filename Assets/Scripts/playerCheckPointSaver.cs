using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCheckPointSaver : MonoBehaviour
{

    public Vector3 checkpoint;

    // Start is called before the first frame update
    void Start()
    {
        checkpoint = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
