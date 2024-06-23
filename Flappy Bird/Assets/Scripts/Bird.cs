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
        //chamando no Start garante que só irá executar quando a cena estiver pronta
        this.diretor = GameObject.FindObjectOfType<Diretor>();
    }
    //método Awake é chamado toda vez que o objeto é criado
    private void Awake()
    {
        //adiciona à variavel física o componente RigidBody daquele objeto ativo no momento
        this.fisica = this.GetComponent<Rigidbody2D>();
        this.posicaoInicial = this.transform.position;
    }
    //métodos private somente nossa classe pode acessar
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // chama o método impulsionar
            // o this serve para indicar que é o objeto ativo naquele momento
            this.Impulsionar();
        }
    }
    // método que impulsiona nosso pássaro
    private void Impulsionar()
    {
        //zera a velocidade antes de dar o impulso
        this.fisica.velocity = Vector2.zero;
        //adiciona a variável física e o método AddForce, adicionando uma força para cima do tipo impulso
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