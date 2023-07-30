using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;
using TMPro;

public class Puntos : MonoBehaviour
{
    public float puntos;
    public TMP_Text TextoPuntos;
    
    private void Update()
    {
        TextoPuntos.text  =  puntos.ToString();   
    }
}
