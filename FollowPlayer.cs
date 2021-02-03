using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= 30) {
            transform.position = new Vector3(transform.position.x, -10f, transform.position.z);

        }

        transform.position = new Vector3(0, player.position.y, 0) + offset;
        
    }
}
