using UnityEngine;

public class B2e10 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string[] pociones = new string[4] { "Poción de vida", "Poción de maná", "Poción de velocidad",
                              "Poción de fuerza"};

        int posicion = 0;
        int contador = 0;

        while (posicion < pociones.Length)
        {
            Debug.Log("Poción encontrada: " + pociones[posicion]);
            contador++;
            posicion++;
        }

        Debug.Log("Total de pociones en el inventario: " + contador);
    }

    void Update()
    {
        
    }
}
