using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int maxEnemyHp = 3;
    [SerializeField] int curEnemyHp = 0 ;
    Enemy enemy;


    private void OnEnable()
    {
        curEnemyHp = maxEnemyHp;
    }

    private void Start()
    {
        enemy = GetComponent<Enemy>();
    }

    private void OnParticleCollision(GameObject other)
    {
            hittedAction();
    }

    private void hittedAction()
    {
        curEnemyHp--;
        if(curEnemyHp <= 0)
        {
            gameObject.SetActive(false);
            enemy.RewardMoney();
        }
    }
}
