using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSound : MonoBehaviour
{
    public GameObject SoundOrigin;
    public bool pistonsound;
    public Furnace furnace;
    public ParticleSystem effect;
    // Start is called before the first frame update
    void Start()
    {
        pistonsound = false;
    }

    IEnumerator waiter()
    {
        while (pistonsound)
        {
            Debug.Log("sound ");
            Debug.Log(furnace.GETTIMEMIN());
		    effect.Play(true);
            SoundOrigin.GetComponent<AudioSource>().Play();
            yield return new WaitForSeconds(8 - furnace.GETTIMEMIN());
        }
    }

    private void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.name == "SoundTrigger")
        {
            pistonsound = true;
            Debug.Log("playsound");
            StartCoroutine(waiter());
;        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.name == "SoundTrigger")
        {
            pistonsound = false;
            Debug.Log("stopsound");
            StopCoroutine(waiter());
        }
    }
}
