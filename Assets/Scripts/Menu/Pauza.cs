using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pauza : MonoBehaviour
{
    public Canvas panel;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            Time.timeScale = 0;
            panel.gameObject.SetActive(true);
            Screen.lockCursor = false;
        }
    }

    public void ButtonRestart()
    {
        SceneManager.LoadScene(1);
    }

    public void ButtonGo()
    {
        Time.timeScale = 1;
        panel.gameObject.SetActive(false);
        Screen.lockCursor = true;
    }
}
