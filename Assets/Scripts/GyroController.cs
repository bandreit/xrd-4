using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroController : MonoBehaviour
{
    private GameObject board;
    private float initial = 0f;
    private bool _isDefaultSet = false;
    void Start()
    {
        board = GameObject.FindWithTag("Board");
    }
    void Update()
    {
        if (board == null)
        {
            return;
        }
        
        Vector3 controllerValues = gameObject.transform.eulerAngles; 
        
        if (controllerValues.z != 0f && !_isDefaultSet)
        {
            initial = controllerValues.z;
            Debug.Log(initial + " -------------INITIAL");
            _isDefaultSet = true;
        }

        var controllerZ = controllerValues.z;
        Debug.Log("z: " + gameObject.transform.eulerAngles);
        if (!_isDefaultSet || controllerZ == 0)
        {
            return;
        }
        
        float toRotateBy = initial - controllerZ;
        // Debug.Log("rotateBy: " + toRotateBy);
        board.transform.rotation = Quaternion.Euler(0, 0,toRotateBy);
 }
}
