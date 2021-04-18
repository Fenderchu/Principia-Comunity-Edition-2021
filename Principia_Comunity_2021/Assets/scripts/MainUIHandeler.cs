using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainUIHandeler : MonoBehaviour
{
    [SerializeField]
    public Button[] buttons;
    [SerializeField]
    public Canvas[] canvi;
    [SerializeField]
    public Slider[] sliders;

    //public ScrollView objectWindow;
   // public Panel objects;

    public GameObject overlay;
    public GameObject camera1;
    public GameObject worldborder;

    public float defauldCameraPosz;
    public bool saveBorderSize;

    private float holdCamerax;
    private float holdCameray;
    private float holdCameraz;

    private float right;
    private float left;
    private bool paused;


    

    

    // Start is called before the first frame update
    void Awake()
    {
        saveBorderSize = true;
        paused = false;
        buttons[0].GetComponent<Button>().onClick.AddListener(Settings);
        buttons[1].GetComponent<Button>().onClick.AddListener(Back1);
        buttons[2].GetComponent<Button>().onClick.AddListener(General);
        buttons[3].GetComponent<Button>().onClick.AddListener(World);
        buttons[4].GetComponent<Button>().onClick.AddListener(SaveBorderSize);
        buttons[5].GetComponent<Button>().onClick.AddListener(OpenObjectMenu);
        right = worldborder.GetComponent<worldborderscript>().right;
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Settings()
    {
        camera1.GetComponent<CameraScript>().paused = true;
        holdCamerax = camera1.transform.position.x;
        holdCameray = camera1.transform.position.y;
        holdCameraz = camera1.transform.position.z;
        camera1.transform.position = new Vector3(0, 0, defauldCameraPosz);
        canvi[0].gameObject.SetActive(false);
        overlay.SetActive(true);
        overlay.transform.position = new Vector3(camera1.transform.position.x,camera1.transform.position.y,overlay.transform.position.z);
        canvi[1].gameObject.SetActive(true);

    }

    void Back1()
    {
        camera1.GetComponent<CameraScript>().paused = false;
        camera1.transform.position = new Vector3(holdCamerax, holdCameray, holdCameraz);
        canvi[1].gameObject.SetActive(false);
        overlay.SetActive(false);
        canvi[0].gameObject.SetActive(true);

    }
    
    void General()
    {

    }

    void World()
    {
        sliders[0].transform.position = new Vector3(-100,60,0);
    }

    void SaveBorderSize()
    {
        saveBorderSize = true;
    }

    void OpenObjectMenu()
    {

    }
    
 }
