using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    public GameObject GameOver;
    void OnCollisionEnter2D(Collision2D Col)
    {
        if (Col.gameObject.tag == "Box")
        {
            GameOver.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
