using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour
{
    private void OnEnable()
    {
        // Подписываемся на событие клика на цилиндре
        SignalBus.CylinderClicked += DestroySphere;
    }

    private void OnDisable()
    {
        // Отписываемся от события при выключении скрипта
        SignalBus.CylinderClicked -= DestroySphere;
    }

    private void DestroySphere()
    {
        // Уничтожаем шарик
        Destroy(gameObject);
    }
}
