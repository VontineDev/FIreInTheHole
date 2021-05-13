using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField]
    AudioClip fireInTheHall;

    [SerializeField]
    AudioClip pung;

    AudioSource sound;

    /*
     * ------- PlayerCtrl.cs
        GameObject soundManagerObj = GameObject.Find("SoundManager");
        SoundManager soundManager = soundManagerObj.GetComponent<SoundManager>();
        soundManager.pungSound();
    */

    /*
     * ------- PotalCtrl.cs
        public GameObject soundManagerObj;
        SoundManager soundManager = soundManagerObj.GetComponent<SoundManager>();
        soundManager.fireSound();
    */


    void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    // ball 던질때 sound
    public void fireSound()
    {
        sound.PlayOneShot(fireInTheHall);
    }

    // potal 열릴때 sound
    public void pungSound()
    {
        sound.PlayOneShot(pung);
    }
}
