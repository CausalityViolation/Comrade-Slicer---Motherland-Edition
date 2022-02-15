using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundEffect : MonoBehaviour
{
    public AudioSource sound;

    public void PlayFruitCutSound()
    {
        sound.Play();
    }
}
