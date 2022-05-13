using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void SetMasterVolume(float volume)
    {
        audioMixer.SetFloat("MasterVolume", volume);
        if(volume <= -50)
        {
            audioMixer.SetFloat("MasterVolume", -80);
        }
    }
}
