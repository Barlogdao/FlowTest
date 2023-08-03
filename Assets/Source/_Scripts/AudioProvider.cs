
using UnityEngine;
using RB.Services.Audio;

public class AudioProvider : MonoBehaviour
{
    //��������� ����
    [SerializeField] ClipContainer clipContainer;


    private void Start()
    {
        DontDestroyOnLoad(gameObject);
        //����������� �� ������� � SignalBus  �� ����������� ������
    }
    
    //����������� ���� �����
    private void PlayDestroySound()
    {
        AudioService.Instance.PlaySound(clipContainer.GetClip());
    }
}
