using UnityEngine;
using System.Collections.Generic;


[RequireComponent(typeof(CharacterController))]
public class Move : MonoBehaviour
{


    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;

    private Vector3 moveDirection = Vector3.zero;
    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();

        // deixa o objeto cair
        gameObject.transform.position = new Vector3(-3, 1, -6);
    }

    void Update()
    {
        if (controller.isGrounded)
        {
            // quando no chão
            // mover-se na direção dos eixos

            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection = moveDirection * speed;

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }

        // gravidade
        moveDirection.y = moveDirection.y - (gravity * Time.deltaTime);

        // movimentação
        controller.Move(moveDirection * Time.deltaTime);
 } 

}
