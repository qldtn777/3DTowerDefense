using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(TartgetLocator))]
public class Tower : MonoBehaviour
{
    [Tooltip("건설 소모 비용")]
    [SerializeField][Range(1, 1000)] int cost = 30;
    Bank bank;
    public bool CreateTower(Tower tower,Vector3 position)
    {
        bank = FindObjectOfType<Bank>();
        if (bank.CurrentBalance >= cost)
        {
            Instantiate(tower.gameObject, position, Quaternion.identity);
            bank.Withdraw(cost);
        }
        return true;
    }
}
