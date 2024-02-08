using SA;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    float vertical;
    float horizontal;

    float delta = Time.deltaTime;

    StateManager states;
    CameraManager camManager;

    // Start is called before the first frame update
    void Start()
    {
        states = GetComponent<StateManager>();
        states.Init();

        camManager = CameraManager.singleton;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        delta = Time.fixedDeltaTime;
        GetInput();
    }

    private void Update()
    {
        delta = Time.deltaTime;
        camManager.Tick(delta);
    }

    void GetInput()
    {
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");
    }

    void UpdateStates()
    {
        states.horizontal = horizontal;
        states.vertical = vertical;
        states.Tick(Time.deltaTime);
    }
}
