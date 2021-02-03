using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{ 

    public BoxCollider BCA;
    public BoxCollider BCB;
    public BoxCollider BCC;

    public MeshRenderer MRA;
    public MeshRenderer MRB;
    public MeshRenderer MRC;


    System.Random Ran = new System.Random();
    int Choice;

    void Start(){

        int Choice = Ran.Next(1, 4);

        if (Choice == 1)
        {

            MRA.enabled = false;
            BCA.enabled = false;


        }

        if (Choice == 2)
        {

            MRB.enabled = false;
            BCB.enabled = false;

        }

        if (Choice == 3)
        {

            MRC.enabled = false;
            BCC.enabled = false;

        }


    }

    public void ChangeObst(){

        MRA.enabled = true;
        MRB.enabled = true;
        MRC.enabled = true;

        BCA.enabled = true;
        BCB.enabled = true;
        BCC.enabled = true;

        int NewChoice = Ran.Next(1, 4);

        while (NewChoice == Choice) {
            NewChoice = Ran.Next(1, 4);
        }

        Choice = NewChoice;

        if (Choice == 1) {

            MRA.enabled = false;
            BCA.enabled = false;
            

        }

        if (Choice == 2) {

            MRB.enabled = false;
            BCB.enabled = false;

        }

        if (Choice == 3) {

            MRC.enabled = false;
            BCC.enabled = false;

        }
        
        
    }

    public void GameOver() {


        SceneManager.LoadScene("GameOver");
        


    }
}
