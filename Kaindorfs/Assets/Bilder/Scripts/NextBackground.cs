using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextBackground : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {

        GameObject backgroundObject = GameObject.FindGameObjectWithTag("Background");
        string backgroundName = backgroundObject.GetComponent<SpriteRenderer>().sprite.name.ToString();
        //Debug.Log(backgroundName);



        changeScene(other, "Haupteingang", "CafeteriaLinks");
        changeScene(other, "KaffeeAutomat", "AutomatisierungHall");
        changeScene(other, "AutomatisierungHall", "Automatisierung");
        changeScene(other, "Automatisierung", "Automatisierung2");

        changeScene(other, "CafeteriaLinks", "CafeteriaRechts");
        changeScene(other, "CafeteriaRechts", "TurnsaalLinks");
        changeScene(other, "TurnsaalLinks", "TurnsaalRechts");


        changeScene(other, "KlassenOG1", "KlassenOG2");
        changeScene(other, "KlassenOG2", "HallLab");
        changeScene(other, "HallLab", "Lab");
        changeScene(other, "KlassenEG1", "HallGenerall");
        changeScene(other, "HallGenerall", "KlassenEG2");
        changeScene(other, "KlassenEG2", "TinfHall");
        changeScene(other, "TinfHall", "TinfLab");



        //changeScene(other, "Haupteingang", "CafeteriaLinks");
        //changeScene(other, "CafeteriaLinks", "CafeteriaRechts");
        //changeScene(other, "CafeteriaRechts", "TurnsaalLinks");
        //changeScene(other, "TurnsaalRechts", "TurnsaalLinks");

        //if (other.tag == "Player" && backgroundName == "Haupteingang")
        //{
        //    SceneManager.LoadScene("");
        //}

    }

    void changeScene(Collider2D other, string backgroundName, string loadScreen)
    {
        GameObject backgroundObject = GameObject.FindGameObjectWithTag("Background");
        string backgroundNameGame = backgroundObject.GetComponent<SpriteRenderer>().sprite.name.ToString();

        if (other.tag == "Player" && backgroundNameGame == backgroundName)
        {
            SceneManager.LoadScene(loadScreen);
        }
    }
}
