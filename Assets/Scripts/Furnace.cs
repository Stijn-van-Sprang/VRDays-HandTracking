using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Furnace : MonoBehaviour
{
    public int coalcounter;
    public GameObject furnaceholl;
    public GameObject coal;

    public bool coalON;

    private void Start()
    {
        coalON = false;
        coal.SetActive(false);
        furnaceholl.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "coal")
        {
            coal.SetActive(true);
            coalON = true;
            Debug.Log("coal pickup");
        }

        if (other.gameObject.name == "furnace" && coalON)
        {
            coal.SetActive(false);
            coalcounter++;
            coalON = false;
            Debug.Log("coal in furnace");
        }

        Debug.Log("test 1");
    }

    public void Update()
    {
        if (coalcounter > 0)
        {
            furnaceholl.SetActive(true);
        }
        else
        {
            furnaceholl.SetActive(false);
        }
    }

    public int GETTIMEMIN()
    {
        return coalcounter;      
    }
}
