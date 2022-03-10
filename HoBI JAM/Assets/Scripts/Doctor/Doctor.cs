using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doctor : MonoBehaviour
{

    public GameObject devil;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            devil.SetActive(true);
        }
    }
}
