using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDePowerUps : MonoBehaviour
{
    [SerializeField]
    private float tempoParaGerar = 12;

    private float cronometro;

    [SerializeField]
    private GameObject modeloPowerUp;

    private void Awake()
    {
        this.cronometro = this.tempoParaGerar;
    }

    void Update()
    {
        this.cronometro -= Time.deltaTime;
        if (this.cronometro < 0)
        {
            GameObject.Instantiate(this.modeloPowerUp, this.transform.position, Quaternion.identity);
            this.cronometro = this.tempoParaGerar;
        }
    }
}