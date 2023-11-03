using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carta : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Set Dynamically")]

    public Sprite sprite;
    public string naipe;
    public int valor;
    public GameObject back = null;

    public bool faceUp = true;
    public string nome;
}
