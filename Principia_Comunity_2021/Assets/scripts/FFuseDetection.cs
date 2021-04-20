using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FFuseDetection : MonoBehaviour
{
    private int triggerInt;
    void Awake()
    {
        triggerInt = 2;
    }
    void Update()
    {
        if(triggerInt < 2)
        {
            Destroy(gameObject, 0.1f);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        triggerInt++;
        Debug.Log(triggerInt);
    }

    void OnTriggerExit(Collider other)
    {
        triggerInt--;
    }
}
