using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public Color itemColor;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().color = itemColor;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }




}
