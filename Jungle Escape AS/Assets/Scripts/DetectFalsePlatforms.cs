using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectFalsePlatforms : MonoBehaviour
{

    void Update()
    {
          Animator.SetBool("isHit", true);
          Vector3.forward();
    
    }
}
