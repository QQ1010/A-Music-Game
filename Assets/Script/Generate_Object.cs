using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate_Object : MonoBehaviour
{
    public GameObject[] Q1_answers;
    public GameObject[] Q2_answers;
    public GameObject[] Q3_answers;
    public GameObject[] Q4_answers;
    public GameObject[] Q5_answers;
    public GameObject[] Q6_answers;
    public GameObject[] Q1_objects;
    public GameObject[] Q2_objects;
    public GameObject[] Q3_objects;
    public GameObject[] Q4_objects;
    public GameObject[] Q5_objects;
    public GameObject[] Q6_objects;
    public Transform[] points;
    public float Ins_time = 3;//先設定成1秒，可以再改
    // public float bpm = 60;
    List<GameObject[]> answers = new List<GameObject[]>();
    List<GameObject[]> objects = new List<GameObject[]>();
    int question = 0;
    int note = 0;
    void Start()
    {
        answers.Add(Q1_answers);
        answers.Add(Q2_answers);
        answers.Add(Q3_answers);
        answers.Add(Q4_answers);
        answers.Add(Q5_answers);
        answers.Add(Q6_answers);
        objects.Add(Q1_objects);
        objects.Add(Q2_objects);
        objects.Add(Q3_objects);
        objects.Add(Q4_objects);
        objects.Add(Q5_objects);
        objects.Add(Q6_objects);
        InvokeRepeating("Ins_Objs",Ins_time,Ins_time);
    }

    void Ins_Objs(){
    //    int Random_Objects = Random.Range(0,objects.Length);
    //    int Ramdom_Points = Random.Range(0,points.Length);

    //    Instantiate(objects[Random_Objects],points[Ramdom_Points].transform.position,points[Ramdom_Points].transform.rotation);
        if(note >= answers[question].Length) 
        {
            ++question;
            note = 0;
        }
        int[] random_index = {0,1,2,3,4};
        for(int i = 0; i < 5; ++i) {
            int tmp_index = Random.Range(0,5);
            int tmp = random_index[tmp_index];
            random_index[tmp_index] = random_index[i];
            random_index[i] = tmp;
        }

        GameObject ans = Instantiate(answers[question][note],points[random_index[0]].transform.position,answers[question][note].transform.rotation);
        ans.tag = "Correct Note";
        for(int i = 1; i < 5; ++i) {
            int random_object = Random.Range(0, objects[question].Length);
            // Debug.Log(ans.name);
            // Debug.Log(Q1_objects[random_object].name);
            while(string.Compare(ans.name, 0, objects[question][random_object].name, 0, 3) == 0)
                random_object = Random.Range(0, objects[question].Length);
            Instantiate(objects[question][random_object],points[random_index[i]].transform.position,objects[question][random_object].transform.rotation);
        }
        note++;

    }
}
