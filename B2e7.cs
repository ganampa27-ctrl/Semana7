using UnityEngine;

public class B2e7 : MonoBehaviour
{
   
    void Start()
    {
        string[] inventario = new string[5]{ "Espada", "Escudo", "Poción", "Arco", "Flecha" };
        int i = 0;
        while (i < inventario.Length)
        {
            Debug.Log("Objeto " + i + ": " + inventario[i]);
            i++;
        }
         
        Debug.Log("¡Inventario completo!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
