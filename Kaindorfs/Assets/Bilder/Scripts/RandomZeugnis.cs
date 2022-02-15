using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomZeugnis : MonoBehaviour
{
    public GameObject itemPrefab;
    public GameObject itemPrefabFruwarnung;
    public Sprite[] spriteImages;
    public int notenAnzahl = 0;

    public float radius = 1.5f;


    private Vector2 cubeSize;
    private Vector2 cubeCenter;
    private BoxCollider2D bc;

    private void Awake()
    {
        GameObject roundGameObject = GameObject.FindGameObjectWithTag("ZeugnisToSpawn");
        bc = roundGameObject.GetComponent<BoxCollider2D>();
        Transform cubeTrans = bc.GetComponent<Transform>();
        cubeCenter = cubeTrans.position;

        // Multiply by scale because it does affect the size of the collider
        cubeSize.x = cubeTrans.localScale.x * bc.size.x;
        cubeSize.y = cubeTrans.localScale.y * bc.size.y;
    }

    // Start is called before the first frame update
    void Start()
    {
        // fill possible Spawn
       /* for(int i = 0; i < spawnPoints.Length; i++)
        {
            possibleSpawns.Add(spawnPoints[i]);
        }*/
        for (int i = 0; i < notenAnzahl; i++)
        {
            SpawnZeugnisAtRandom();
        }
        


    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnZeugnisAtRandom()
    {
        bool collision=false;
        Vector2 position = Vector2.zero;

            RandomNote();
            //GameObject a = Instantiate(itemPrefab) as GameObject;

            GameObject backgroundObject = GameObject.FindGameObjectWithTag("Background");

            GameObject roundGameObject = GameObject.FindGameObjectWithTag("ZeugnisToSpawn");
            BoxCollider2D bc = roundGameObject.GetComponent<BoxCollider2D>();
            Vector2 roundGameObjectPosition = roundGameObject.transform.localScale;

            Vector2 empytyGameObjectCoordinate = roundGameObject.transform.position;


            //float width = roundGameObjectPosition.x;
            //float height = roundGameObjectPosition.y
        //Debug.Log("Width: " + width + "    __Height:" + height);
        // muss noch bearbeitet werden(bug fixing)

        //a.transform.position = position;
        //position = empytyGameObjectCoordinate + new Vector2(Random.Range(-width *2.4f, width * 2.4f), Random.Range(-height * 2, height* 2));


        //position = empytyGameObjectCoordinate + new Vector2(x, y);

        Vector2 randomPosition = new Vector2(Random.Range(-cubeSize.x / 2, cubeSize.x / 2), Random.Range(-cubeSize.y / 2, cubeSize.y / 2));

        position = cubeCenter + randomPosition;


        collision = CheckforCollisions(position, radius);

        if (!collision)
        {
            Instantiate(itemPrefab, position, Quaternion.identity);
        }
        else
        {
            SpawnZeugnisAtRandom();
        }
        


    }

    static bool CheckforCollisions(Vector2 pos, float radius)
    {
        return Physics2D.OverlapCircle(pos, radius, LayerMask.GetMask("Default"));
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;

        Gizmos.DrawWireSphere(this.transform.position, radius);

        GameObject backgroundObject = GameObject.FindGameObjectWithTag("Background");
        float width = backgroundObject.GetComponent<SpriteRenderer>().sprite.bounds.size.x ;
        float height = backgroundObject.GetComponent<SpriteRenderer>().sprite.bounds.size.y;
        Vector3 test = backgroundObject.GetComponent<SpriteRenderer>().sprite.bounds.size;
        test.y = height;
        test.x = width;

    }


    void RandomNote()
    {

        SpriteRenderer spriteRenderer = itemPrefab.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = spriteImages[Random.Range(0, spriteImages.Length)];
    }


}
