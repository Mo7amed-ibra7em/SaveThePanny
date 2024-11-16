using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    void Start()
    {
        transform.SetParent(GameObject.FindGameObjectWithTag("BoxObject").transform);
        GetComponent<Rigidbody2D>().gravityScale = 0;
        transform.position = GameObject.FindGameObjectWithTag("BoxObject").transform.position;
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            transform.parent = null;
            GetComponent<Rigidbody2D>().gravityScale = 1;
        }
    }
}
