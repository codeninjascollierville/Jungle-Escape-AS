using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectFalsePlatforms : MonoBehaviour
{
bool isGrounded = false;
    void Update()
    {
          isGrounded = Physics.Raycast(transform.position, transform.forward, 3, 1<<8);
        Debug.DrawRay(transform.position, transform.forward *3, Color.blue);
        if(isGrounded){
            print("stop");
            
        }
        else{
            print("all good");
        }
          //Animator.SetBool("isHit", true);
          //Vector3.forward();
    
    }
}
