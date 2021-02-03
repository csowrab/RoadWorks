using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO.Ports;


public class Restart : MonoBehaviour
{
    string Ard;
    int RArd;
    SerialPort sp = new SerialPort("COM3", 9600);

    void Start()
    {
        sp.Open();
        sp.ReadTimeout = 1;

    }

    // Update is called once per frame
    void Update(){

        Ard = sp.ReadExisting();
        RArd = Ard.IndexOf("R");

        if (Input.GetKey("r") | RArd != -1) {
            SceneManager.LoadScene("Level1");

        }

    }
}
