using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour

{
    public TextMeshProUGUI textoGameOver;
   
    void OnCollisionEnter(Collision col)       
        {
        if(col.gameObject.CompareTag("Player"))      //compara la etiqueta con el jugador
        {
            textoGameOver.gameObject.SetActive(true);  // activa el texto de Gameover
            StartCoroutine("Esperar");             //inicializa la corrutina
        }
    }
    IEnumerator Esperar() 
    {
        yield return new WaitForSeconds (6);   //El tiempo que demora para cargar la escena
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);  //reinica la escena
    }
}
