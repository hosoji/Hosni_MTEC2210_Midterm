using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float speed = 5;
    float turboSpeed = 10;
    float currentSpeed;
    public Color turboColor;
    private Color defaultColor; 
    public SpriteRenderer sr;

    private Item lastItemICollidedWith;

    // Start is called before the first frame update
    void Start()
    {
        defaultColor = Color.white;
        //sr = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            currentSpeed = turboSpeed;
            sr.color = turboColor; 
        }
        else
        {
            currentSpeed = speed;
            sr.color = defaultColor;
        }


        float xMove = Input.GetAxisRaw("Horizontal");
        float yMove = Input.GetAxisRaw("Vertical");
        transform.Translate(xMove * currentSpeed * Time.deltaTime, yMove * currentSpeed * Time.deltaTime, 0);
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.tag == "Item")
        {
            //Debug.Log("We Collided");
            lastItemICollidedWith = collision.gameObject.GetComponent<Item>();
            defaultColor = lastItemICollidedWith.itemColor;
            sr.color = defaultColor;
            Destroy(collision.gameObject);
            

        }

    }
}
