using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D;
using UnityEngine;
using UnityEngine.UI;

public class Jugador : MonoBehaviour
{
    [SerializeField] private Vector2 velocidadX;
    [SerializeField] private Vector2 velocidadY;
    [SerializeField] private GameObject objectVirus1;
    [SerializeField] private GameObject objectVirus2;
    [SerializeField] private GameObject objectVirus3;
    [SerializeField] private GameObject objectVirus4;
    [SerializeField] private GameObject objectVirus5;
    [SerializeField] private GameObject objectVirus6;
    [SerializeField] private GameObject objectVirus7;
    [SerializeField] private GameObject objectVirus8;
    [SerializeField] private GameObject tabaBocas1;
    [SerializeField] private GameObject tabaBocas2;
    [SerializeField] private GameObject tabaBocas3;
    [SerializeField] private GameObject tabaBocas4;
    [SerializeField] private GameObject tabaBocas5;
    [SerializeField] private GameObject jugadorSano;
    [SerializeField] private GameObject jugadorEnfermo;
    [SerializeField] private GameObject jugadorProtegido;
    private float virusTomados, proteccion = 2;
    private bool banderaEnfermo = false, banderaProtegido = false;

    private Rigidbody2D jugador;

    // Start is called before the first frame update
    void Start()
    {
        jugador = GetComponent<Rigidbody2D>();
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

        if (virusTomados.Equals(1) && banderaEnfermo.Equals(true))
        {
            banderaEnfermo = false;
            jugadorEnfermo.SetActive(true);
            jugadorSano.SetActive(false);
        }
        else if (virusTomados.Equals(2))
        {
            print("El maricon se murio");
        }
        else if (proteccion.Equals(0) && banderaProtegido.Equals(true))
        {
            banderaProtegido = false;
            jugadorProtegido.SetActive(false);
            jugadorSano.SetActive(true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        #region Virus
        if (collision.collider.name.Equals("Virus1"))
        {
            objectVirus1.SetActive(false);
            if (banderaProtegido.Equals(false))
            {
                banderaEnfermo = true;
                virusTomados += 1;
            }
            else
            {
                proteccion -= 1;
            }
        }
        else if (collision.collider.name.Equals("Virus2"))
        {
            objectVirus2.SetActive(false);
            if (banderaProtegido.Equals(false))
            {
                banderaEnfermo = true;
                virusTomados += 1;
            }
            else
            {
                proteccion -= 1;
            }
        }
        else if (collision.collider.name.Equals("Virus3"))
        {
            objectVirus3.SetActive(false);
            if (banderaProtegido.Equals(false))
            {
                banderaEnfermo = true;
                virusTomados += 1;
            }
            else
            {
                proteccion -= 1;
            }
        }
        else if (collision.collider.name.Equals("Virus4"))
        {
            objectVirus4.SetActive(false);
            if (banderaProtegido.Equals(false))
            {
                banderaEnfermo = true;
                virusTomados += 1;
            }
            else
            {
                proteccion -= 1;
            }
        }
        else if (collision.collider.name.Equals("Virus5"))
        {
            objectVirus5.SetActive(false);
            if (banderaProtegido.Equals(false))
            {
                banderaEnfermo = true;
                virusTomados += 1;
            }
            else
            {
                proteccion -= 1;
            }
        }
        else if (collision.collider.name.Equals("Virus6"))
        {
            objectVirus6.SetActive(false);
            if (banderaProtegido.Equals(false))
            {
                banderaEnfermo = true;
                virusTomados += 1;
            }
            else
            {
                proteccion -= 1;
            }
        }
        else if (collision.collider.name.Equals("Virus7"))
        {
            objectVirus7.SetActive(false);
            if (banderaProtegido.Equals(false))
            {
                banderaEnfermo = true;
                virusTomados += 1;
            }
            else
            {
                proteccion -= 1;
            }
        }
        else if (collision.collider.name.Equals("Virus8"))
        {
            objectVirus8.SetActive(false);
            if (banderaProtegido.Equals(false))
            {
                banderaEnfermo = true;
                virusTomados += 1;
            }
            else
            {
                proteccion -= 1;
            }
        }
        #endregion

        #region TapaBocas
        if (collision.collider.name.Equals("TapaBocas1") && banderaProtegido.Equals(false))
        {
            tabaBocas1.SetActive(false);
            jugadorSano.SetActive(false);
            jugadorEnfermo.SetActive(false);
            jugadorProtegido.SetActive(true);
            virusTomados = 0;
            proteccion = 2;
            banderaProtegido = true;
        }
        else if (collision.collider.name.Equals("TapaBocas2") && banderaProtegido.Equals(false))
        {
            tabaBocas2.SetActive(false);
            jugadorSano.SetActive(false);
            jugadorEnfermo.SetActive(false);
            jugadorProtegido.SetActive(true);
            virusTomados = 0;
            proteccion = 2;
            banderaProtegido = true;
        }
        else if (collision.collider.name.Equals("TapaBocas3") && banderaProtegido.Equals(false))
        {
            tabaBocas3.SetActive(false);
            jugadorSano.SetActive(false);
            jugadorEnfermo.SetActive(false);
            jugadorProtegido.SetActive(true);
            virusTomados = 0;
            proteccion = 2;
            banderaProtegido = true;
        }
        else if (collision.collider.name.Equals("TapaBocas4") && banderaProtegido.Equals(false))
        {
            tabaBocas4.SetActive(false);
            jugadorSano.SetActive(false);
            jugadorEnfermo.SetActive(false);
            jugadorProtegido.SetActive(true);
            virusTomados = 0;
            proteccion = 2;
            banderaProtegido = true;
        }
        else if (collision.collider.name.Equals("TapaBocas5") && banderaProtegido.Equals(false))
        {
            tabaBocas5.SetActive(false);
            jugadorSano.SetActive(false);
            jugadorEnfermo.SetActive(false);
            jugadorProtegido.SetActive(true);
            virusTomados = 0;
            proteccion = 2;
            banderaProtegido = true;
        }
        #endregion

        if (collision.collider.name.Equals("Casa"))
        {
            print("Ganaste");
        }
    }
}