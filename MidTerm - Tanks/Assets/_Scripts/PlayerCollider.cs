using UnityEngine;
using System.Collections;

public class PlayerCollider : MonoBehaviour
{
   

    // PUBLIC INSTANCE VARIABLES
    public GameController gameController;

    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {  
            this.gameController.LivesValue -= 1;
        }
    }

}