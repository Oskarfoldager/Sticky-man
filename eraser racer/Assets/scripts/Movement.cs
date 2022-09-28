using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2 playervector;
    public float movementspeed;
    public float jumpspeed;
    public bool touchground;
    public BoxCollider2D bx2d;
    public Transform playertransform;

    public Collider2D whathit;

    public Vector2 velocity;


    [SerializeField] private LayerMask groundlm;
    // Start is called before the first frame update
    void Start()
    {

}



        
        

            //If the GameObject's name matches the one you suggest, output this message in the console




            // Update is called once per frame
            void Update()
    {
        if (isgrounded() && Input.GetKey(KeyCode.Space) && touchground == false)
        {
           
              rb.velocity = new Vector2(rb.velocity.x,jumpspeed);
        }
        



    }
    private bool isgrounded()
    {
          float extraheight = .02f;
    RaycastHit2D raycastHit = Physics2D.Raycast(bx2d.bounds.center, Vector2.down, bx2d.bounds.extents.y + extraheight, groundlm);
        Color raycolor;
        if (raycastHit.collider != null){
            raycolor = Color.green;
            touchground = false;
        }
        else
        {
            raycolor = Color.red;
            touchground = true;
        }
        Debug.DrawRay(bx2d.bounds.center, Vector2.down * (bx2d.bounds.extents.y + extraheight));
        Debug.Log(raycastHit.collider);
        whathit = raycastHit.collider;
        Debug.Log(whathit + "hey");
        return raycastHit.collider != null;
    }
}

