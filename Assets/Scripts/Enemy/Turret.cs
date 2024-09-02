using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public float speed = 50f;
    public GameObject m_target;
    Vector3 m_lastKnownPosition = Vector3.zero;
    Quaternion m_lookAtRotation;
    float shootTimer = 0f;
    public float ShootRate = 2f;
    public GameObject bullet;
    public Transform ShootPoint;

    void Update()
    {
        if (m_target)
        {
            if (m_lastKnownPosition != m_target.transform.position)
            {
                m_lastKnownPosition = m_target.transform.position;
                m_lookAtRotation = Quaternion.LookRotation(m_lastKnownPosition - transform.position);
            }

            if (transform.rotation != m_lookAtRotation)
            {
                transform.rotation = Quaternion.RotateTowards(transform.rotation, m_lookAtRotation, speed * Time.deltaTime);
            }
        }
        if (Vector3.Distance(transform.position, m_target.transform.position) <= 10f)
        {
            if (shootTimer < ShootRate)
                shootTimer += Time.deltaTime;
            else
            {
                shootTimer = 0f;
                Shoot();
            }
        }

    }

    private void Shoot()
    {
        GameObject pulia = Instantiate(bullet, ShootPoint.position, ShootPoint.rotation);
        Destroy(pulia, 3f);
    }

    private void Start()
    {
        m_target = FindObjectOfType<MoveBehaviour>().gameObject;
    }

    public void setTarget(ref GameObject target)
    {
        m_target = target;
    }
}
    

