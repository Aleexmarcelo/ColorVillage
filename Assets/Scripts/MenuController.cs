using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    private void Awake()
    {
        // Verifica se a cena atual � a cena de menu (�ndice 0)
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
