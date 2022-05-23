using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IngresoTexto : MonoBehaviour
{
    public Text Mensaje;
    public Text BotonTxt;
    public void TocarBoton()
    {
        BotonTxt.text = Mensaje.text;
        Debug.Log(BotonTxt.text);
    }
}
