using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effects : MonoBehaviour
{
    private FMOD.Studio.EventInstance instance;

    [FMODUnity.EventRef]
    public string fmodEvent;

    [SerializeField] [Range(0f, 1f)]
    private float reverb, delay;

    [SerializeField] [Range(0f, 5000f)]
    private float delayTime;

    [SerializeField] [Range(-12f, 12f)]
    private float pitch;


    void Start()
    {
        instance = FMODUnity.RuntimeManager.CreateInstance(fmodEvent);
        instance.start();
    }

    void Update()
    {
        instance.setParameterByName("Reverb", reverb);
        instance.setParameterByName("Delay", delay);
        instance.setParameterByName("DelayTime", delayTime);
        instance.setParameterByName("Pitch", pitch);
    }
}
