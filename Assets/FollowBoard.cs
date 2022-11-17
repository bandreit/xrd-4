
using UnityEngine;

public class FollowBoard : MonoBehaviour
{
    public Transform board;

    void Update()
    {
        transform.position = new Vector3(board.transform.position.x + 1.5f, board.transform.position.y + 3,board.transform.position.z);
        // transform.rotation = new Quaternion(0, board.transform.rotation.y, 0, 0);
        // transform.LookAt( board.transform.position + Vector3.up* 90f);
    }
}
