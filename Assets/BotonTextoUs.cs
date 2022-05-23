using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonTextoUs : MonoBehaviour
{
    public Text Message;
    public Text BotonTxt;

    public void IngresoMensaje()
    {
        BotonTxt.text = Message.text;
        Debug.Log("Hola " + BotonTxt.text);
    }
}
