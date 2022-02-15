using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndSceneText : MonoBehaviour
{
    //public static EndSceneText instance;
    public TMP_Text popUpText;


    //private void Awake()
    //{
    //    instance = this;

    //    DontDestroyOnLoad(this.gameObject);
    //}


    //public void SetEndSceneText(string text)
    //{
    //    EndSceneText.instance.popUpText.text = text;
    //}

    


    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("CountScore") != 0)
        {
            float durchschnitt;
            //Debug.Log(PlayerPrefs.GetInt("Score")+ "::::: " + PlayerPrefs.GetInt("CountScore"));
            durchschnitt = PlayerPrefs.GetInt("Score") / PlayerPrefs.GetInt("CountScore");

            if (durchschnitt >= 4)
            {
                popUpText.text = "Sie haben einen Notendurchschnitt von " + durchschnitt + ". Sie können das Spiel neu starten " +
                    "um sich zu verbesern.";
            }
            else
            {
                popUpText.text = "Hallo mein lieber Schüler! Dein Notendurchsnitt ist " + durchschnitt + ". " +
                    "Gut Gemacht! Du bist spitze!";
            }
        }
        else
        { 
            popUpText.text = "Sie haben noch keine Noten gesammelt!";
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
