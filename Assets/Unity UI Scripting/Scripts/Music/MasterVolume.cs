using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MasterVolume : MonoBehaviour {

    /*public Slider Volume;
    public AudioSource myMusic;

    private void Start()
    {
        Volume.value = 0.5f;
    }

    void Update()
    {
        myMusic.volume = Volume.value;

    }*/

    public Slider VolumeSlider;
    float masterVolume = 0.0f;

    private void Start()
    {
        masterVolume = VolumeSlider.value;
    }

    private void Update()
    {
        Example();
    }
    public void Example()
    {
        masterVolume = VolumeSlider.value;
        AudioListener.volume = masterVolume;
    }
    public void AdjustVolume(float newVolume)
    {
        AudioListener.volume = newVolume;
    }
}
