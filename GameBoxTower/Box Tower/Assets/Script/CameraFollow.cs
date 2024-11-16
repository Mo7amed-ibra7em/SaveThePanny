using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform FollowedItem;
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if (FollowedItem.position.y > transform.position.y)
            {
                transform.position = new Vector3(transform.position.x, FollowedItem.position.y - 0.6f, transform.position.z);
            }
        }
    }
}
