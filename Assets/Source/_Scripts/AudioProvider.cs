
using UnityEngine;
using RB.Services.Audio;

public class AudioProvider : MonoBehaviour
{
    //добавляем звук
    [SerializeField] ClipContainer clipContainer;


    private void Start()
    {
        DontDestroyOnLoad(gameObject);
        //подписаться на событие в SignalBus  на уничтожения шарика
    }
    
    //подписываем этот метод
    private void PlayDestroySound()
    {
        AudioService.Instance.PlaySound(clipContainer.GetClip());
    }
}
