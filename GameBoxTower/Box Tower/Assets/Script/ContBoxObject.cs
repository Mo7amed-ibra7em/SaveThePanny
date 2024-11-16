using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContBoxObject : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Invoke("PositionY", 0.6f);
        }
    }
    void PositionY()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y + 0.8f);
    }
}
