using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{

    [SerializeField] float time = 0.2f;
    private bool colided = false;


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (colided)
            return;

        if(other.gameObject.CompareTag("Enemy"))
        {
            GetComponent<SpriteRenderer>().color = Color.red;
            Destroy(other.gameObject);
            StartCoroutine(WaitToDestroy());

        }
        else if(other.gameObject.CompareTag("WoodStep"))
        {
            StartCoroutine(WaitToDestroy());
        }

     
    }

    IEnumerator WaitToDestroy()
    {
        yield return new  WaitForSeconds(0.1f);
        Destroy(gameObject);
    }
}
