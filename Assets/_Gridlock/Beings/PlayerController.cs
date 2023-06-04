using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Gridlock
{
    public class PlayerController : Being
    {
        [SerializeField]
        private PlayerMovement controls;
        private void Awake()
        {
            controls = new PlayerMovement();
        }

        private void OnEnable()
        {
            controls.Enable();
        }

        private void OnDisable()
        {
            controls.Disable();
        }

        private void Start()
        {
            controls.PlayerInput.Movement.performed += ctx => MovePlayer(ctx.ReadValue<Vector2>());    
        }
        void MovePlayer(Vector2 moveDirection)
        {
            this.Move(Vector2Int.RoundToInt(moveDirection));
        }
    }
}

