using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chao : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 0.6f;

    private Vector3 posicaoInicial;
    private float tamanhoReal;
    // Start is called before the first frame update
    private void Awake()
    {
        this.posicaoInicial = this.transform.position;
        float tamanhoDaImagem = GetComponent<SpriteRenderer>().size.x;
        float escala = this.transform.localScale.x;
        this.tamanhoReal = tamanhoDaImagem * escala;
    }

    // Update is called once per frame
    void Update()
    {
        float deslocamento = Mathf.Repeat(this.velocidade * Time.time, tamanhoReal);
        this.transform.position = this.posicaoInicial + Vector3.left * deslocamento;
    }
}
