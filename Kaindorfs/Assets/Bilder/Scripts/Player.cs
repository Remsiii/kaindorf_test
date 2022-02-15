using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private int score = 0;
    //public Text scoreText;
    //public Text highScoreText;
    private int countNoten = 0;
    //public SpriteRenderer spriteRenderer;

    public DatabaseCharacter characterDB;
    public SpriteRenderer artworkSprite;
    private int selectedOption = 0;
    public Animator
        characterAnimation;


    //Animationen von Verschieden Charaktären



    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        countNoten = 0;
        //aktuellen Highscore laden
        //highScoreText.text = "Highscore: " + PlayerPrefs.GetInt("Highscore").ToString();

        // get selected character
        if (!PlayerPrefs.HasKey("selectedOption"))
        {
            selectedOption = 0;
        }
        else
        {
            Load();
        }
        UpdateCharacter(selectedOption);

       // CharacterSelection character = characterDB.GetCharacter(selectedOption);
       // artworkSprite.sprite = character.characterSprite;
        //spriteRenderer.sprite = artworkSprite.sprite;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Coin" || other.tag == "Fruewarnung")
        {
            //Grafik und Collider ausblenden
            other.gameObject.GetComponent<Renderer>().enabled = false;
            other.gameObject.GetComponent<Collider2D>().enabled = false;
            //Sound der Münze
            AudioSource audio = other.gameObject.GetComponent<AudioSource>();
            audio.Play();

            // herausfinden der Noten
            string noten = other.gameObject.GetComponent<SpriteRenderer>().sprite.name.ToString();
            //Debug.Log(noten);

            if (noten == "sehr_gut1")
            {
                score = score + 1;
                countNoten++;
            }
            else if(noten == "gut2")
            {
                score = score + 2;
                countNoten++;
            }
            else if (noten == "befriedigend3")
            {
                score = score + 3;
                countNoten++;
            }
            else if (noten == "genugend4")
            {
                score = score + 4;
                countNoten++;
            }
            else if (noten == "nicht_genugend5")
            {
                score = score + 5;
                countNoten++;
            }
            else if (noten == "fruhwahrnung")
            {
                isTriggerObject pop = GameObject.FindGameObjectWithTag("Fruewarnung").GetComponent<isTriggerObject>();
                pop.PopUp("Du hast eine Frühwahrnung! Bitte verbessere dein Note");
            }


            //scoreText.text = "Score: " + score.ToString();
            Destroy(other.gameObject, audio.clip.length);
            PlayerPrefs.SetInt("Score", score);
            PlayerPrefs.SetInt("CountScore", countNoten);
            //Debug.Log("Score:" + score);

            //if (score > PlayerPrefs.GetInt("Highscore"))
            //{
             //   PlayerPrefs.SetInt("Highscore", score);
               // highScoreText.text = "Highscore: " + PlayerPrefs.GetInt("Highscore").ToString();
            //}
        }
    }

    private void UpdateCharacter(int selectedOption)
    {
        CharacterSelection character = characterDB.GetCharacter(selectedOption);
        artworkSprite.sprite = character.characterSprite;
        characterAnimation.runtimeAnimatorController = character.characterAnimation;
}

    private void Load()
    {
        selectedOption = PlayerPrefs.GetInt("selectedOption");
    }
}
