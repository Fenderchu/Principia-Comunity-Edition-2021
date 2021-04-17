using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class worldborderscript : MonoBehaviour
{
    public float right;
    public float left;
    public float top;
    public float bottom;

    public GameObject UIhandler;
    [SerializeField]
    public GameObject[] borders;

    private Vector3 sizer; 
    private Vector3 mover;



    // Start is called before the first frame update
    void Awake()
    {
 
    }

    // Update is called once per 
    void Update()
    {
        right =  UIhandler.GetComponent<MainUIHandeler>().sliders[0].value;
        left =  UIhandler.GetComponent<MainUIHandeler>().sliders[1].value;
        top =  UIhandler.GetComponent<MainUIHandeler>().sliders[2].value;
        bottom =  UIhandler.GetComponent<MainUIHandeler>().sliders[3].value;
        if(UIhandler.GetComponent<MainUIHandeler>().saveBorderSize)
        {
            sizer = new Vector3(right+left, top+bottom, 0);
            mover = new Vector3(right-left, top-bottom, 0);
            gameObject.transform.position += mover;
            gameObject.transform.localScale += sizer;
            UIhandler.GetComponent<MainUIHandeler>().saveBorderSize = false;
        }
    }
}
