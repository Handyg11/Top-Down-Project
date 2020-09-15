// using System.Collections;
// using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class animationStateController : MonoBehaviour
{
    Animator animator;
    public CharacterController controller;
    public float speed = 3f;
    public Transform player;
    public float analogSensitivity = 1f;
    
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if(EventSystem.current.IsPointerOverGameObject())
            return;
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        float axisX = Input.GetAxis("Horizontal Rotate") * analogSensitivity * Time.deltaTime;
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);
        
        
        if( x > 0.5f ||  z > 0.5f || x < -0.5f  || z < -0.5f){
            animator.SetBool("isRunning",true);
            animator.SetBool("isWalking",false);
        }
        else{
            animator.SetBool("isWalking",true);
            animator.SetBool("isRunning",false);
        }

        if(axisX > 0){
           player.Rotate(Vector3.up * axisX);
        }else if(axisX < 0){
            player.Rotate(Vector3.down * -axisX);
        }
        
        if(x == 0 && z == 0){
            animator.SetBool("isWalking",false);
            animator.SetBool("isRunning",false);
        }
        
    }

}
