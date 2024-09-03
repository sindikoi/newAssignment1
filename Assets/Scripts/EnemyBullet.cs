using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    private GameObject player;
    private Rigidbody2D rb;
    [SerializeField] float speed = 1f;
    private bool colided = false;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
        Vector3 direction = player.transform.position - transform.position; // direction for the bullet
        rb.velocity = new Vector2(direction.x, direction.y).normalized * speed;

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (colided)
            return;


        if(other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject);
        }

        if(other.gameObject.CompareTag("Floor"))
        {
            StartCoroutine(WaitToDestroy());
        }
    }


    IEnumerator WaitToDestroy()
    {
        yield return null;
        Destroy(gameObject);
    }



}
