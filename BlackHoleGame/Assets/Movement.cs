using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    PlayerControls controls;

    Vector2 move;

    void Awake()
    {
        controls = new PlayerControls();

        //Setup Gamepad Movement
        controls.GameplayJoystick.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.GameplayJoystick.Move.canceled += ctx => move = Vector2.zero;

        //Setup Keyboard Movement
        controls.GameplayKeyboard.MoveUp.performed += ctx => move.y = 1;
        controls.GameplayKeyboard.MoveUp.canceled += ctx => move.y = 0;

        controls.GameplayKeyboard.MoveDown.performed += ctx => move.y = -1;
        controls.GameplayKeyboard.MoveDown.canceled += ctx => move.y = 0;

        controls.GameplayKeyboard.MoveLeft.performed += ctx => move.x = -1;
        controls.GameplayKeyboard.MoveLeft.canceled += ctx => move.x = 0;

        controls.GameplayKeyboard.MoveRight.performed += ctx => move.x = 1;
        controls.GameplayKeyboard.MoveRight.canceled += ctx => move.x = 0;
    }

    void Update()
    {
        Vector2 moveStep = new Vector2(move.x, move.y) * Time.deltaTime;

        transform.Translate(moveStep, Space.World);
    }


    void OnEnable()
    {
        controls.GameplayJoystick.Enable();
        controls.GameplayKeyboard.Enable();
    }
    void OnDisable()
    {
        controls.GameplayJoystick.Disable();
        controls.GameplayKeyboard.Disable();
    }
}
