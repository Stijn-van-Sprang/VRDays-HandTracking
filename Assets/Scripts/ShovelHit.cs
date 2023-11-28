using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShovelHit : MonoBehaviour
{

    public GameObject SoundOrigin;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("hovel hit");
        SoundOrigin.GetComponent<AudioSource>().Play();
    }
}
