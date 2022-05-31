using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float power = 5;
    public Rigidbody rigidbody;
    public ParticleSystem particleSystem;

    // Start is called before the first frame update
    void Start()
    {
        particleSystem.transform.position = rigidbody.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigidbody.AddForce(new Vector3(0, 0, 1) * power);
        }

        if(Input.GetKey(KeyCode.DownArrow))
        {
            rigidbody.AddForce(new Vector3(0, 0, -1) * power);
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody.AddForce(new Vector3(1, 0, 0) * power);
        }

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody.AddForce(new Vector3(-1, 0, 0) * power);
        }

        particleSystem.transform.position = rigidbody.transform.position;
    }
}
