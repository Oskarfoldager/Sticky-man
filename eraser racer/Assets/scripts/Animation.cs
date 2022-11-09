using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
   Animator animator;

   void start() {
        animator = GetComponent<Animator>();
   }

   void update (){
    if(Input.GetKeyDown(KeyCode.D)) {
        animator.Play("1");
    }
    else if(Input.GetKeyDown(KeyCode.A))
    {
        animator.Play("2");
    }
   }
}
