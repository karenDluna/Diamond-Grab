using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamanteM : MonoBehaviour
{
    [Tooltip("velocidad de caida en unidades de unity")]
    [SerializeField] public float velocitiy = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * Random.Range(4f,10f) * Time.deltaTime;
    }
}
