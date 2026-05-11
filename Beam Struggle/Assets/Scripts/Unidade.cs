using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unidade : Carta
{
    
    public int VidaMaxima;

    public Unidade(string texto, string codigoID, string nomeImagem, AtributosSecundarios atributos, int vidaMaxima) : base(TipoCarta.Unidade, texto, codigoID, nomeImagem, atributos)
    {
        this.VidaMaxima = vidaMaxima;

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
