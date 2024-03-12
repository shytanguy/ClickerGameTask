using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ����� ��� ����������� ���������� ������������� �������.
/// </summary>
public class ResourceCounterScript : TextFieldCounter
{
    [SerializeField] private ResourceSO _resourceToCount;

    protected override void SetNewValue(int value)
    {
        // ��������� ��������� �������� �������� �������
        ChangeTextValue(value);
    }

    private void OnEnable()
    {
        if (_resourceToCount != null)
        {
            // ������������� �� ������� ��������� �������� �������
            _resourceToCount.ValueChanged += SetNewValue;
        }
    }
    protected override void CheckValue()
    {
        SetNewValue(_resourceToCount.Amount);
    }
    private void OnDisable()
    {
        if (_resourceToCount != null)
        {
            // ������������ �� ������� ��������� �������� �������
            _resourceToCount.ValueChanged -= SetNewValue;
        }
    }
}