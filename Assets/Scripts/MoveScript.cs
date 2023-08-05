using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveScript : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        // Проверяем, что клик был сделан на цилиндре
        if (eventData.pointerCurrentRaycast.gameObject == gameObject)
        {
            // Вызываем событие клика на цилиндре в SignalBus
            SignalBus.CylinderClicked?.Invoke();
        }
    }
}