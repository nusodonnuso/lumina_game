
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemigo : MonoBehaviour
{
   [SerializeField] public float velocidad;
   [SerializeField] public Transform controladorSuelo;
   [SerializeField] public float distancia;
   [SerializeField] public bool moviendoDerecha;
   public Rigidbody2D rb;


   public void Start(){
    rb = GetComponent<Rigidbody2D>();
   }

   public void FixedUpdate() {
    RaycastHit2D informacionSuelo = Physics2D.Raycast(controladorSuelo.position, Vector2.down, distancia);

    rb.velocity = new Vector2(velocidad, rb.velocity.y);

    if (informacionSuelo == false)
{
    //Girar
    Girar();
}
   }
   public void Girar()
   {
    moviendoDerecha = !moviendoDerecha;
    transform.eulerAngles = new Vector3(0, transform.eulerAngles.y + 180,0);
    velocidad *= -1;
   }

   public void OnDrawGizmos() {
    Gizmos.color = Color.red;
    Gizmos.DrawLine(controladorSuelo.transform.position, controladorSuelo.transform.position + Vector3.down * distancia);
   }
}
