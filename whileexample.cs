using UnityEngine;

public class whileexample : MonoBehaviour
{
    public int[] numeros = new int[5] { 1, 2, 3, 4, 5 };
    void Start()
    {
        int i = 0;
        while (i < numeros.Length)
        {
            Debug.Log("cuenta regresiva : " + numeros[i]);
            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
