using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GS
{
    public class InputHandler : MonoBehaviour
    {

        public float horizontal;
        public float vertical;
        public float moveAmount;
        public float mouseX;
        public float mouseY;

        public bool b_Input;

        public bool rollFlag;
        public bool sprintFlag;
        public float rollInputTimer;


        PlayerControls inputActions;

        Vector2 movementInput;
        Vector2 cameraInput;

        public void OnEnable()
        {
            if (inputActions == null)
            {
                inputActions = new PlayerControls();
                inputActions.PlayerMovement.Movement.performed += inputActions => movementInput = inputActions.ReadValue<Vector2>();
                inputActions.PlayerMovement.Camera.performed += i => cameraInput = i.ReadValue<Vector2>();          
            }

            inputActions.Enable();
        }

        private void OnDisable()
        {
            inputActions.Disable();
        }

        public void TickInput(float delta)
        {
            MoveInput(delta);
            HandleRollInput(delta);
        }

        private void MoveInput(float delta)
        {
            horizontal = movementInput.x;
            vertical = movementInput.y;
            moveAmount = Mathf.Clamp01(Mathf.Abs(horizontal) + Mathf.Abs(vertical));
            mouseX = cameraInput.x;
            mouseY = cameraInput.y;
        }

        private void HandleRollInput(float delta)
        {
            b_Input = inputActions.PlayerActions.Roll.IsPressed();
            if (b_Input)
            {
                rollInputTimer += delta;
                sprintFlag = true;
            }

            else
            {
                if(rollInputTimer>0 && rollInputTimer < 0.5)
                {
                    sprintFlag = false;
                    rollFlag = true;
                }
                rollInputTimer = 0;
            }
        }
    }
}
