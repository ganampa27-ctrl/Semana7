using UnityEngine;

public class B2e6 : MonoBehaviour
{
    
    void Start()
    {
        string[] enemigos = new string[5] { "Goblin", "Orco", "Dragón", "Esqueleto", "Troll" };

        int i = 0;

        while (i < enemigos.Length && enemigos[i] != "Dragón")
        {
            Debug.Log("Este no es: " + enemigos[i]);
            i++;
        }

        if (i < enemigos.Length)
        {
            Debug.Log("¡Dragón encontrado en la posición " + i + "!");
        }
        else
        {
            Debug.Log("No se encontró ningún Dragón.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
