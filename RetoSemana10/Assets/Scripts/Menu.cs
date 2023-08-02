using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public AudioSource clip;
   public void CambiarEscena(string nombre)
   {
    clip.Play();
    SceneManager.LoadScene(nombre);
   }
    public void QuitGame()
   {
    Application.Quit();
    clip.Play();
    Debug.Log("Salir");
   }
}
