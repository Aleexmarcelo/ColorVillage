using UnityEngine;

public class MusicController : MonoBehaviour
{
    private static MusicController instance;

    void Awake()
    {
        // Se já houver uma instância do objeto, destrua esse objeto
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        // Mantém o objeto persistente entre as cenas
        DontDestroyOnLoad(gameObject);

        instance = this;
    }
}
