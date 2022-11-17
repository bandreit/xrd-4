using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VehicleBehaviour;

public class Restart : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Debug.Log(other.name);
        if (other.gameObject.CompareTag("Board"))
        {
            var o = other.gameObject;
            o.transform.position = new Vector3(476.5f, 83.2799988f, 406.700012f);
            o.transform.rotation = new Quaternion(0.0f, 270.5f, 0f, 0f);
        }

        //other.gameObject.GetComponent<WheelVehicle>().Handbrake = true;
    }
}
