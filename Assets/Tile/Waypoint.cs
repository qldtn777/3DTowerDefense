using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [Tooltip("타워 스크립트")]
    [SerializeField] Tower towerPrefab;
    [Tooltip("건설 가능한지 확인하는 bool변수")]
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
