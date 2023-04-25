using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject ControlsMenu;
    public GameObject SettingsMenu;
    public GameObject CreditsMenu;

    public AudioSource buttonClick;

    void Start()
    {
        //       Cursor.visible = false;
        //        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if (MainMenu.activeInHierarchy)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }

        if (ControlsMenu.activeInHierarchy)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }

        if (SettingsMenu.activeInHierarchy)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }

        if (CreditsMenu.activeInHierarchy)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }

        else
        {
            //           Cursor.visible = false;
            //          Cursor.lockState = CursorLockMode.Locked;
        }
    }

    public void OpenControlsMenu()
    {
        buttonClick.Play();
        ControlsMenu.SetActive(true);
        MainMenu.SetActive(false);
    }

    public void CloseControlsMenu()
    {
        buttonClick.Play();
        ControlsMenu.SetActive(false);
        MainMenu.SetActive(true);
    }

    public void OpenSettingsMenu()
    {
        buttonClick.Play();
        SettingsMenu.SetActive(true);
        MainMenu.SetActive(false);
    }

    public void CloseSettingsMenu()
    {
        buttonClick.Play();
        SettingsMenu.SetActive(false);
        MainMenu.SetActive(true);
    }

    public void OpenCreditsMenu()
    {
        buttonClick.Play();
        CreditsMenu.SetActive(true);
        MainMenu.SetActive(false);
    }

    public void CloseCreditsMenu()
    {
        buttonClick.Play();
        CreditsMenu.SetActive(false);
        MainMenu.SetActive(true);
    }

    public void StartGame()
    {
        buttonClick.Play();
        SceneManager.LoadScene("Game Scene");
    }

    public void ExitGame()
    {
        buttonClick.Play();
        Application.Quit();
    }
}
