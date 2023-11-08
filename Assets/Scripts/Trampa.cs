using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Trampa : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Solo detecta colisiones del Player
        if (collision.CompareTag("Player") && !FindObjectOfType<Vidas>().inmortal)
        {
            //Encuentro el objeto Vidas en el juego
            GameObject vidas = GameObject.FindObjectOfType<Vidas>().gameObject;
            //Le resto un punto a la variable VidaTotal
            vidas.GetComponent<Vidas>().VidaTotal--;
            FindObjectOfType<CharacterController2D>().life--;
            //Muestro la VidaTotal en el texto del canvas
            vidas.GetComponent<TextMeshProUGUI>().text = vidas.GetComponent<Vidas>().VidaTotal.ToString();
            //Llamar a CondicionesVida para evaluar el GameOver
            vidas.GetComponent<Vidas>().CondicionesVida();
            //Devolver al jugador al inicio
            collision.transform.position = FindObjectOfType<Inicio>().transform.position;
        }
    }
}
