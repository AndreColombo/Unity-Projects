using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    //cria a variavel fisica do tipo Rigidbody
    Rigidbody2D fisica;
    private Diretor diretor;
    private Vector3 posicaoInicial;

    private void Start()
    {
        //chamando no Start garante que s� ir� executar quando a cena estiver pronta
        this.diretor = GameObject.FindObjectOfType<Diretor>();
    }
    //m�todo Awake � chamado toda vez que o objeto � criado
    private void Awake()
    {
        //adiciona � variavel f�sica o componente RigidBody daquele objeto ativo no momento
        this.fisica = this.GetComponent<Rigidbody2D>();
        this.posicaoInicial = this.transform.position;
    }
    //m�todos private somente nossa classe pode acessar
    private void Update()
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
        //zera a velocidade antes de dar o impulso
        this.fisica.velocity = Vector2.zero;
        //adiciona a vari�vel f�sica e o m�todo AddForce, adicionando uma for�a para cima do tipo impulso
        this.fisica.AddForce(Vector2.up * 3, ForceMode2D.Impulse);
    }
    private void OnCollisionEnter2D(Collision2D colision)
    {
        this.fisica.simulated = false;
        this.diretor.FinalizarJogo();
    }
    public void Reiniciar()
    {
        this.transform.position = this.posicaoInicial;
        this.fisica.simulated = true;
    }
}