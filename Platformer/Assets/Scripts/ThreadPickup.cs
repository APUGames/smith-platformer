using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreadPickup : MonoBehaviour
{
    [SerializeField] CapsuleCollider2D playerBodyCollider;
    [SerializeField] int threadValue = 1;
    [SerializeField] AudioClip threadPickupSFX;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == playerBodyCollider)
        {
            FindObjectOfType<GameSession>().ProcessPlayerThread(threadValue);

            AudioSource.PlayClipAtPoint(threadPickupSFX, Camera.main.transform.position);
            Destroy(gameObject);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
