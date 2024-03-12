using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

/// <summary>
/// ����������� ����� TextFieldCounter ������������� ������� ���������������� ��� ������ � ��������� ���������
/// </summary>
public abstract class TextFieldCounter : MonoBehaviour
{
    /// <summary>
    /// ������ �� ��������� ����.
    /// </summary>
    protected TextMeshProUGUI _textField;

    /// <summary>
    /// ��������� ����� ��� ���������� ����.
    /// </summary>
    [SerializeField] private string _initialText;


    private void Awake()
    {
        GetTextField();

        CheckValue();
    }

    /// <summary>
    /// ����� ��� ��������� ������ �� ��������� ����.
    /// </summary>
    protected void GetTextField()
    {
        // �������� �������� ��������� TextMeshProUGUI �� �������.
        TryGetComponent<TextMeshProUGUI>(out _textField);

        // ���� ��������� �� ������, ������� ��������� �� ������ � �������.
        if (_textField == null)
        {
            Debug.Log("����������� ��������� ���������� ����");
            return;
        }
    }

    /// <summary>
    /// ����������� ����� ��� ��������� ������ �������� � ��������� ����.
    /// </summary>
    /// <param name="value">����� �������� ��� ���������� ����.</param>
    protected abstract void SetNewValue(int value);

    /// <summary>
    /// ����������� ����� ��� �������� ��������, ������� ���������� ��������� � ��������� ����.
    /// </summary>
    protected abstract void CheckValue();

    /// <summary>
    /// ����� ��� ��������� ������ � ��������� ���� �� ������ ����������� �����.
    /// </summary>
    /// <param name="number">�����, ������� ����� ���������� � ��������� ����.</param>
    protected void ChangeTextValue(int number)
    {
        try
        {
            // �������� ����� ���������� ���� �� ������ ���������� ������ � ����������� �����.
            _textField.text = $"{_initialText}: {number}";
        }
        catch (NullReferenceException e)
        {
            // ������� ��������� �� ������ � ������ ������������� ���������� 
            Debug.Log(e);
        }
    }
}