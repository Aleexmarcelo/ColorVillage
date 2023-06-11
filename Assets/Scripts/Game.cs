using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public float restartDelay = 8f;

    private void Start()
    {
        Invoke("RestartGame", restartDelay);
    }

    private void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
