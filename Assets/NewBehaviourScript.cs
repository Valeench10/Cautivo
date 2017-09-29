using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour {

    public InputField field;
    public string nombre;
    public Text texto;

    public void SayHello()
    {
        nombre = field.text;
        texto.text = "Holi " + nombre;
    }
   
}
