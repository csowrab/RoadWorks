using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO.Ports;

public class PlayerMover : MonoBehaviour{

    public Rigidbody rb;
    public Text Score;

    public float thrust;
    public int points = 0;
    string Ard;
    int JArd;
    int KArd;
    int LArd;
    SerialPort sp = new SerialPort("COM3", 9600);


    // Update is called once per frame
    void Start()
    {
        sp.Open();
        sp.ReadTimeout = 1;

        points = 0;
        PlayerPrefs.SetInt("Saved_score", points);
    }

    void Update(){

        if (transform.position.y >= 30) {

            points += 1;
            transform.position = new Vector3(transform.position.x, -10f, transform.position.z);
            FindObjectOfType<GameManager>().ChangeObst();
            Score.text = "Score: " + points.ToString();
            PlayerPrefs.SetInt("Saved_score", points);


        }

        rb.AddForce(0, thrust, 0);

        Ard = sp.ReadExisting();
        //Debug.Log("Hello")
        //if (Ard.Length != 0) { Debug.Log(Ard + ":V"); }

        JArd = Ard.IndexOf("J");
        KArd = Ard.IndexOf("K");
        LArd = Ard.IndexOf("L");
        

        if (Input.GetKey("l")| LArd != -1) {
            transform.position = new Vector3(3f,transform.position.y,transform.position.z);
          
        }

        if (Input.GetKey("k")| KArd != -1){
            transform.position = new Vector3(0, transform.position.y, transform.position.z);
        }

        if (Input.GetKey("j")| JArd != -1){
            transform.position = new Vector3(-3f, transform.position.y, transform.position.z);
        }

    }
}
