using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Car : MonoBehaviour
{
    public float speed;

    public GameObject leftBorder;
    public GameObject rightBorder;

    public GameObject GameControllerObj; //не забудь перетащить в инспекторе сюда нужный обьект
    private GameController _actionTarget; //замени SomeMonoBehavior  на название скрипта

    public GameObject roadObj; //не забудь перетащить в инспекторе сюда нужный обьект
    private Road _roadObj; //замени SomeMonoBehavior  на название скрипта 

  

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
        _actionTarget = GameControllerObj.GetComponent<GameController>();
        _roadObj = roadObj.GetComponent<Road>();
    }

    // Update is called once per frame
    void Update()
    {
        //Движение налево
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            moveLeft();
        }
        if (Input.acceleration.x < 0)
        {
            moveLeft();
        }

        //движение направо
        if (Input.GetKey(KeyCode.RightArrow))
        {
            moveRight();
        }

        if (Input.acceleration.x > 0)
        {
            moveRight();
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            //_roadObj.speed = onBreak();
            onBreak();
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            _roadObj.speed = _roadObj.speed * 2;
        }

    }

    public void moveLeft()
    {
        if (transform.position.x > leftBorder.transform.position.x)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime, 0);
        }
    }

    public void moveRight()
    {
        if (transform.position.x < rightBorder.transform.position.x)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime, 0);
        }
    }

    public void onBreak()
    {
       // float originalSpeed = _roadObj.speed;

        _roadObj.speed = _roadObj.speed / 2;
        
        // Debug.Log(_roadObj.speed);
        //return originalSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        
        _actionTarget.ShowGameOver();
        gameObject.SetActive(false);
       // Destroy(gameObject);
    }
}
