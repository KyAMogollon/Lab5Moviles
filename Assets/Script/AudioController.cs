using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : SingletonGenericPersist<AudioController>
{
    AudioSource _audio;
    // Start is called before the first frame update
    void Start()
    {
        base.Awake();
        _audio = GetComponent<AudioSource>();
    }

    public void EjecutarSonidoDisparo(AudioClip clip)
    {
        _audio.PlayOneShot(clip);
    }
}
