using UnityEngine;

public class B1e4 : MonoBehaviour
{
    public int energiaTotal = 200;
    public int costeHechizo = 10;
    void Start()
    {

        while (energiaTotal >= costeHechizo)
        {
            energiaTotal-= costeHechizo;
            Debug.Log("al hechizero le queda : " + energiaTotal);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
