using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma_puntos : MonoBehaviour
{
    public Puntaje PuntajePJ;
    public int PlataformaValor;
    public GameObject PlataformaProp1;
    public GameObject PlataformaProp2;
    public GameObject PlataformaProp3;
    public UnityEngine.UI.Text textoPuntos; // Referencia al objeto de texto en el juego

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            PlataformaProp1.SetActive(false);
            PlataformaProp2.SetActive(false);
            PlataformaProp3.SetActive(false);
            PuntajePJ.PlayerPuntos += PlataformaValor; // Incrementa el puntaje
            ActualizarTextoPuntos(); // Llama a la función para actualizar el texto de puntos
        }
    }

    void ActualizarTextoPuntos()
    {
        // Actualiza el texto de puntos con el valor actual del puntaje
        textoPuntos.text = "Puntos: " + PuntajePJ.PlayerPuntos.ToString();
    }
}