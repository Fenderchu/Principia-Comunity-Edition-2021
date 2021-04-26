using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FFuseDetection : MonoBehaviour
{
    public int triggerInt;

    private List<GameObject> objects;

    public Button fuseButton;


    void Awake()
    {
        triggerInt = 0;
        fuseButton.GetComponent<Button>().onClick.AddListener(Fuse);
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

        if(other.tag == "Object")
        {
            objects.Add(other.gameObject);
        }
    }

    void OnTriggerExit(Collider other)
    {
        triggerInt-= 1;
        if(other.tag == "Object")
        {
            objects.Remove(other.gameObject);
        }
    }

    void Fuse()
    {
        objects[0].gameObject.AddComponent<FixedJoint>();
        objects[0].gameObject.GetComponent<FixedJoint>().enablePreprocessing = false;
        objects[0].gameObject.GetComponent<FixedJoint>().connectedBody = objects[1].gameObject.GetComponent<Rigidbody>();
    }

    
}
