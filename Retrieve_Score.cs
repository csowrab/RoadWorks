using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Retrieve_Score : MonoBehaviour
{
    // Start is called before the first frame update
    public Text Points;

    void Start(){

        int Value = PlayerPrefs.GetInt("Saved_score");
        Points.text = Value.ToString();


    }

}
