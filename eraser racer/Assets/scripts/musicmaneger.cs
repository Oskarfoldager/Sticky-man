using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class musicmaneger : MonoBehaviour
{
    public AudioSource Audio2;
    public static musicmaneger bcminstance;
    public Scene currentscene;
    public int builderbob;
    public GameObject musicplayer;
    public static bool instancedestroyed;

    private void Awake()
    {/*
        //  Audio2.volume = 1;
        if (bcminstance != null && bcminstance != this || builderbob == 5)
        {
            Debug.Log("we are getting rid of this");
            Audio2.volume = 0;
            return;
        }
        else
        {
            DontDestroyOnLoad(this);
        }
        */
    }
    public void Update()
    {
        currentscene = SceneManager.GetActiveScene();
        builderbob = currentscene.buildIndex;
        if ( builderbob == 5)
        {
            Debug.Log("we are getting rid of this");
            Destroy(this.gameObject);
            instancedestroyed = false;

        }
        else if (builderbob == 2 || builderbob == 9)
        {
            instancedestroyed = false;

        }
        else if  (GameObject.FindGameObjectsWithTag("musicholder").Length > 1)
        {
            if (!instancedestroyed)
            {
                Debug.Log("we are getting rid of this");
                Destroy(musicplayer);
                instancedestroyed = true;
            }
        }
        else
        {
            DontDestroyOnLoad(this);
        }

    }
}
