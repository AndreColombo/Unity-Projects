using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    [SerializeField]
    //cria uma variável para a velocidade
    private float velocidade = 0.6f;

    [SerializeField]
    //cria uma variável para guardar a posição y do meu objeto
    private float variacaoDaPosicaoY = 1.75f;

    private Vector3 posicaoBird;
    private bool pontuei;
    //criamos uma variável para acessar a classe Pontuacao
    private UIController controladorUI;

    private void Awake()
    {
        //quando meu objeto for criado, ele mudará a posição baseado em um valor
        //aleatório entre os intervalos do valor de y
        this.transform.Translate(Vector3.up * Random.Range(variacaoDaPosicaoY, -variacaoDaPosicaoY));
    }

    private void Start()
    {
        this.posicaoBird = GameObject.FindObjectOfType<Bird>().transform.position;
        //atribuímos ao controladorUI o objeto UIController
        this.controladorUI = GameObject.FindObjectOfType<UIController>();
    }

    private void Update()
    {
        //adiciona movimento para a esquerda dos obstáculos
        this.transform.Translate(Vector3.left * velocidade * Time.deltaTime);
        if (!this.pontuei && this.transform.position.x < this.posicaoBird.x)
        {
            this.pontuei = true;
            this.controladorUI.AdicionarPontos();
        }
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