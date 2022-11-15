using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;
using System;

public class VRInputManager : MonoBehaviour
{
    [SerializeField] private InputActionAsset playerActions;
    private InputAction _calibrateBoard;
    private InputAction _accelerateAction;
    private InputAction _breakAction;
    public float turnInput;
    public float throttle { get; private set; }
    public float stopValue
    {
        get;
        private set;
    }
    public bool calibrateBoard { get; private set; }

    private void Awake()
    {
        var rightHand = playerActions.FindActionMap("XRI RightHand Interaction");
        _accelerateAction = rightHand.FindAction("Activate Value");
        _breakAction = rightHand.FindAction("Select Value");
        _calibrateBoard = rightHand.FindAction("Primary Button");
    }

    private void Update()
    {
        throttle = _accelerateAction.ReadValue<float>();
        stopValue = _breakAction.ReadValue<float>();
        calibrateBoard = _calibrateBoard.triggered;
    }

}
