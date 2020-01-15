using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("hello ball");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        GameObject.Find("GameManager").GetComponent<GameManager>().Scoreup();
        Destroy(gameObject);   
    }
}
