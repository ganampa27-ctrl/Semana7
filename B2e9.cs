using UnityEngine;

public class B2e9 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string contraseña = "";

        do
        {
            contraseña = "admin"; 
            Debug.Log("Contraseña ingresada: " + contraseña);

        } while (contraseña != "admin");

        Debug.Log("¡Acceso concedido!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
