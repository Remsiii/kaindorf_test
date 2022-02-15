using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{

    // abgespeichert: akutelle Checkpoint, Spieler gameobjekt

    public GameObject currentCheckpoint;
    public GameObject spieler;

    //public static string objectName;


    void Awake()
    {
     

    }


    private void Start()
    {
        //RespawnPlayer();
        currentCheckpoint = GameObject.FindGameObjectWithTag("CheckPointLinks");
        Scene scene = SceneManager.GetActiveScene();
        Debug.Log(PlayerPrefs.GetString("KaffeeAutomat"));
        try
        {

            if (scene.name == "KaffeeAutomat" && PlayerPrefs.GetString("KaffeeAutomat") != "" && PlayerPrefs.GetString("KaffeeAutomat") != null)
            {
                currentCheckpoint = GameObject.FindGameObjectWithTag(PlayerPrefs.GetString("KaffeeAutomat"));
            }
            else if (scene.name == "AutomatisierungHall" && PlayerPrefs.GetString("AutomatisierungHall") != "" && PlayerPrefs.GetString("AutomatisierungHall") != null)
            {
                currentCheckpoint = GameObject.FindGameObjectWithTag(PlayerPrefs.GetString("AutomatisierungHall"));
            }
            else if ((scene.name == "Automatisierung" && PlayerPrefs.GetString("Automatisierung") != "" && PlayerPrefs.GetString("Automatisierung") != null))
            {
                currentCheckpoint = GameObject.FindGameObjectWithTag(PlayerPrefs.GetString("Automatisierung"));
            }
            else if ((scene.name == "CafeteriaLinks" && PlayerPrefs.GetString("CafeteriaLinks") != "" && PlayerPrefs.GetString("CafeteriaLinks") != null))
            {
                currentCheckpoint = GameObject.FindGameObjectWithTag(PlayerPrefs.GetString("CafeteriaLinks"));
            }
            else if ((scene.name == "CafeteriaRechts" && PlayerPrefs.GetString("CafeteriaRechts") != "" && PlayerPrefs.GetString("CafeteriaRechts") != null))
            {
                currentCheckpoint = GameObject.FindGameObjectWithTag(PlayerPrefs.GetString("CafeteriaRechts"));
            }
            else if ((scene.name == "HallGenerall" && PlayerPrefs.GetString("HallGenerall") != "" && PlayerPrefs.GetString("HallGenerall") != null))
            {
                currentCheckpoint = GameObject.FindGameObjectWithTag(PlayerPrefs.GetString("HallGenerall"));
            }
            else if ((scene.name == "KlassenEG1" && PlayerPrefs.GetString("KlassenEG1") != "" && PlayerPrefs.GetString("KlassenEG1") != null))
            {
                currentCheckpoint = GameObject.FindGameObjectWithTag(PlayerPrefs.GetString("KlassenEG1"));
            }
            else if ((scene.name == "KlassenEG2" && PlayerPrefs.GetString("KlassenEG2") != "" && PlayerPrefs.GetString("KlassenEG2") != null))
            {
                currentCheckpoint = GameObject.FindGameObjectWithTag(PlayerPrefs.GetString("KlassenEG2"));
            }
            else if ((scene.name == "HallLab" && PlayerPrefs.GetString("HallLab") != "" && PlayerPrefs.GetString("HallLab") != null))
            {
                currentCheckpoint = GameObject.FindGameObjectWithTag(PlayerPrefs.GetString("HallLab"));
            }
            else if ((scene.name == "TinfHall" && PlayerPrefs.GetString("TinfHall") != "" && PlayerPrefs.GetString("TinfHall") != null))
            {
                currentCheckpoint = GameObject.FindGameObjectWithTag(PlayerPrefs.GetString("TinfHall"));
            }
            else if ((scene.name == "KlassenOG1" && PlayerPrefs.GetString("KlassenOG1") != "" && PlayerPrefs.GetString("KlassenOG1") != null))
            {
                currentCheckpoint = GameObject.FindGameObjectWithTag(PlayerPrefs.GetString("KlassenOG1"));
            }
            else if ((scene.name == "KlassenOG2" && PlayerPrefs.GetString("KlassenOG2") != "" && PlayerPrefs.GetString("KlassenOG2") != null))
            {
                currentCheckpoint = GameObject.FindGameObjectWithTag(PlayerPrefs.GetString("KlassenOG2"));
            }
        }catch(System.Exception e)
        {
            print(e.ToString());
        }

        RespawnPlayer();
    }

    //Escape
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Spiel wird beendet
            Application.Quit();
        }
    }

    
    public void RespawnPlayer()
    {
        spieler.transform.position = currentCheckpoint.transform.position;

    }
    

}
