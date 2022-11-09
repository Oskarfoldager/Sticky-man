using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bob : MonoBehaviour
{
    public Animator animator;
    public bool IsGroundeder;
    
    void Start()
    {
       // animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        IsGroundeder = true;

        if(Input.GetKeyUp(KeyCode.F)){
            IsGroundeder=false;
        }
        Debug.Log("IsGrounder");

        if(IsGroundeder==true)
        animator.Play(0);

        if(IsGroundeder==false){
            animator.Play(1);
        }
        



    }
}


