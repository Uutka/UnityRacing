using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    public float speed = 3;
    public GameObject bottomBG;
    public float backLength;
    public int backCount;
    private Vector2 direction;

    // Update is called once per frame
    void Update()
    {
        //speed = 3;
        transform.Translate(Vector2.down * speed * Time.deltaTime);

        if (transform.position.y < bottomBG.transform.position.y)
        {
            direction.Set(transform.position.x, transform.position.y + backLength * backCount);
            transform.position = direction;
        }
    }
}
