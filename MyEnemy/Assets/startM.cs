using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;

public class startM : MonoBehaviour
{
    
    public AudioMixer mixer;
    public float audioo;
    // Start is called before the first frame update
    void Start()
    {    
        audioo = PlayerPrefs.GetFloat("volume");
        mixer.SetFloat("volume", audioo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
