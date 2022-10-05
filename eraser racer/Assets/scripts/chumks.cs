using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chumks : MonoBehaviour
{
    public int platformsperrender;
    public GameObject platform;
    private int chunknumber;
    List<float> firstsetofnumbers = new List<float>() { 5.8f, 37.6f};


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
        Debug.Log("OnCollisionEnter2D");
            switch (col.gameObject.tag)
            {
                case "chunk1":
                    for (int i = 0; i < platformsperrender; i++)
                    {
                    chunknumber = 1;
                        Debug.Log("Creating new trashcan " + i);
                        var position = new Vector3(Random.Range(5.8f, 37.6f), Random.Range(-10.7f, 20.4f), 0f);
                        Instantiate(platform, position, Quaternion.identity);
                    }
                    break;
                case "chunk2":
                    chunknumber = 2;
                    for (int i = 0; i < platformsperrender; i++)
                    {
                        Debug.Log("Creating new trashcan " + i);
                        var position = new Vector3(Random.Range(firstsetofnumbers[1] * (chunknumber - 1),firstsetofnumbers[1] * (chunknumber - 1) + 31.8f), Random.Range(-10.7f, 20.4f), 0f);
                        Instantiate(platform, position, Quaternion.identity);
                    }
                    break;
                case "chunk3":
                chunknumber = 3;
                for (int i = 0; i < platformsperrender; i++)
                {
                    Debug.Log("Creating new trashcan " + i);
                    var position = new Vector3(Random.Range(firstsetofnumbers[1] * (chunknumber - 1), firstsetofnumbers[1] * (chunknumber - 1) + 31.8f), Random.Range(-10.7f, 20.4f), 0f);
                    Instantiate(platform, position, Quaternion.identity);
                }
                break;
                case "chunk4":
                chunknumber = 4;
                for (int i = 0; i < platformsperrender; i++)
                {
                    Debug.Log("Creating new trashcan " + i);
                    var position = new Vector3(Random.Range(firstsetofnumbers[1] * (chunknumber - 1), firstsetofnumbers[1] * (chunknumber - 1) + 31.8f), Random.Range(-10.7f, 20.4f), 0f);
                    Instantiate(platform, position, Quaternion.identity);
                }
                break;
                case "chunk5":
                    break;
                case "chunk6":
                    break;
                case "chunk7":
                    break;
            }

        
    }
}
