using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pildoras : MonoBehaviour
{
    public GameObject puntos;
    public float puntosPildora;
    public GameObject winText;
    void OnTriggerEnter(Collider other) 
        {
          if(other.CompareTag("Player"))
          {
            puntos.GetComponent<Puntos>().puntos += puntosPildora; //suma los puntos de las pastillas 
            Destroy(gameObject); // destruye la pildora cuando nuestro jugador hace colision
          }
          if(puntos.GetComponent<Puntos>().puntos >=700)
          {
            winText.SetActive(true);
            StartCoroutine("Win"); 
          }
        }
        IEnumerator Win() 
    {
        yield return new WaitForSeconds (6);   //El tiempo que demora para cargar la escena
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);  //reinica la escena
    }
    
}
