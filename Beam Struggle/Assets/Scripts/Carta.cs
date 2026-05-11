using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carta : MonoBehaviour
{
    public TipoCarta tipoCarta;
    public string Texto;
    public string CodigoID;
    public string NomeImagem;
    public AtributosSecundarios atributosSecundarios;

    public Carta (TipoCarta tipo, string texto, string codigoID, string nomeImagem, AtributosSecundarios atributos)
    {
        this.tipoCarta = tipo;
        this.CodigoID = codigoID;
        this.NomeImagem = nomeImagem;
        this.atributosSecundarios = atributos;

        this.Texto = texto;
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

