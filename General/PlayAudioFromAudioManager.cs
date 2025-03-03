// Script to play audio

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioFromAudioManager : MonoBehaviour
{
    public string target;

    // Play audio either specified by target field or name
    public void Play()
    {
        AudioManager.instance.Play(target);
    }

    public void Play(string audioName)
    {
        AudioManager.instance.Play(audioName);
    }
}
