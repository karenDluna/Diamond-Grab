using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using Random = UnityEngine.Random;

public class SpawnerD : MonoBehaviour
{
    [SerializeField]public float maxTime = 0;
    private float _timer = 0;
    public GameObject Diamante;
    public GameObject LowerLimit;

    [SerializeField]public float LeftLimit = 0;
    [SerializeField]public float RightLimit = 0;
    // Start is called before the first frame update
    void Start()
    {
        GameObject newspace = Instantiate(Diamante);
        newspace.transform.position = transform.position + new Vector3(Random.Range(-LeftLimit,RightLimit), y:0,0);
    }

    // Update is called once per frame
    void Update()
    {
       if (_timer > maxTime)
        {
            GameObject newspace = Instantiate(Diamante);
            newspace.transform.position = transform.position + new Vector3(Random.Range(-LeftLimit,RightLimit), y:4,0);

            Destroy(newspace,15);
            _timer = 0;
            }


        _timer += Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        //Destroy(newspace);
    } 
    
}
