using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TartgetLocator : MonoBehaviour
{
    [SerializeField] Transform weapon;
    [SerializeField] Transform target;
    [SerializeField] float range = 15f;
    [SerializeField] ParticleSystem weaponParticle;


    void Start()
    {
        target = FindObjectOfType<EnemyMover>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        FindClosestTarget();
        AimTarget();
    }

    private void FindClosestTarget()
    {
        EnemyMover[] enemies = FindObjectsOfType<EnemyMover>() ;
        Transform closestTarget = null;
        float maxDistance = Mathf.Infinity;
        foreach(EnemyMover enemy in enemies)
        {
            float targetDistance = Vector3.Distance(transform.position,enemy.transform.position);

            if(targetDistance <  maxDistance )
            {
                closestTarget = enemy.transform;
                maxDistance = targetDistance;
            }
        }
        target = closestTarget;
    }

    private void AimTarget()
    {
        bool attackbool = false;
        weapon.LookAt(target);
        if (Vector3.Distance(transform.position,target.transform.position)<=range)
        {
            attackbool = true;
        }
        Attack(attackbool);
    }

    private void Attack(bool v)
    {
        //ParticleSystem.EmissionModule emission = weaponParticle.emission;
        var emission = weaponParticle.emission;

        if(v == true)
        {
            emission.enabled = v;
        }
        else
        {
            emission.enabled = false;
        }
    }
}
