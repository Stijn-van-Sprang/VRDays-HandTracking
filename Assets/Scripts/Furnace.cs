using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Furnace : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "coal")
        {
            Debug.Log("coal");
        }

        if (other.gameObject.name == "furnace")
        {
            Debug.Log("furnace");
        }

        Debug.Log("test 1");
    }
}
