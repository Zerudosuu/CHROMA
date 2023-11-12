using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class volumeSettings : MonoBehaviour
{
    [SerializeField] private AudioMixer volMixer;
    [SerializeField] public Slider masterSlider;
    [SerializeField] public Slider musicSlider;
    [SerializeField] public Slider SFXSlider;

    private void Start()
    {
        if (PlayerPrefs.HasKey("masterVolume"))
        {
            LoadVolume();
        }
        else
        {
            SetMasterVolume();
            SetMusicVolume();
            SetSFXVolume();
        }
    }
    public void SetMasterVolume()
    {
        float volume = masterSlider.value;
        volMixer.SetFloat("master", Mathf.Log10(volume)*20);
        PlayerPrefs.SetFloat("materVolume", volume);
    }

    public void SetMusicVolume()
    {
        float volume = musicSlider.value;
        volMixer.SetFloat("music", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("musicVolume", volume);
    }

    public void SetSFXVolume()
    {
        float volume = SFXSlider.value;
        volMixer.SetFloat("SFX", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("SFXVolume", volume);
    }

    private void LoadVolume()
    {
        masterSlider.value = PlayerPrefs.GetFloat("masterVolume");
        musicSlider.value = PlayerPrefs.GetFloat("musicVolume");
        SFXSlider.value = PlayerPrefs.GetFloat("SFXVolume");
        
        SetMasterVolume();
        SetMusicVolume();
        SetSFXVolume();
    
    }

}
