﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public AudioSource CoinSound;
    
    public void Coin()
    {
        CoinSound.Play();
    }

    
}
