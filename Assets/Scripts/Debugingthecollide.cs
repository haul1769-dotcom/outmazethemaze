using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("walls"))
        {
            Debug.Log("ENTER");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("walls"))
        {
            Debug.Log("STAY");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("walls"))
        {
            Debug.Log("EXIT");
        }
    }
}

