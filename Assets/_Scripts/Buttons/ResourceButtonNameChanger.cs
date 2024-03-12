using System;
using TMPro;
using UnityEngine;

/// <summary>
/// ����� ��� ��������� ����� ������ �� ������ ���������� � �������.
/// </summary>
public class ResourceButtonNameChanger : MonoBehaviour
{
    [SerializeField] private ResourceSO _resource;
    private TextMeshProUGUI _buttonNameText;

    private void Awake()
    {
        try
        {
            // �������� ��������� TextMeshProUGUI �� �������� ��������
            _buttonNameText = GetComponentInChildren<TextMeshProUGUI>();

            // ������������� ����� ������ �� ������ �������� �������
            _buttonNameText.text = _resource.Name;
        }
        catch (NullReferenceException e)
        {
            // ����� ���������� NullReferenceException � ������� ��� � �������
            Debug.Log(e);
        }
    }
}