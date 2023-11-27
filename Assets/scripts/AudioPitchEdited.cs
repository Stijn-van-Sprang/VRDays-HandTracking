using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPitchEdited : MonoBehaviour
{
    public AudioSource AudioPavement;
    public GameObject RotatingValve;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AudioPavement.pitch = RotatingValve.gameObject.transform.rotation.z;
        Debug.Log("Pitch of " + gameObject.name + " changed to " + RotatingValve.gameObject.transform.rotation.z);
    }
}
