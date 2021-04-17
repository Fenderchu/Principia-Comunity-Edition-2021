using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//test
public class CameraScript : MonoBehaviour
{
    public float speed;
    public float scrollSpeed;
    public bool paused;

    public GameObject worldborder; 
    public GameObject UIhandler;

    private float rightBorder;
    private float leftBorder;
    private float topBorder;
    private float bottomBorder;

    



    // Update is called once per frame
    void Update()
    {



        if (paused != true)
        {
            
        
            float Horizontal = Input.GetAxis("Horizontal");
            float Vertical =  Input.GetAxis("Vertical");
            float Scroll = Input.GetAxis("Mouse ScrollWheel");

            if(Scroll < 0 & gameObject.transform.position.z < -100)
            {
                gameObject.transform.position += new Vector3(0,0,5);
            }
            if(Scroll > 0 & gameObject.transform.position.z > -1200)
            {
                gameObject.transform.position += new Vector3(0,0,-5);
            }

            if(Horizontal > 0 )
            {
                gameObject.transform.position += new Vector3(5,0,0);
            }
            if(Horizontal < 0  )
            {
                gameObject.transform.position += new Vector3(-5,0,0);
            }
            if(Vertical > 0 )
            {
                gameObject.transform.position += new Vector3(0,5,0);
            }
            if(Vertical < 0 )
            {
                gameObject.transform.position += new Vector3(0,-5,0);
            }           

            
        }
    }
}
