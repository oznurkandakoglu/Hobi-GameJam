using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProperties : MonoBehaviour
{
    public int key = 0;
    public int health = 0;
    public int goldKey = 0;
    public bool isTrue=true;

    public MoveGround mg;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("RealDoctor") && isTrue)
        {
            health += 10;
            isTrue = false;
        }

        if (other.CompareTag("FakeDoctor") && isTrue)
        {
            health -= 10;
            isTrue = false;
        }

        if (other.CompareTag("Devil"))
        {
            Destroy(other.gameObject);
        }

        if (other.CompareTag("Key") && isTrue)
        {
            goldKey += 1;
            isTrue = false;
        }

        if (other.CompareTag("RealCop") && isTrue)
        {
            mg.moveSpeed -= 1f;
            isTrue = false;
        }

        if (other.CompareTag("FakeCop") && isTrue)
        {
            mg.moveSpeed += 1f;
            isTrue = false;
        }

        if (other.CompareTag("Robber") && isTrue)
        {
            goldKey -= 1;
            isTrue = false;
        }

    }


    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("RealDoctor"))
        {
            isTrue = true;
            Destroy(other.gameObject);
        }

        if (other.CompareTag("FakeDoctor"))
        {
            isTrue = true;
            Destroy(other.gameObject);
        }

        if (other.CompareTag("RealCop"))
        {
            isTrue = true;
            Destroy(other.gameObject);
        }

        if (other.CompareTag("FakeCop"))
        {
            isTrue = true;
            Destroy(other.gameObject);
        }

        if (other.CompareTag("Robber"))
        {
            isTrue = true;
            Destroy(other.gameObject);
        }

        if (other.CompareTag("Key"))
        {
            Destroy(other.gameObject);
        }

    }


}

