using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausarMusica : MonoBehaviour
{
    public string gameObjectName;

    private void Start()
    {
        GameObject targetObject = GameObject.Find(gameObjectName);

        if (targetObject != null)
        {
            AudioSource audioSource = targetObject.GetComponent<AudioSource>();

            if (audioSource != null)
            {
                audioSource.Pause();
            }
            else
            {
                Debug.LogWarning("O componente AudioSource não foi encontrado no GameObject: " + gameObjectName);
            }
        }
        else
        {
            Debug.LogWarning("GameObject não encontrado com o nome: " + gameObjectName);
        }
    }
}