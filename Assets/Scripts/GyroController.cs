using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GyroController : MonoBehaviour
{
    private GameObject board;
    private float initial = 0f;
    private bool _isDefaultSet = false;
    private float toRotateBy = 0f;
    private VRInputManager _vrInputManager;
    void Start()
    {
        _vrInputManager = GameObject.FindWithTag("Board").GetComponent<VRInputManager>();
    }
    void Update()
    {
        Vector3 controllerValues = gameObject.transform.eulerAngles; 
        
        if (_vrInputManager.calibrateBoard && controllerValues.z != 0)
        {
            initial = controllerValues.z;
            Debug.Log(initial + " -------------Calibrated");
        }

        var controllerZ = controllerValues.z;

        if (controllerZ == 0)
        {
            return;
        }
        
        toRotateBy = initial - controllerZ;
        toRotateBy = Mathf.Clamp(toRotateBy, -20f, 20f);

        toRotateBy = toRotateBy / 20;
        Debug.Log(toRotateBy);
        _vrInputManager.turnInput = toRotateBy;
        // Debug.Log("rotateBy: " + toRotateBy);

        // board.transform.rotation = Quaternion.Euler(0, 0,toRotateBy);
    }
}
