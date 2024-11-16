using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    bool Game_Over = false;
    int Score = 0;
    public Text TextScore;
    private int ScoreCount;
    public Text TextScorePanel;
    public GameObject GameOverPanel;
    public GameObject ClosePauseButton;
    public AudioSource GameOverSound;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    public void GameOver()
    {
        Game_Over = true;
        GameObject.Find("SpawnBombs").GetComponent<SpawnBombs>().StopSpawn();
        GameOverPanel.SetActive(true);
        InvokeRepeating("AddScoreGameOverPanel", 0.0f, 0.03f);
    }
    public void IncrementScore()
    {
        if (!Game_Over)
        {
            Score++;
            TextScore.text = Score.ToString();
        }
        else
        {
            ScoreCount = Score;
            TextScore.text = "";
            ClosePauseButton.SetActive(false);
        }
    }
    private void AddScoreGameOverPanel()
    {
        if (Convert.ToInt32(TextScorePanel.text) < ScoreCount)
        {
            TextScorePanel.text = Convert.ToString(Convert.ToInt32(TextScorePanel.text) + 1);
        }
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(1);
    }
    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
}
