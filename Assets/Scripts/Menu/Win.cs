using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public GameObject player;
    void Start()
    {
        player = FindObjectOfType<MoveBehaviour>().gameObject;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            SceneManager.LoadScene(2);
        }
    }
}
