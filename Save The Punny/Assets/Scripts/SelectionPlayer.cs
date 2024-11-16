using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectionPlayer : MonoBehaviour
{
    public GameObject[] Player;
    public int IDPlayer;
    public void NextPlayer()
    {
        Player[IDPlayer].SetActive(false);
        IDPlayer = (IDPlayer+1)%Player.Length;
        Player[IDPlayer].SetActive(true);
    }
    public void BackPlayer()
    {
        Player[IDPlayer].SetActive(false);
        IDPlayer --;
        if (IDPlayer < 0)
        {
            IDPlayer += Player.Length;
        }
        Player[IDPlayer].SetActive(true);
    }
    public void PlayGame()
    {
        PlayerPrefs.SetInt("IDPlayer", IDPlayer);
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }
}