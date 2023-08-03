using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] private int sceneNumber;
    void Start()
    {
        SceneManager.LoadScene(sceneNumber);
    }

}
