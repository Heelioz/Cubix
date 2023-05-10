
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowObject : MonoBehaviour
{

public float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
       Destroy(gameObject, 10);

    }

    // Update is called once per frame
    void Update()
    {
       transform.position += -transform.up * Time.deltaTime * speed;
    }
}
