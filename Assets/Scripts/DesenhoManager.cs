using UnityEngine;
using UnityEngine.SceneManagement;

public class DesenhoManager : MonoBehaviour
{
    private static DesenhoManager instance;
    public GameObject desenho;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetDesenho(GameObject objeto)
    {
        desenho = objeto;
    }

    public GameObject GetDesenho()
    {
        return desenho;
    }

    public void VirarDesenho()
    {
        if (desenho != null)
        {
            // Gira o desenho em 90 graus no eixo Y
            desenho.transform.position = new Vector3(9f, -40f, 90f);

            // Define a rotação do desenho para o valor correto
            desenho.transform.rotation = Quaternion.Euler(0f, 0f, 0f);

            // Define a escala do desenho para o valor correto
            desenho.transform.localScale = new Vector3(4f, 8f, 30f);
        }
    }
}
