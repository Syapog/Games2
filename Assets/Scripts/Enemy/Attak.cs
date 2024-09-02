using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attak : MonoBehaviour
{
    public GameObject player;
    Animator animation;
    private bool boxx = false;
    public Transform hitPoint;
    public float damageHitRadius;


    void Start()
    {
        player = FindObjectOfType<MoveBehaviour>().gameObject;
        animation = GetComponent<Animator>();
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject == player)
        {
            if (boxx == false)
            {
                animation.SetBool("run", false);
                animation.Play("Attak");
                Debug.Log("ffff");
                boxx = true;
            }
        }
    }

    public void Runn()
    {
        boxx = false;
        animation.SetBool("run", true);
    }



    public void Hit()
    {
        Collider[] hitColliders = Physics.OverlapSphere(hitPoint.position, damageHitRadius);
        for (int i = 0; i < hitColliders.Length; i++)
        {
            if (hitColliders[i].GetComponent<HP>())
            {
                HP.fill -= 0.10f;
            }
        }
    }
}

