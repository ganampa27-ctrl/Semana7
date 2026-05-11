using UnityEngine;
using System.Collections.Generic;

public class B1e1 : MonoBehaviour
{
    List<int> numeros = new List<int>(){1, 2, 3, 4, 5, 6, 7 , 8, 9 , 10};
    void Start()
    {
        int i = 0;
                while (i < numeros.Count)
        {
            Debug.Log("numero : " + numeros[i]);
            i++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
