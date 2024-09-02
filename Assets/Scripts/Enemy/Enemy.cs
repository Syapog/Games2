using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public Transform player;
    public float rotation_speed;
    public Transform enemy;
    public NavMeshAgent agent;
    Animator animation;
    public float detectionDistance;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = FindObjectOfType<MoveBehaviour>().transform;
        animation = GetComponent<Animator>();
        animation.Play("Idle");

    }

    void Update()
    {
        if (Vector3.Distance(transform.position, player.position) <= detectionDistance)
        {
            //animation.Play("Run");
            animation.SetBool("run", true);
            agent.SetDestination(player.position);
        }
        else
        {
            animation.SetBool("run", false);
        }

        var look_dir = player.position - enemy.position;
        look_dir.y = 0;
        enemy.rotation = Quaternion.Slerp(enemy.rotation, Quaternion.LookRotation(look_dir), rotation_speed * Time.deltaTime);
    }

    private void Ann()
    {
        animation.SetBool("run", true);
    }
}
