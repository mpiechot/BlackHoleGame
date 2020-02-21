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

        controls.Player.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.Player.Move.canceled += _ => move = Vector2.zero;
    }

    void Update()
    {
        Vector2 moveStep = new Vector2(move.x, move.y) * Time.deltaTime;

        transform.Translate(moveStep, Space.World);
    }


    void OnEnable()
    {
        controls.Player.Enable();
    }
    void OnDisable()
    {
        controls.Player.Disable();
    }
}
