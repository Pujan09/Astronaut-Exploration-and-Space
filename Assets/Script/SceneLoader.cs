using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public GameObject audioManager;
    public string sceneName;

    private void Start()
    {
        
        DontDestroyOnLoad(audioManager);
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
