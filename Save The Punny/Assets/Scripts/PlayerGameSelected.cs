using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGameSelected : MonoBehaviour
{
    public GameObject[] PlayerSelected;
    public Transform Select;
    void Start()
    {
        int IDPlayer = PlayerPrefs.GetInt("IDPlayer");
        GameObject prefab = PlayerSelected[IDPlayer];
        GameObject Clone = Instantiate(prefab, Select.position, Quaternion.identity);
    }
}