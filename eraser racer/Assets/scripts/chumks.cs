using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chumks : MonoBehaviour
{
    public int platformsperrender;
    public int powerupssperrender;
    public Vector3 offsetcenterplayer;
    public Transform chunks;
    public Transform chunk1right;
    public float chunkdistance;
    private float chunkrightx;
    private float chunkrighty;
    public GameObject paperandborders;
    public Vector2 offsetonpaper;
    public GameObject power1;
    public GameObject power2;
    public GameObject power3;
    public GameObject platform1;
    public GameObject platform2;
    public GameObject platform3;
    public GameObject platform4;
    public GameObject platform5;
    public GameObject platform6;
    public GameObject platform7;
    public GameObject platform8;
    public GameObject platform9;
    public GameObject platform10;
    public GameObject platform11;
    public GameObject platform12;
    public List<GameObject> powerups;
    public List<GameObject> platforms;


    // Start is called before the first frame update
    void Start()
    {
        powerups = new List<GameObject>() { power1, power2,power3};
        platforms = new List<GameObject>() { platform1, platform2, platform3, platform4, platform5, platform6, platform7, platform8, platform9, platform10, platform11, platform12 };
        /*
        for (int i = 0; i < 500; i++)
        {
            var position = new Vector3(Random.Range(300f,0f),Random.Range(300f, -300f), 0f);
            Instantiate(platform, position, Quaternion.identity);
        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        chunkrightx = chunk1right.position.x;
        chunkrighty = chunk1right.position.y;
        // chunknumbery = Mathf.Round(31.8f / transform.position.y)*31.8f;
        // chunknumberx = Mathf.Round(31.8f / transform.position.x) * 31.8f;
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("OnCollisionEnter2D");
            switch (col.gameObject.tag)
            {
                case "chunk1":
                //positioning chunk
                chunk1right.position = new Vector3(chunkrightx + chunkdistance, chunk1right.position.y, 0f);
                //spawning new platforms around chunk
                var position3 = new Vector3(chunkrightx + offsetonpaper.x,chunkrighty + offsetonpaper.y);
                Instantiate(paperandborders, position3, Quaternion.identity);
                for (int i = 0; i < platformsperrender; i++)
                {
                    var position2 = new Vector3(Random.Range((chunkrightx - chunkdistance / 2) + offsetcenterplayer.x + 100f, (chunkrightx + chunkdistance / 2) + offsetcenterplayer.x + 100f), Random.Range((chunkrighty - chunkdistance / 2) + offsetcenterplayer.y, (chunkrighty + chunkdistance / 2) + offsetcenterplayer.y), 0f);
                    Instantiate(platforms[Random.Range(0, 12)], position2, Quaternion.identity);
                }
                for (int i = 0; i < powerupssperrender; i++)
                {
                    var position4 = new Vector3(Random.Range((chunkrightx - chunkdistance / 2) + offsetcenterplayer.x + 100f, (chunkrightx + chunkdistance / 2) + offsetcenterplayer.x + 100f), Random.Range((chunkrighty - chunkdistance / 2) + offsetcenterplayer.y, (chunkrighty + chunkdistance / 2) + offsetcenterplayer.y), 0f);
                    Instantiate(powerups[Random.Range(0, 3)], position4, Quaternion.identity);
                }

                //breaking
                break;
            }

        
    }
    public void spawnnewchunk()
    {
        for (int i = 0; i < platformsperrender; i++)
        {
       // var position = new Vector3(Random.Range(31.8f * (chunknumberx), 31.8f * (chunknumberx) + 31.8f), Random.Range(31.8f * (chunknumbery) - 17, 31.8f * (chunknumbery) + 14.8f), 0f);
      //  Instantiate(platform, position, Quaternion.identity);

            // chunks.position = box.position + offsetcenterplayer;
            //  chunks.position = new Vector3(chunks.position.x + chunknumberx, chunks.position.y + chunknumbery, 0f);
            //chunk1right.position = new Vector3(chunknumberx * chunkdistance,chunk1right.position.y,0f);
            //chunk2bottom.position = new Vector3(chunk1right.position.x, chunknumbery * chunkdistance, 0f);
        }

    }
}
