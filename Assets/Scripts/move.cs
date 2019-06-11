using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public GameObject begin;
    public GameObject pathway;
    public GameObject pathway2;
    public GameObject sit;
    public GameObject end;
    public GameObject capsule;
    public float speed;
    void Start()
    {
        
    }

    void Update()
    {
        float step = speed * Time.deltaTime;

       // if(capsule.transform.position == begin.transform.position)
        //{
           capsule.transform.position = Vector3.MoveTowards(begin.transform.position, pathway.transform.position, step);
        //}
    }
}
