using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetNote : MonoBehaviour
{
    GameObject[] lifes;
    int lifes_cnt;
    // Start is called before the first frame update
    void Start()
    {
        lifes = GameObject.FindGameObjectsWithTag("life");
        lifes_cnt = lifes.Length-1;
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
            if (lifes_cnt == 0) {
                Debug.Log("You Died");
                SceneManager.LoadScene(2);
            }
            else {
                lifes[lifes_cnt--].SetActive(false);
            }
        }
        Debug.Log(Note.name);
        Destroy(Note.gameObject);
    }
}
