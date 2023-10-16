using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [Tooltip("Ÿ�� ��ũ��Ʈ")]
    [SerializeField] Tower towerPrefab;
    [Tooltip("�Ǽ� �������� Ȯ���ϴ� bool����")]
    [SerializeField] bool isPlaceable;

    public bool IsPlaceable
    {
        get
        {
            return isPlaceable;
        }

        set
        {
            isPlaceable = value;
        }
    }

    //public bool GetIsPlaceable()
    //{
    //    return isPlaceable;
    //}
    //public bool SetIsPlaceable()
    //{
    //    ...
    //}


    private void OnMouseDown()
    {
        if (isPlaceable)
        {
            towerPrefab.CreateTower(towerPrefab, transform.position);
            isPlaceable = false;
        }
        
    }
}
