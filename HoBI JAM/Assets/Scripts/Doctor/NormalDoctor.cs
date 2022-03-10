using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalDoctor : MonoBehaviour
{

    public PlayerProperties playerProperties;
    //public GameObject target;

    private void Start()
    {
        //playerProperties = target.GetComponent<PlayerProperties>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("xxx");
            playerProperties.health += 10;
        }
    }
}
