using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnplatforms : MonoBehaviour
{
    public int platformsperrender;
    public GameObject platform;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < platformsperrender; i++)
        {
            Debug.Log("Creating new trashcan " + i);
            var position = new Vector3(Random.Range(-50f, 50f), Random.Range(-50f, 50f),0f);
            Instantiate(platform, position, Quaternion.identity);
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
