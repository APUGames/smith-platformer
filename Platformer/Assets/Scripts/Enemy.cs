using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Rigidbody2D enemyCharacter;

    [SerializeField] float moveSpeed = 1.0f;

    [SerializeField] BoxCollider2D playerFeet;

    // Start is called before the first frame update
    void Start()
    {
       enemyCharacter = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (isFacingRight())
        {
            enemyCharacter.velocity = new Vector2(moveSpeed, 0);
        }
        else
        {
            enemyCharacter.velocity = new Vector2(-moveSpeed, 0);
        }
    }
    private void OnTriggerExit2D()
    {
        transform.localScale = new Vector2(-(Mathf.Sign(enemyCharacter.velocity.x)), 1.0f);
    }

    bool isFacingRight()
    {
        return transform.localScale.x > 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision == playerFeet)
        {
            Destroy(gameObject);
        }
        

    }
}
