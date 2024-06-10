using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Passaro : MonoBehaviour
{
    private float velocidade = 3f;
    Rigidbody2D fisica;

    private void Awake()
    {
        this.fisica = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // chama o m�todo impulsionar
            // o this serve para indicar que � o objeto ativo naquele momento
            this.Impulsionar();
        }
    }
    // m�todo que impulsiona nosso p�ssaro
    private void Impulsionar()
    {
        this.fisica.AddForce(Vector2.up * velocidade, ForceMode2D.Impulse);
    }
}