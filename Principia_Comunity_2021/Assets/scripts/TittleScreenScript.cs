using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TittleScreenScript : MonoBehaviour
{
    [SerializeField]
    public Button[] buttons;

    public Canvas canvi1;
    public Canvas canvi2;
    public GameObject main;
    public GameObject about;
    // Start is called before the first frame update
    void Awake()
    {
     buttons[0].GetComponent<Button>().onClick.AddListener(Play);
     buttons[1].GetComponent<Button>().onClick.AddListener(About);
     buttons[2].GetComponent<Button>().onClick.AddListener(Back);
     main = canvi1.gameObject;
     about = canvi2.gameObject;
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Play()
    {
        Debug.Log("play");
       SceneManager.LoadScene("Custom0");
    }
    
    void About()
    {
        Debug.Log("about");
        main.SetActive(false);
        about.SetActive(true);

    }

    void Back()
    {
        Debug.Log("back");
               
        about.SetActive(false);
        main.SetActive(true);
    }
}
