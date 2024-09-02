using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HP : MonoBehaviour
{
    public Image BarLine;
    public static float fill;

    // Start is called before the first frame update
    void Start()
    {
        BarLine = GameObject.FindGameObjectWithTag("hp").GetComponent<Image>();
        fill = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        BarLine.fillAmount = fill;
        if (fill <= 0)
        {
            SceneManager.LoadScene(1);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "enemy")
        {
            fill -= 0.25f;
            Destroy(other.gameObject);
        }

    }
}
