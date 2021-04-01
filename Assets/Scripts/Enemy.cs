using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public GameObject bottomBG;
    private GameObject newCar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //speed = 3;
        transform.Translate(Vector2.down * speed * Time.deltaTime, 0);

        if (transform.position.y < bottomBG.transform.position.y)
        {
            float RandX = Random.Range(-2.5f, 2.5f);
            float RandY = 7 + Random.Range(6f, 7f);

            transform.position = new Vector3(RandX, RandY, 0);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = speed / 2;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = speed * 2;
        }
    }
}
