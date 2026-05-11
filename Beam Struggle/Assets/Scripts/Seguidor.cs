using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguidor : Unidade
{
    public CorSeguidor Cor;

    public Seguidor(string texto, string codigoID, string nomeImagem, AtributosSecundarios atributos, int vidaMaxima, CorSeguidor cor) 
           : base(texto, codigoID, nomeImagem, atributos, vidaMaxima)
    {
        this.Cor = cor;

        return;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
