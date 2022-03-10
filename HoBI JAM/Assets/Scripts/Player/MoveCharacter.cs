using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{

    public Vector3 newPosition;
    public Transform playerTransform;

    public float changeSpeed;
    //public float changeScale;

    // Start is called before the first frame update
    void Start()
    {
        newPosition = new Vector3();
        playerTransform = this.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && playerTransform.position.x != -5)
        {
            GoLeft();
        }

        if (Input.GetKeyDown(KeyCode.D) && playerTransform.position.x != 5)
        {
            GoRight();
        }

    }


    public void GoRight()
    {
        if(playerTransform.position.x != 5)
        {
            newPosition.x = playerTransform.position.x + 5;
            newPosition.y = playerTransform.position.y;
            newPosition.z = playerTransform.position.z;

            playerTransform.position = Vector3.Lerp(playerTransform.position, newPosition, changeSpeed);
        }
        


    }

    public void GoLeft()
    {
        if(playerTransform.position.x != -5)
        {
            newPosition.x = playerTransform.position.x - 5;
            newPosition.y = playerTransform.position.y;
            newPosition.z = playerTransform.position.z;

            playerTransform.position = Vector3.Lerp(playerTransform.position, newPosition, changeSpeed);
        }
        
    }
}
