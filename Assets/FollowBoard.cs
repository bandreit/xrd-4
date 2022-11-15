using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBoard : MonoBehaviour
{
    public Transform board;
    void Start()
    {
    }
    void Update()
    {
        transform.position = new Vector3(board.transform.position.x, board.transform.position.y + 3,board.transform.position.z + 1.5f);
    }
}
