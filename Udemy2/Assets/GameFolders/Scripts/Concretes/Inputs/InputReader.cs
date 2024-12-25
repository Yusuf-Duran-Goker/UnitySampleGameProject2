using System;
using System.Collections;
using System.Collections.Generic;
using Udemy2.Abstracts.Inputs;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Udemy2.Inputs
{
    public class InputReader : IInputReader
 {
    PlayerInput _playerInput;

    public float Horizontal { get;private set; }
    public bool isJump {get; private set;}


        public InputReader(PlayerInput playerInput)
    {
        _playerInput =playerInput;
        
        _playerInput.currentActionMap.actions[0].performed += OnHorizontalMove;
        _playerInput.currentActionMap.actions[1].started += Onjump;
        _playerInput.currentActionMap.actions[1].canceled += Onjump;
        
    }

        private void Onjump(InputAction.CallbackContext context)
        {
            isJump = context.ReadValueAsButton();
        }

        private void OnHorizontalMove(InputAction.CallbackContext context)
        {
            Horizontal = context.ReadValue<float>();
        }
    }
}

