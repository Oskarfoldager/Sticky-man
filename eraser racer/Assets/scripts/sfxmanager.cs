using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sfxmanager : MonoBehaviour
{
    public AudioSource Audio;
    public AudioClip testsound;
    public AudioClip soundofpowerup;
    public static sfxmanager sfxinstance;
    private void Awake()
    {
        if (sfxinstance != null && sfxinstance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        sfxinstance = this;
        DontDestroyOnLoad(this);
    }
}
