using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickMenu : MonoBehaviour
{
    public GameObject gameController;
    bool isOpen = false;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click() {
        if(isOpen) {
            Debug.Log("Resume");
            Time.timeScale = 1;
            isOpen = false;    
        }
        else {
            Debug.Log("Pause");
            Time.timeScale = 0;
            isOpen = true;
        }
        
        //gameController.pause = true;
    }
}
