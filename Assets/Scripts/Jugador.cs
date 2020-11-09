using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    [SerializeField] private GameObject objectJugador;
    [SerializeField] private Vector2 velocidadX;
    [SerializeField] private Vector2 velocidadY;
    private float posicionX, posicionY;

    private Rigidbody2D jugador;

    // Start is called before the first frame update
    void Start()
    {
        jugador = objectJugador.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            jugador.transform.Translate(-velocidadX);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            jugador.transform.Translate(velocidadY);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            jugador.transform.Translate(-velocidadY);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            jugador.transform.Translate(velocidadX);
        }
    }
}