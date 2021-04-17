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

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(UIhandler.GetComponent<MainUIHandeler>().saveBorderSize)
        {
            rightBorder = worldborder.GetComponent<worldborderscript>().right + 400;
            leftBorder = (worldborder.GetComponent<worldborderscript>().left + 400) * -1;
            topBorder = worldborder.GetComponent<worldborderscript>().top + 600;
            bottomBorder = (worldborder.GetComponent<worldborderscript>().bottom + 600) * -1;
            UIhandler.GetComponent<MainUIHandeler>().saveBorderSize = false;
        }

        if (paused != true)
        {
            
        
            float Horizontal = Input.GetAxis("Horizontal");
            float Vertical =  Input.GetAxis("Vertical");
            float Scroll = Input.GetAxis("Mouse ScrollWheel");

            if(Scroll < 0 & gameObject.transform.position.z < -150)
            {
                gameObject.transform.position += new Vector3(0,0,5);
            }
            if(Scroll > 0 & gameObject.transform.position.z > -1200)
            {
                gameObject.transform.position += new Vector3(0,0,-5);
            }

            if(Horizontal > 0 & gameObject.transform.position.x < rightBorder)
            {
                gameObject.transform.position += new Vector3(5,0,0);
            }
            if(Horizontal < 0 & gameObject.transform.position.x > leftBorder)
            {
                gameObject.transform.position += new Vector3(-5,0,0);
            }
            if(Vertical > 0 & gameObject.transform.position.y < topBorder)
            {
                gameObject.transform.position += new Vector3(0,5,0);
            }
            if(Vertical < 0 & gameObject.transform.position.y > bottomBorder)
            {
                gameObject.transform.position += new Vector3(0,-5,0);
            }           

            
        }
    }
}
