using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonAceptar : MonoBehaviour
{
    public Text BotonTxt;

    public void Ingreso()
    {
        BotonTxt.text = "Hola Mundo";
        Debug.Log(BotonTxt.text);
    }
}
