using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject PauseMenuScreen;
    public static bool isPaused;

    public AudioSource buttonClick;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }

            else
            {
                Pause();
            }
        }

        else
        {
            //           Cursor.visible = false;
            //          Cursor.lockState = CursorLockMode.Locked;
        }
    }

    public void Pause()
    {
        PauseMenuScreen.SetActive(true);
        isPaused = true;
    }

    public void Resume()
    {
        buttonClick.Play();
        PauseMenuScreen.SetActive(false);
        isPaused = false;
    }
}
