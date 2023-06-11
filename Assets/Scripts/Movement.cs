using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float velocidade = 5f; // Velocidade de movimento da c�mera
    public Transform jogador; // Refer�ncia ao objeto do jogador

    private void Update()
    {
        // Movimentar a c�mera para a direita
        transform.Translate(Vector3.right * velocidade * Time.deltaTime);

        // Ajustar a posi��o do jogador para ficar no meio da tela
        jogador.position = new Vector3(transform.position.x, jogador.position.y, jogador.position.z);
    }
}