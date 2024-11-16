using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    bool Pause = false;
    public GameObject PauseGamePanel;
    public GameObject PauseButtton;
    public void Pausegame()
    {
        if (Pause)
        {
            Time.timeScale = 1;
            Pause = false;
            PauseGamePanel.SetActive(false);
            PauseButtton.SetActive(true);
        }
        else
        {
            Time.timeScale = 0;
            Pause = true;
            PauseGamePanel.SetActive(true);
            PauseButtton.SetActive(false);
        }
    }
}
