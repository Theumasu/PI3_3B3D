using UnityEngine;
using System.Collections;
public class InitialText : MonoBehaviour {
 public float tempo = 5.0f;
 void Update () {
 tempo -= Time.deltaTime;
 }
 void OnGUI () {
 if(tempo>=0){
 GUI.Label(new Rect(Screen.width/2-50,Screen.height/2,200,200), "Texo a ser decidido");
 }
}
}