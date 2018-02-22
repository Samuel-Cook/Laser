using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class GameMusic : MonoBehaviour
{
    public AudioMixer Sfx;
    public AudioMixer Music;
    public bool MMuted = false;
    public bool SMuted = false;

    void Start()
    {

    }


    public void SetSfxLevel()
    {
        if (SMuted == false)
        {
            Sfx.SetFloat("VolumeS", -80f);
            SMuted = true;
        }
        else if (SMuted == true)
        {
            Sfx.SetFloat("VolumeS", 0f);
            SMuted = false;
        }
    }
    public void SetMusicLevel()
    {
        if (MMuted == false)
        {
            Music.SetFloat("VolumeM", -80f);
            MMuted = true;
        }
        else if (MMuted == true)
        {
            Music.SetFloat("VolumeM", -15f);
            MMuted = false;
        }
        
    }
}
