using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class isTriggerObject : MonoBehaviour
{
    public GameObject gameObject;
    public GameObject popUpBox;
    public Animator animator;
    public TMP_Text popUpText;

    private bool isStairsWPressed = false;
    private bool isInformaticEntrancePressed = false;



    private void Update()
    {
        if (isStairsWPressed)
        { 
            if (Input.GetKey(KeyCode.W))
            {

                SceneManager.LoadScene("KlassenOG1");
            }
        }

        if (isInformaticEntrancePressed)
        {
            if (Input.GetKey(KeyCode.W))
            {

                SceneManager.LoadScene("KlassenEG1");
            }
        }
    }


    public void PopUp(string text)
    {
        popUpBox.SetActive(true);
        popUpText.text = text;
        animator.SetTrigger("pop");
    }


    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player" && gameObject.tag == "Fruewarnung")
        {

        }

        if (other.tag == "Player" && gameObject.tag == "Stairs")
        {
            PopUp("Drücken Sie W um raufzugehen");
            isStairsWPressed = true;
        }
        else if (other.tag == "Player" && gameObject.tag == "Entrance")
        {
            PopUp("Drücken Sie W um die Informatik Abteilung beizutretten");
            isInformaticEntrancePressed = true;
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        
        if(collision.tag == "Player")
        {
            animator.SetTrigger("close");
        }

        if (collision.tag == "Player" && gameObject.tag == "Stairs")
        {
            isStairsWPressed = false;
        }

        if (collision.tag == "Player" && gameObject.tag == "Entrance")
        {
            isInformaticEntrancePressed = false;
        }
    }

}
