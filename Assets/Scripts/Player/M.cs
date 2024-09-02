using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M : MonoBehaviour
{
    public float Speed;

    void Update()
    {
        transform.position += transform.forward * Speed * Time.deltaTime;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Vrag")
        {
            Destroy(other.gameObject);
        }

    }
}
