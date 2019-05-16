using UnityEngine;
using System.Collections.Generic;


[RequireComponent(typeof(CharacterController))]
public class Position : MonoBehaviour
{
    void Start()
    {
        // deixa o objeto cair
        gameObject.transform.position = new Vector3(-254, 75, 219);
    } 

}
