using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Waypoint로 에네미를 이동
public class EnemyMover : MonoBehaviour
{
    [SerializeField] List<Waypoint> path = new List<Waypoint>();

    void Start()
    {
        //InvokeRepeating("PrintWaypointName", 0, 1);
        StartCoroutine(FollowPath());
    }

    IEnumerator FollowPath()
    {
        foreach (var waypoint in path)
        {
            Debug.Log(waypoint.name);
            transform.position = waypoint.transform.position;

            yield return new WaitForSeconds(1);
        }
    }
}
