using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetNote_floor : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D Note) 
    {
        if(Note.tag == "Correct Note") {
            // Debug.Log(lifes_cnt);
            GetNote.loss_life();
        }
        Debug.Log(Note.name);
        Destroy(Note.gameObject);
    }
}
