using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    
    void Start()
    {
       
    }
    void OnCollisionEnter(Collision col){
        if(col.gameObject.name == "player"){//碰到player就消失
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D col){
        Destroy(col.gameObject);
//trigger範圍設到main camera外面，碰到就消失
    }
}
