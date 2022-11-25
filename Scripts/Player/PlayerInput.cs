using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMover))]

public class PlayerInput : MonoBehaviour
{
    private PlayerMover _mover;

    private void Start()
    {
        _mover = GetComponent<PlayerMover>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _mover.TryMoveUp();
        }

        if (Input.GetKey(KeyCode.S))
        {
            _mover.TryMoveDown();
        }

        if (Input.GetKey(KeyCode.Space))
        {
            _mover.StopMove();
        }
    }
}
