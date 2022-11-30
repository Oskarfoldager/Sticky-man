using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class distancetoeraser : MonoBehaviour
{
    public Transform player;
    public Transform eraser;
    public Text distancetopl;
    private float dist;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dist = Mathf.Round(player.position.x - eraser.position.x);
        distancetopl.text = "distance to eraser " + dist + " cm";
    }
}
