using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testmovement : MonoBehaviour
{
    //The enemy to spin around
    public Transform target;

    //How fast our player can spin
    public float spinSpeed = 200;

    //The distance from the player to the target
    private Vector3 distanceOffset;


    private void Start()
    {
        //Drag the player how far you want in the inspector before hitting play.
        distanceOffset = transform.position - target.position;
    }

    void Update()
    {
        //Set the position of the player
        transform.position = target.position + distanceOffset;

        //Handles the player input
        PlayerInput();

        //Stores the last distance to target
        distanceOffset = transform.position - target.position;

    }

    void PlayerInput()
    {
        //Spins the player left
        if (Input.GetKey(KeyCode.A))
        {
            transform.RotateAround(target.position, target.transform.up, spinSpeed * Time.deltaTime);
        }
        //Spins the player right
        else if (Input.GetKey(KeyCode.D))
        {
            transform.RotateAround(target.position, target.transform.up, -spinSpeed * Time.deltaTime);
        }
    }
}