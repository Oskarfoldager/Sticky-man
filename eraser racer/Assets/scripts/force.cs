using UnityEngine;
using System.Collections;

public class force : MonoBehaviour
{
    // Movement speed
    public float speed = 2;
    public Transform playertransform;
    private float timeofnewspeed;

    // Use this for initialization
    void Start()
    {
        timeofnewspeed = Time.time + 10;
        // Fly towards the right
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeofnewspeed)
        {
            Debug.Log("newspeed");
            speed *= 1.4f;
            timeofnewspeed += 10;
        }
        transform.position = new Vector3(transform.position.x,playertransform.position.y,transform.position.z);
    }
}