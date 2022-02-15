using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeacherScript : MonoBehaviour
{

    public Vector3 newPos;
    public Vector3 startPos;
    public float speed = 3f;
    public Vector3 helpPos;
    public SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;

        // zufällige Geschwindikeit generier
        speed = Random.Range(2f, 2f);

        helpPos = newPos;

        sr = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        newPos = startPos;

        newPos.x += Mathf.PingPong(Time.time * speed, 6) - 3;
        transform.position = newPos;


        //links rechts wechseln
        //positiv
        if (newPos.x > helpPos.x)
        {
            sr.flipX = true;
        }
        //negativ
        else
        {
            sr.flipX = false;
        }


        // Koordinaten aktueller Frame temporär abspeichern
        helpPos = newPos;
    }
}
