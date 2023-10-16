using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

// ���� �������� Ÿ�� ���� ��ġ�� ǥ��
[ExecuteAlways]
public class CoordinateLabeler : MonoBehaviour
{
    TextMeshPro label;
    Vector2Int coordinates = new Vector2Int();

    [Tooltip("�Ǽ� ������ Ÿ�� ��")]
    [SerializeField] Color defaultColor = Color.white;
    [Tooltip("�Ǽ� �Ұ����� Ÿ�� ��")]
    [SerializeField] Color blockColor = Color.gray;
    Waypoint waypoint;

    
    void Start()
    {
        label = GetComponent<TextMeshPro>();
        label.enabled = false;

        waypoint = GetComponentInParent<Waypoint>();

    }

    void Update()
    {
        if(!Application.isPlaying)
        {
            DisplayCoordinates();
            UpdateObjectName();
        }

        SetLabelColor();

        ToggleLablesIs();
    }

    private void ToggleLablesIs()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            label.enabled = !label.IsActive();
        }
    }

    private void SetLabelColor()
    {
        if (waypoint.IsPlaceable)
        {
           label.color = defaultColor;
        }
        else
        {
            label.color = blockColor;
        }
    }

    private void DisplayCoordinates()
    {
        coordinates.x = Mathf.RoundToInt(transform.parent.position.x);
        coordinates.y = Mathf.RoundToInt(transform.parent.position.z);
        label.text = $"{coordinates.x},{coordinates.y}";
    }

    void UpdateObjectName()
    {
        transform.parent.name = coordinates.ToString();
    }
}
