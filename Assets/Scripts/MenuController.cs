using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    private void Awake()
    {
        // Verifica se a cena atual é a cena de menu (índice 0)
        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex == 0)
        {          
            DesenhoManager desenhoManager = FindObjectOfType<DesenhoManager>();
            if (desenhoManager != null)
            {
                Destroy(desenhoManager.gameObject);
            }
        }
    }
}
