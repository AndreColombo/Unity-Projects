using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Preciso importar o namespace UI
using UnityEngine.UIElements;

public class UIController : MonoBehaviour
{
    private int pontos;
    // Criar uma variável do tipo Label que irá guardar a propriedade label
    private Label labelPontuacao;

    // Start is called before the first frame update
    void Start()
    {
        // quando o jogo iniciar, criaremos uma variável para acessar nossos
        // elementos visuais
        var root = GetComponent<UIDocument>().rootVisualElement;
        // depois atribuíremos para a variável labelPontuacao a label Pontos
        // atrav�s do método Q, de Query
        labelPontuacao = root.Q<Label>("pontos");
    }

    public void AdicionarPontos()
    {
        this.pontos++;
        //Quando adicionar os pontos ele muda o texto para o valor da variável pontos convertendo para String
        this.labelPontuacao.text = this.pontos.ToString();
    }

}