using UnityEngine;

public class MusicController : MonoBehaviour
{
    private static MusicController instance;

    void Awake()
    {
        // Se j� houver uma inst�ncia do objeto, destrua esse objeto
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        // Mant�m o objeto persistente entre as cenas
        DontDestroyOnLoad(gameObject);

        instance = this;
    }
}
