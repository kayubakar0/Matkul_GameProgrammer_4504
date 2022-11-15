using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public GameObject Player;
    public float offsetXDist = 2.0f;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offsetXDist += Player.transform.position.x;
        offset = transform.position - new Vector3(offsetXDist, Player.transform.position.y, Player.transform.position.z);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Player.transform.position + offset;
    }
}
