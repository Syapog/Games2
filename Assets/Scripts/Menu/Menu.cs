using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Start()
    {
        Cursor.visible = true;
    }

    public void ButtonPlay()
    {
        SceneManager.LoadScene(1);
    }
}
