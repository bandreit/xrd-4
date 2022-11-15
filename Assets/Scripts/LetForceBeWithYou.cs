using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetForceBeWithYou : MonoBehaviour
{
    [SerializeField]
    private Rigidbody board;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Throttle") > 0)
        {
            board.AddForce(transform.forward * 90f, ForceMode.Impulse);
        }
    }
}
