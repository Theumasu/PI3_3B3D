using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BlinkLight : MonoBehaviour {

  public float timer = 1;
   public Light light;

   void Start()
   {
       StartCoroutine(LightChanging());
   }
   
  IEnumerator LightChanging()
  {
      for(;;)
      {
      light.enabled = !light.enabled;
      yield return new WaitForSeconds(timer);
      }

  }
   }
