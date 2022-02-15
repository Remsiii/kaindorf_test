using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeacherIsTrigger : MonoBehaviour
{

    public GameObject gameObject;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && gameObject.tag == "Teacher")
        {
            if (PlayerPrefs.GetInt("CountScore") != 0)
            {
                float durchschnitt;
                //Debug.Log(PlayerPrefs.GetInt("Score")+ "::::: " + PlayerPrefs.GetInt("CountScore"));
                durchschnitt = PlayerPrefs.GetInt("Score") / PlayerPrefs.GetInt("CountScore");

                SceneManager.LoadScene("EndScene");
            }
        }
    }
}
