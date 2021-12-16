using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 8f;
    public float turnSpeed = 20f;
    public float verticalInput;
    private float zMax = 450f;

    // Start is called before the first frame update
    void Start()
    {
        // posicion incial
        transform.position = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > zMax)
        {
            Debug.Log("THE END");
            Time.timeScale = 0;
        }
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        transform.Rotate(Vector3.left, turnSpeed * Time.deltaTime * verticalInput);
    }
}
