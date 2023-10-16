using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Bank : MonoBehaviour
{
    [Tooltip("µ∑ UI")]
    [SerializeField] TextMeshProUGUI balanceText;
    [Tooltip("Ω√¿€ µ∑")]
    [SerializeField] int startBalance = 150;
    [Tooltip("«ˆ¿Á µ∑")]
    [SerializeField] int currentBalance;

    public int CurrentBalance
    {
        get 
        { 
            return currentBalance;
        }
    }

    private void Awake()
    {
        currentBalance = startBalance;
        UpdateBalanceText();
    }

    private void UpdateBalanceText()
    {
        balanceText.text = "Gold" + currentBalance;
    }

    public void Deposit(int amount)
    {
        currentBalance += Mathf.Abs(amount);
        UpdateBalanceText();
    }

    public void Withdraw(int amount)
    {
        currentBalance -= Mathf.Abs(amount);
        UpdateBalanceText();
        if (currentBalance < 0)
        {
            Debug.Log("∆–πË«ﬂΩ¿¥œ¥Ÿ.");
            ReloadScene();
        }
    }

    private void ReloadScene()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(0);
    }
}
