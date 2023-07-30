using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigos : MonoBehaviour
{
    public Transform jugador;
    public float velocidad;
   
    void Update()
    {
        transform.LookAt(new Vector3(jugador.position.x,transform.position.y,jugador.position.z)); //gira para ver al jugar
        StartCoroutine ("enemy");     
    }
    IEnumerator enemy()
    {
       yield return new WaitForSeconds (1);
       transform.position = Vector3.MoveTowards(transform.position, new Vector3(jugador.position.x,transform.position.y,jugador.position.z), velocidad * Time.deltaTime);
    }
}
