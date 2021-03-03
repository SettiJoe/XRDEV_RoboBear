using UnityEngine;
using UnityEngine.SceneManagement;

public class MainIntro : MonoBehaviour
{
    public void LaunchScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }

    public void QuitApp()
    {
        Application.Quit();
    }
}