using System;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// ����� ��� ���������� ������� ��� ����� �� ������.
/// </summary>
public class AddResourceScript : MonoBehaviour
{
    [SerializeField] private int _addOnClick = 1;
    [SerializeField] private ResourceSO _resource;

    private Button _resourceClickButton;

    private void Start()
    {
        _resourceClickButton = GetComponent<Button>();

        // ��������� ��������� ��� ������� ����� �� ������
        _resourceClickButton.onClick.AddListener(AddResource);
    }

    /// <summary>
    /// ����� ��� ���������� ������� ��� ����� �� ������.
    /// </summary>
    private void AddResource()
    {
        // ����������� �������� ������� �� ��������� ����������
        _resource.AddValue(_addOnClick);
    }
}