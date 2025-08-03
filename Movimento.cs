using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{

    public float velocidade = 10f;

    void Start()
    {
        
    }


    void Update()
    {
        float inputHorizontal = Input.GetAxis("Horizontal");
        float inputVertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * inputHorizontal * velocidade * Time.deltaTime);
        transform.Translate(Vector3.up * inputVertical * velocidade * Time.deltaTime);
    }
}
