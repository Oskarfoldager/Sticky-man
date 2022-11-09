using UnityEngine;
using System.Collections;

public class force : MonoBehaviour
{
    // Movement speed
    public float speed = 2;
    public Transform playertransform;

    // Use this for initialization
    void Start()
    {
        // Fly towards the right
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x,playertransform.position.y,transform.position.z);
    }
}