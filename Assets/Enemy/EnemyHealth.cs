using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(EnemyMover))]
public class EnemyHealth : MonoBehaviour
{
    [Tooltip("�ִ� ü��")]
    [SerializeField] [Range(1,100)] int maxEnemyHp = 3;
    [Tooltip("���� ���� �� maxHP�� �߰��� ����")]
    [SerializeField] int difficultyIncrease = 1;
    [Tooltip("���� ���� ü��")]
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
