using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pildoras : MonoBehaviour
{
    public GameObject puntos;
    public float puntosPildora;
    void OnTriggerEnter(Collider other) 
        {
          if(other.CompareTag("Player"))
          {
            puntos.GetComponent<Puntos>().puntos += puntosPildora; //suma los puntos de las pastillas 
            Destroy(gameObject); // destruye la pildora cuando nuestro jugador hace colision
          }
        }
    
}
