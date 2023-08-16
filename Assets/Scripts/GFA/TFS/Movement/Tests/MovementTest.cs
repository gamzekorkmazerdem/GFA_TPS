using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace GFA.TPS.Movement.Test
{
    public class MovementTest : MonoBehaviour
    {
        // mekani�i do�rudan test etmek i�in kullan�lacak
        [SerializeField]
        private Vector2 _movementInput;

        [SerializeField]
        private CharacterMovement _characterMovement;

        private void Update()
        {
            // if(Input.GetKeyDown(KeyCode.Space) ile a�a��daki sat�r ayn�
            if (UnityEngine.InputSystem.Keyboard.current.spaceKey.wasReleasedThisFrame)
            {
                // space e bas�ld���nda 10 birimlik external force eklensin ve yava�layarak ilerlesin
                _characterMovement.ExternalForces += new Vector3(10, 0, 0);
            }

            _characterMovement.MovementInput = _movementInput;
        }


    }
}

