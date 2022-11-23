using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerups : MonoBehaviour
{
    // Start is called before the first frame update
    public float timer;
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
        case "Slower":
        Turtle();
        break;
        }
    }
    public void Kaninchen()
    {
        StartCoroutine(FasterCoroutine());
    }
    public void Turtle()
    {
        StartCoroutine(SlowerCoroutine());
    }
    IEnumerator FasterCoroutine()
    {
        momentum.maxspeed = 20;
        yield return new WaitForSeconds(20);
        momentum.maxspeed = 10;
    }
    IEnumerator SlowerCoroutine()
    {
        momentum.maxspeed = 5;
        yield return new WaitForSeconds(20);
        momentum.maxspeed = 10;
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
