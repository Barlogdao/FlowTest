using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour
{
    private void OnEnable()
    {
        // ������������� �� ������� ����� �� ��������
        SignalBus.CylinderClicked += DestroySphere;
    }

    private void OnDisable()
    {
        // ������������ �� ������� ��� ���������� �������
        SignalBus.CylinderClicked -= DestroySphere;
    }

    private void DestroySphere()
    {
        // ���������� �����
        Destroy(gameObject);
    }
}
