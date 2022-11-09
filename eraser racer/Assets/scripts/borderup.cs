using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class borderup : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "borderdown")
        {
            transform.position = new Vector3(transform.position.x, 55, transform.position.z);
        }
        else if (collision.gameObject.tag == "borderup")
        {
            transform.position = new Vector3(transform.position.x, -44, transform.position.z);
        }
    }
}
