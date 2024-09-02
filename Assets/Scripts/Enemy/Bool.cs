using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bool : MonoBehaviour
{
    public float Speed = 50f;

    void Update()
    {
        transform.position += transform.forward * Speed * Time.deltaTime;
    }

    public void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
