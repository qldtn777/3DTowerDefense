using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(EnemyMover))]
public class EnemyHealth : MonoBehaviour
{
    [Tooltip("최대 체력")]
    [SerializeField] [Range(1,100)] int maxEnemyHp = 3;
    [Tooltip("적이 죽을 때 maxHP에 추가할 변수")]
    [SerializeField] int difficultyIncrease = 1;
    [Tooltip("적의 현재 체력")]
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
            maxEnemyHp += difficultyIncrease;
            enemy.RewardMoney();
        }
    }
}
