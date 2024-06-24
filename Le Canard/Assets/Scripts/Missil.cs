using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missil : MonoBehaviour
{
    [SerializeField]
    //cria uma vari�vel para a velocidade
    private float velocidade = 1;

    [SerializeField]
    //cria uma vari�vel para guardar a posi��o y do meu objeto
    private float variacaoDaPosicaoY = 1.75f;

    private void Awake()
    {
        //quando meu objeto for criado, ele mudar� a posi��o baseado em um valor
        //aleat�rio entre os intervalos do valor de y
        this.transform.Translate(Vector3.up * Random.Range(variacaoDaPosicaoY, -variacaoDaPosicaoY));
    }

    private void Update()
    {
        //adiciona movimento para a esquerda dos obst�culos
        this.transform.Translate(Vector3.left * velocidade * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D objetoQueEuColidi)
    {
        //Chamando o m�todo Destruir cada vez que bater com a barreira
        this.Destruir();
    }

    public void Destruir()
    {
        Destroy(this.gameObject);
    }
}