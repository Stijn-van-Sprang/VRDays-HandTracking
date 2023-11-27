using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPitchEdited : MonoBehaviour
{
    public AudioSource AudioPavement;
    public GameObject RotatingValve;
    public float PitchValue;

    private float OldValueRotator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(RotatingValve.gameObject.transform.rotation.y);
        AudioPavement.pitch = PitchValue;

        if(RotatingValve.gameObject.transform.rotation.y < OldValueRotator)
        {
            OldValueRotator = RotatingValve.gameObject.transform.rotation.y;
            PitchValue++;
        } else if(RotatingValve.gameObject.transform.rotation.y > OldValueRotator)
        {
            OldValueRotator = RotatingValve.gameObject.transform.rotation.y;
            PitchValue--;
        }
    }
}
