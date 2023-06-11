using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float velocidade = 5f; // Velocidade de movimento da câmera
    public Transform jogador; // Referência ao objeto do jogador

    private void Update()
    {
        // Movimentar a câmera para a direita
        transform.Translate(Vector3.right * velocidade * Time.deltaTime);

        // Ajustar a posição do jogador para ficar no meio da tela
        jogador.position = new Vector3(transform.position.x, jogador.position.y, jogador.position.z);
    }
}