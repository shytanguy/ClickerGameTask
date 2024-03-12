using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

/// <summary>
/// ����� ��� �������� � ����������� ������ ���������� ��������.
/// </summary>
public class AllResourcesCounterScript : TextFieldCounter
{
    [SerializeField] private ResourceSO[] resourcesToCount;

    private void OnEnable()
    {
        foreach (ResourceSO resource in resourcesToCount)
        {
            // ������������� �� ������� ��������� �������� ������� ��� ������� ������� � ������
            resource.ValueChanged += SetNewValue;
        }
    }

    private void OnDisable()
    {
        foreach (ResourceSO resource in resourcesToCount)
        {
            // ������������ �� ������� ��������� �������� ������� ��� ������� ������� � ������
            resource.ValueChanged -= SetNewValue;
        }
    }

    protected override void SetNewValue(int number)
    {
        CheckValue();
    }

    protected override void CheckValue()
    {
        int totalAmount = 0;
        foreach (ResourceSO resource in resourcesToCount)
        {
            // ��������� ����� ���������� ��������
            totalAmount += resource.Amount;
        }

        // ��������� ��������� �������� ���������� ���������� ��������
        ChangeTextValue(totalAmount);

    }
}