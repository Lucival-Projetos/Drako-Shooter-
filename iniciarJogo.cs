using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class iniciarJogo : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {


    }
    public void CarregarCena()
    {
        SceneManager.LoadScene("fase-1");
    }
}