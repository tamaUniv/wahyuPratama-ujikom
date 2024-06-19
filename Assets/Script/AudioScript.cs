using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{

    private AudioSource bgmSource;
    // Start is called before the first frame update
    void Start()
    {
        bgmSource = GetComponent<AudioSource>();

        if(bgmSource != null)
        {
            bgmSource.loop = true;
        }
    }

    public void PlayBGM(AudioClip audioClip)
    {
        if(bgmSource != null)
        {
            bgmSource.clip = audioClip;
            bgmSource.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
