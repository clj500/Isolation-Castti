using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public GameObject ControlsMenu;
    public GameObject SettingsMenu;
    public GameObject CreditsMenu;

    public AudioSource buttonClick;

    public void LoadMainMenu()
    {
        buttonClick.Play();
        SceneManager.LoadScene("MainMenu");
    }

    public void LoadControlsScreen()
    {
        buttonClick.Play();
        SceneManager.LoadScene("Control Menu");
    }

    public void LoadSettingsScreen()
    {
        buttonClick.Play();
        SceneManager.LoadScene("Settings Menu");
    }

    public void LoadCreditsScreen()
    {
        buttonClick.Play();
        SceneManager.LoadScene("Credits");
    }

    public void OpenControlsMenu()
    {
        buttonClick.Play();
        ControlsMenu.SetActive(true);
    }

    public void CloseControlsMenu()
    {
        buttonClick.Play();
        ControlsMenu.SetActive(false);
    }

    public void OpenSettingsMenu()
    {
        buttonClick.Play();
        SettingsMenu.SetActive(true);
    }

    public void CloseSettingsMenu()
    {
        buttonClick.Play();
        SettingsMenu.SetActive(false);
    }

    public void OpenCreditsMenu()
    {
        buttonClick.Play();
        CreditsMenu.SetActive(true);
    }

    public void CloseCreditsMenu()
    {
        buttonClick.Play();
        CreditsMenu.SetActive(false);
    }

    public void ExitGame()
    {
        buttonClick.Play();
        Application.Quit();
    }
}
