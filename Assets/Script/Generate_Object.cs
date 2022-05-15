using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate_Object : MonoBehaviour
{
    public GameObject[] objects;
    public Transform[] points;
    public float Ins_time = 1;//先設定成1秒，可以再改
    void Start()
    {
        InvokeRepeating("Ins_Objs",Ins_time,Ins_time);
    }

    void Ins_Objs(){
    //    int Random_Objects = Random.Range(0,objects.Length);
    //    int Ramdom_Points = Random.Range(0,points.Length);

    //    Instantiate(objects[Random_Objects],points[Ramdom_Points].transform.position,points[Ramdom_Points].transform.rotation);
        int[] random_index = {0,1,2,3,4};
        for(int i = 0; i < 5; ++i) {
            int tmp_index = Random.Range(0,5);
            int tmp = random_index[tmp_index];
            random_index[tmp_index] = random_index[i];
            random_index[i] = tmp;
        }
        for(int i = 0; i < 5; ++i) {
            Instantiate(objects[i],points[random_index[i]].transform.position,points[random_index[i]].transform.rotation);
        }

    }
}
