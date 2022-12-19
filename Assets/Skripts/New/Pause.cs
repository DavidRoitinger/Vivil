using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    private bool pOpen = false;

    public GameObject pauseMenu;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pOpen)
            {
                Go();
                pOpen = false;
            }
            else
            {
                Stop();
                pOpen = true;
            }
        }
    }

    public void Go()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
    }

    public void Stop()
    {
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
    }

    public void Exit()
    {
        Application.Quit();
    }
}


