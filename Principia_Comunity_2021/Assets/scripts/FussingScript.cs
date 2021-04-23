using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FussingScript : MonoBehaviour
{
    public GameObject fuseButton;
    public Button screwButton;

   

    public GameObject holder;

    private bool waitActive;

    // Start is called before the first frame update
    void Start()
    {
        waitActive = false;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if(waitActive)
        {
            StartCoroutine(Spawning(col));
            waitActive = true;
        }

        
    }
    
    IEnumerator Spawning(Collision col)
    {
        foreach (ContactPoint contact in col.contacts)
        {
            if(col.gameObject.tag != "fuser")
            {

                GameObject newButton = Instantiate(fuseButton, Camera.main.WorldToScreenPoint(contact.point), Quaternion.identity, holder.transform);
                newButton.transform.GetChild(0).gameObject.transform.position = new Vector3 (contact.point.x,contact.point.y, contact.point.z);
            }

        }
        waitActive = false;
        yeild return new WaitForSeconds(1);
    }

 
}
