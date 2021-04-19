using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FussingScript : MonoBehaviour
{
    public Button fuseButton;
    public Button screwButton;

   

    public GameObject holder;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        foreach (ContactPoint contact in col.contacts)
        {
             Instantiate(fuseButton, Camera.main.WorldToScreenPoint(contact.point), Quaternion.identity, holder.transform);
            
            

        }
        
    }
}
