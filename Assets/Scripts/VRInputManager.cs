using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;
using System;

public class VRInputManager : MonoBehaviour
{
    [SerializeField] private InputActionAsset playerActions;
    private InputAction _accelerateAction;
    private InputAction _breakAction;
    public float throttle { get; private set; }
    public float stopValue
    {
        get;
        private set;
    }

    private void Awake()
    {
        var rightHand = playerActions.FindActionMap("XRI LeftHand Interaction");
        _accelerateAction = rightHand.FindAction("Activate Value");
        _breakAction = rightHand.FindAction("Select Value");
    }

    private void Update()
    {
        throttle = _accelerateAction.ReadValue<float>();
        stopValue = _breakAction.ReadValue<float>();
    }

}
