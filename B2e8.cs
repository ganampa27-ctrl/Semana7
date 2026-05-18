using UnityEngine;

public class B2e8 : MonoBehaviour
{
    
    void Start()
    {
        int monedas = 0;
        int gananciaPorRonda = 15;

        while (monedas < 100)
        {
            int monedastotales = monedas + gananciaPorRonda;
            Debug.Log("Ganaste " + gananciaPorRonda + " monedas. Total: " + monedastotales);
            monedas = monedastotales;
        }

        Debug.Log("¡Llegaste a 100 de oro! Total final: " + monedas);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
