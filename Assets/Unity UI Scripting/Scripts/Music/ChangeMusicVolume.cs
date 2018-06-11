using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeMusicVolume : MonoBehaviour {

    public Slider Volume;
    public AudioSource myMusic;

    private void Start()
    {
        Volume.value = 0.5f;
    }
    
    void Update ()
    {
        myMusic.volume = Volume.value;

	}
}

/*void MusicAdjust
 * if the master volume = 0 
        music volume = 0
   else the master != 0
        music volume = Mathf.Max (0, master.value)
        scene volume = music volume*/

