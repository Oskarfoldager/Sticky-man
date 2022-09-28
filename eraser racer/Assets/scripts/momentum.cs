using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class momentum : MonoBehaviour
{
    public float maxspeed;
    public Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(rb2d.velocity.x > maxspeed){
            rb2d.velocity = new Vector2(maxspeed,rb2d.velocity.y);
        }
        else
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x + 0.1f, rb2d.velocity.y);

        }
    }
}
