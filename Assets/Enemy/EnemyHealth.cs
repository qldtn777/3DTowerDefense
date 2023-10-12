using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 파티클에 충돌했을 때 데미지를 입는다.
public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int maxHP = 3;
    int currentHP = 0;
    
    void OnEnable()
    {
        currentHP = maxHP;
    }

    private void OnParticleCollision(GameObject other)
    {
        Damaged();
    }

    private void Damaged()
    {
        currentHP--;

        if(currentHP <= 0)
            gameObject.SetActive(false);
    }
}
