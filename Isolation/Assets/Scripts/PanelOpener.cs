using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelOpener : MonoBehaviour
{
    public GameObject Panel;

    private void Start()
    {
        Panel.gameObject.SetActive(false);
    }

    public void OpenPanel()
    {
        if(Panel != null)
        {
            bool isActive = Panel.activeSelf;

            Panel.SetActive(!isActive);
        }
    }
}
