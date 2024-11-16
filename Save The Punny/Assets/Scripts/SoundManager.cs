using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    void Start()
    {
        if (!PlayerPrefs.HasKey("MusicVolume"))
        {
            PlayerPrefs.SetFloat("MusicVolume", 1);
            Load();
        }
        else
        {
            Load();
        }
    }
    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        Save();
    }
    public void Save()
    {
        PlayerPrefs.SetFloat("MusicVolume", volumeSlider.value);
    }
    public void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("MusicVolume");
        AudioListener.volume = volumeSlider.value;
    }
}
