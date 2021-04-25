using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FFuseDetection : MonoBehaviour
{
    public int triggerInt;
    void Awake()
    {
        triggerInt = 0;
    }
    void Update()
    {
        if(triggerInt <= 1)
        {
            Debug.Log("makes it here");
            Destroy(gameObject.transform.parent.gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        triggerInt+= 1;
    }

    void OnTriggerExit(Collider other)
    {
        triggerInt-= 1;

    }
}
