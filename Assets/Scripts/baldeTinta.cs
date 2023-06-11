using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baldeTinta : MonoBehaviour
{
    public Color[] colorList;
    public Color curColor;
    public int colorCount;

    public Collider2D[] colliders; // Array para armazenar os colisores

    void Start()
    {
        // Obtenha todos os colisores do objeto
        colliders = GetComponentsInChildren<Collider2D>();
    }

    void Update()
    {
        curColor = colorList[colorCount];

        if (Input.GetButton("Fire1"))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.GetRayIntersection(ray);

            if (hit.collider != null)
            {
                if (ArrayContainsCollider(colliders, hit.collider))
                {
                    SpriteRenderer sp = hit.collider.gameObject.GetComponent<SpriteRenderer>();
                    Debug.Log(hit.collider.name);
                    sp.color = curColor;
                }
                else
                {
                    Camera.main.backgroundColor = curColor;
                }
            }
        }
    }

        // Função auxiliar para verificar se um colisor está contido no array de colisores
        bool ArrayContainsCollider(Collider2D[] array, Collider2D collider)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == collider)
                return true;
        }
        return false;
    }

    public void paint(int colorCode)
    {
        colorCount = colorCode;
    }
}
