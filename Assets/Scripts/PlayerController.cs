using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;


public class PlayerController : MonoBehaviour
{
    public float speed;
    public TextMeshProUGUI countText;
    public GameObject WintextObject;
    private Rigidbody rb;
    private int count;
    private float movementX;
    private float movementY;


    // Start is called before the first frame update
    void Start() // Se ejecuta al principio,aunque no es un constructor,solo se ejecuta 1 vez
    {
        rb = GetComponent<Rigidbody>();
        count = 0;

        SetCountText();
        WintextObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
        count = count + 1;

        SetCountText();
    }




    private void OnMove(InputValue movementValue)
    {
        Vector2 movement = movementValue.Get<Vector2>();
        movementX = movement.x;
        movementY = movement.y;

       
    }
    void SetCountText()
    {
        countText.text = "Count:" + count.ToString();

        if (count >= 12)
        {
            WintextObject.SetActive(true);
        }
    }


    // Update is called once per frame
    void FixedUpdate()// Se ejecuta con cada Frame
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);//solo aplicamos fuerza a la X, como hacia arriba no va se pone cero.
        rb.AddForce(movement * speed);
    }
}

