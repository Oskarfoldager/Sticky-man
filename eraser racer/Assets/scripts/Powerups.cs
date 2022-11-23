using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerups : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
      switch (col.gameObject.tag)
      {
        case "Faster":
        Kaninchen();
        break;
        case"rocket":
        rocketship();
        break;
        case"GravityChange":
        Gravityswitch();
        break;
      }
    }
    public void Kaninchen()
    {

    }
    public void rocketship()
    {

    }
    public void Gravityswitch()
    {
        if(transform.eulerAngles == new Vector3 (0, 180, 180))
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
            Physics2D.gravity = new Vector2(0, -9.8f);
        }
        else
        {
            transform.eulerAngles = new Vector3(0, 180, 180);
            Physics2D.gravity = new Vector2(0, 9.8f);
        }

    }

}
