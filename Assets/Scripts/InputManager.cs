using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;
using System;

public class Break : MonoBehaviour
{
    [SerializeField] private InputActionAsset playerActions;
    private InputAction _accelerateAction;
    private InputAction _breakAction;

    public event Action accelerateAction = delegate { };
    public event Action breakAction = delegate { };

    private void Awake()
    {
        var rightHand = playerActions.FindActionMap("XRI RightHand Interaction");
        _accelerateAction = rightHand.FindAction("Activate");
        _breakAction = rightHand.FindAction("Select");
    }

    private void Update()
    {
        if (_accelerateAction.triggered)
        {
            accelerateAction();
        }
        if (_breakAction.triggered)
        {
            breakAction();
        }
    }

}
