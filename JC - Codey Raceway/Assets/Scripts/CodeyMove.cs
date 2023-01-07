using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CodeyMove : MonoBehaviour
{
    public float Speed = 15f;
    Animator anim;
    public bool running = false;
    public bool canMove = false;
    public Vector3 move;
    public float _rotationSpeed = 50f;
    CharacterController cc;
    void Start()
    {
        anim = GetComponent<Animator>();
        cc = GetComponent<CharacterController>();
    }
    void Update()
    {
       
        if (canMove)
        {

            float vertical = Input.GetAxis("Vertical");
            float horizontal = Input.GetAxis("Horizontal");            
            Vector3 rotation = new Vector3(0, horizontal * _rotationSpeed * Time.deltaTime, 0);
            move = transform.forward * vertical;
            transform.Rotate(rotation);
            cc.Move(move.normalized * Speed * Time.deltaTime);

            anim.SetBool("isRunning", move != Vector3.zero);
        }
        
    }
}