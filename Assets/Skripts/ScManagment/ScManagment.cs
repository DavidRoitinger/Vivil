using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScManagment : MonoBehaviour
{
    public int scene;
    public void Play()
    {
        SceneManager.LoadScene(1);

    }
    public void LoadOverworld()
    {
        SceneManager.LoadScene(2);

    }

    public void StartOver()
    {
        SceneManager.LoadScene(0);
    }

    public void Next()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(scene);
        }
    }


}
