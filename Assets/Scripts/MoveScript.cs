using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveScript : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        // ���������, ��� ���� ��� ������ �� ��������
        if (eventData.pointerCurrentRaycast.gameObject == gameObject)
        {
            // �������� ������� ����� �� �������� � SignalBus
            SignalBus.CylinderClicked?.Invoke();
        }
    }
}