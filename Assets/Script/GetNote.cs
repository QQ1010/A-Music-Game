using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetNote : MonoBehaviour
{
    static public GameObject[] lifes;
    static public int lifes_cnt = 2;
    // Start is called before the first frame update
    void Start()
    {
        lifes_cnt = 2;
        lifes = GameObject.FindGameObjectsWithTag("life");
        Debug.Log(lifes_cnt);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D Note) 
    {
        if(Note.tag == "Wrong Note") {
            Debug.Log("Get the wrong note");
            Debug.Log(lifes_cnt);
           loss_life();
        }
        Debug.Log(Note.name);
        Destroy(Note.gameObject);
    }
    static public void loss_life()
    {
        if (lifes_cnt == 0) {
                Debug.Log("You Died");
                SceneManager.LoadScene(2);
        }
        else {
            lifes[lifes_cnt--].SetActive(false);
        }
    }
}
