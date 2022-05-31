using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColors : MonoBehaviour
{
    private bool isClicked = false;
    //private static int scoreCounter = 0;
    //public Text scoreText;

    public void toBlue()
    {
        if (!isClicked)
        {
            this.GetComponent<Renderer>().material.color = Color.blue;
        }
    }

        public void toRed()
    {
        if (!isClicked)
        {
            this.GetComponent<Renderer>().material.color = Color.red;
        }
    }

        public void toBlack()
    {
        if (!isClicked)
        {
            this.GetComponent<Renderer>().material.color = Color.black;
            isClicked = true;
           // scoreCounter++;
           // scoreText.text = "Score: " + scoreCounter;

           // if (scoreCounter == 20)
            //{
             //   scoreText.text = "We have a WINNER";
            //}
        }
    }


}
