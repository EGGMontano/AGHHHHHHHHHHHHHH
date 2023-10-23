using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//After making button inputs on Unity, go here

public class InputManager : MonoBehaviour
{
    ControlsPlayer playerControls;

    public Vector2 movementInput;
    public float verticalInput, horizontalInput;

    private void OnEnable()
    {
        if (playerControls == null)
        {
            playerControls = new ControlsPlayer();

            playerControls.PlayerMovement.Movement.performed += i => movementInput = i.ReadValue<Vector2>(); //Reads Vector 2 thingz and puts them in "movementInput"
        }

        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }


    public void HandleAllInputs()
    {
        HandleMovementInput();
        //jump & action inputs
    }

    private void HandleMovementInput()
    {
        verticalInput = movementInput.y;
        horizontalInput = movementInput.x;
    }
}
