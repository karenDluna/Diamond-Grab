using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarritoM : MonoBehaviour
{
     [SerializeField] private float velocity = 1f;
    private Rigidbody2D _rigidbody2D;
    [Header("left limit:")]
    public float leftLimit;
    [Header("right limit:")]
    public float rightLimit;

    [Header("Controles carrito:")] 
    [SerializeField] public KeyCode LeftControl;
    [SerializeField] public KeyCode RightControl;

    public Vector2 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        _rigidbody2D = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
     // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(LeftControl))
        {
            transform.Translate(x:velocity,0f,0f);
        }
        //Move DOWN
        else if (Input.GetKey(RightControl))
        {
            transform.Translate(-velocity,y:0f,0f);
        }
        //transform.position = new Vector2(Mathf.Clamp(transform.position.x,leftLimit,rightLimit),transform.position.y);
    }
    public void Reset()
    {
        _rigidbody2D.velocity = Vector2.zero;
        transform.position = startPosition;
    }


}
