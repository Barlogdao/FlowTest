
using UnityEngine;
using TMPro;

public class GameUI : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI _scoreText;
    private int _score=0;
    void Start()
    {
        _scoreText.text = _score.ToString();
    }


}
