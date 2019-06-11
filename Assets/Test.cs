using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
   private Animator anim;

    // Start is called before the first frame update
  
    void Awake()
    {
     if (!anim)
     {
       anim = gameObject.GetComponent<Animator>(); 
    }

    }
    void Start()
    {
        anim.Play("MoveBP" , 0 , 0f);
    }

    // Update is called once per frame
    void Update()
    {
       
            
        
        
    }
}
