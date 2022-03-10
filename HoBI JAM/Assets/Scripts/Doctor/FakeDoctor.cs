using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeDoctor : MonoBehaviour
{

    public PlayerProperties playerProperties;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("xxx");
            playerProperties.health -= 10;
        }
    }

}
