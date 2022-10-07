using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour

{
    public Vector3 startPosition;
    public float Speed;

    Vector3 movementDirection;
    // Start is called before the first frame update
    void Start()
    {
          //transform.position = startPosition;
    }

    // Update is called once per frame
    void Update()
    {

        movementDirection.x = Input.GetAxis("Horizontal") * Time.deltaTime * Speed;
        movementDirection.z = Input.GetAxis("Vertical") * Time.deltaTime * Speed;
        transform.Translate(movementDirection);


              if (Input.GetKey(KeyCode.A))

              {
                  Debug.Log("Apretaste la A");
                  movementDirection = new Vector3 (-Speed * Time.deltaTime, 0f, 0f);
              }

              if (Input.GetKey(KeyCode.D))

              {
            Debug.Log("Apretaste la A");
                  movementDirection = new Vector3 (Speed * Time.deltaTime, 0f, 0f);
              }

              if (Input.GetKey(KeyCode.W))

              {
                  Debug.Log("Apretaste la W");
                  movementDirection = new Vector3 (0f, 0f, Speed * Time.deltaTime);
              }

              if (Input.GetKey(KeyCode.S))

              {
                  Debug.Log("Apretaste la S");
                  movementDirection = new Vector3 (0f, 0f, -Speed * Time.deltaTime);
              }

              transform.Translate(movementDirection);

        
    }
}
