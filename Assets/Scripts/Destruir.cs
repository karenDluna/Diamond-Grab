using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Destruir : MonoBehaviour
{
    
    public GameObject Limite;
    public GameObject Carrito;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
         if (collision.gameObject.tag == "Carrito")
        {
            Score.score++;
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "LimiteInferior")
        {
            Vidas.vida--;
            Destroy(gameObject);
        }
    }
}
