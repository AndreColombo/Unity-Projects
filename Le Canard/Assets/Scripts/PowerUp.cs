using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    [SerializeField]
    //cria uma variável para a velocidade
    private float velocidade = 0.6f;

    [SerializeField]
    //cria uma variável para guardar a posição y do meu objeto
    private float variacaoDaPosicaoY = 1.75f;

    private void Awake()
    {
        //quando meu objeto for criado, ele mudará a posição baseado em um valor
        //aleatório entre os intervalos do valor de y
        this.transform.Translate(Vector3.up * Random.Range(variacaoDaPosicaoY, -variacaoDaPosicaoY));
    }

    private void Update()
    {
        //adiciona movimento para a esquerda dos obstáculos
        this.transform.Translate(Vector3.left * velocidade * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D objetoQueEuColidi)
    {
        //Chamando o método Destruir cada vez que bater com a barreira
        this.Destruir();
    }

    public void Destruir()
    {
        Destroy(this.gameObject);
    }
}