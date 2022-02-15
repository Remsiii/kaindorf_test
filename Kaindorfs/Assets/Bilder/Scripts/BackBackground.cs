using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackBackground : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {

        changeScene(other, "Haupteingang", "KaffeeAutomat");
        changeScene(other, "KaffeeAutomat", "Haupteingang");
        changeScene(other, "AutomatisierungHall", "KaffeeAutomat");
        changeScene(other, "Automatisierung", "AutomatisierungHall");
        changeScene(other, "Automatisierung2", "Automatisierung");





        changeScene(other, "KlassenOG1", "Haupteingang");
        changeScene(other, "KlassenOG2", "KlassenOG1");
        changeScene(other, "KlassenEG1", "Haupteingang");
        changeScene(other, "HallGenerall", "KlassenEG1");
        changeScene(other, "KlassenEG2", "HallGenerall");


        changeScene(other, "KlassenEG2", "HallGenerall");
        changeScene(other, "HallLab", "KlassenOG2");
        changeScene(other, "TinfHall", "KlassenEG2");
        changeScene(other, "TinfLab", "TinfHall");
        changeScene(other, "CafeteriaLinks", "Haupteingang");
        changeScene(other, "CafeteriaRechts", "CafeteriaLinks");
        changeScene(other, "Lab", "HallLab");

        changeScene(other, "TurnsaalRechts", "TurnsaalLinks");
        changeScene(other, "TurnsaalLinks", "CafeteriaRechts");

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
