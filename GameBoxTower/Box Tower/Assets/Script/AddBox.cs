using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddBox : MonoBehaviour
{
    public GameObject Box;
    void Start()
    {
        MakeBox();
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Invoke("MakeBox", 0.7f);
        }
    }
    void MakeBox()
    {
        Instantiate(Box,transform.position,transform.rotation);
    }
}
