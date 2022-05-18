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
        Debug.Log(GetNote.WA);
        if(Note.tag == "Correct Note" && GetNote.WA == false) {
            // Debug.Log(lifes_cnt);
            GetNote.loss_life();
        }
        if(Note.tag == "Correct Note" && GetNote.WA == true)
        {
            GetNote.WA = false;
        }
        // Debug.Log(Note.name);
        Destroy(Note.gameObject);
    }
}
