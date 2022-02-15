using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checkpoint : MonoBehaviour
{
    public LevelManager levelManager;

    void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Scene scene = SceneManager.GetActiveScene();
        if (other.gameObject.tag == "Player")
        {
            if(scene.name == "KaffeeAutomat")
            {
                
                levelManager.currentCheckpoint = gameObject;
                PlayerPrefs.SetString("KaffeeAutomat", gameObject.tag);
                Debug.Log(PlayerPrefs.GetString("KaffeeAutomat"));
            }
            else if (scene.name == "AutomatisierungHall")
            {
                levelManager.currentCheckpoint = gameObject;
                PlayerPrefs.SetString("AutomatisierungHall", gameObject.tag);
            }
            else if (scene.name == "Automatisierung")
            {
                levelManager.currentCheckpoint = gameObject;
                PlayerPrefs.SetString("Automatisierung", gameObject.tag);
            }
            else if (scene.name == "CafeteriaLinks")
            {
                levelManager.currentCheckpoint = gameObject;
                PlayerPrefs.SetString("CafeteriaLinks", gameObject.tag);
            }
            else if (scene.name == "CafeteriaRechts")
            {
                levelManager.currentCheckpoint = gameObject;
                PlayerPrefs.SetString("CafeteriaRechts", gameObject.tag);
            }
            else if (scene.name == "HallGenerall")
            {
                levelManager.currentCheckpoint = gameObject;
                PlayerPrefs.SetString("HallGenerall", gameObject.tag);
            }
            else if (scene.name == "KlassenEG1")
            {
                levelManager.currentCheckpoint = gameObject;
                PlayerPrefs.SetString("KlassenEG1", gameObject.tag);
            }
            else if (scene.name == "KlassenEG2")
            {
                levelManager.currentCheckpoint = gameObject;
                PlayerPrefs.SetString("KlassenEG2", gameObject.tag);
            }
            else if (scene.name == "HallLab")
            {
                levelManager.currentCheckpoint = gameObject;
                PlayerPrefs.SetString("HallLab", gameObject.tag);
            }
            else if (scene.name == "TinfHall")
            {
                levelManager.currentCheckpoint = gameObject;
                PlayerPrefs.SetString("TinfHall", gameObject.tag);
            }
            else if (scene.name == "KlassenOG1")
            {
                levelManager.currentCheckpoint = gameObject;
                PlayerPrefs.SetString("KlassenOG1", gameObject.tag);
            }
            else if (scene.name == "KlassenOG2")
            {
                levelManager.currentCheckpoint = gameObject;
                PlayerPrefs.SetString("KlassenOG2", gameObject.tag);
            }


        }
    }
}
