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

    private void Awake()
    {
        if (bcminstance != null && bcminstance != this || builderbob == 5)
        {
            Debug.Log("we are getting rid of this");
            Destroy(this.gameObject);
            musicplayer.SetActive(false);
            return;
        }
        bcminstance = this;
        DontDestroyOnLoad(this);
    }
    public void Update()
    {
        currentscene = SceneManager.GetActiveScene();
        builderbob = currentscene.buildIndex;
    }
}
