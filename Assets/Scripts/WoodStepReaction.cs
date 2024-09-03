using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodStepReaction : MonoBehaviour
{
    [SerializeField] GameObject woodenParts;
    [SerializeField] GameObject prefab;
    [SerializeField] int amount = 2;
    private void OnCollisionEnter2D(Collision2D other)
    {
       if(other.gameObject.CompareTag("Bullet"))
        {
            StartCoroutine(Shoot());
        }

    }

    IEnumerator Shoot()
    {
        for(int i = 0; i<amount; i++)
        {
            yield return null;

            Vector2 woodPosition = transform.position;
            Vector2 spawnpPosition = woodPosition + new Vector2(Random.Range(-0.2f, 0.2f), Random.Range(-0.2f, 0.2f));

            Instantiate(woodenParts, spawnpPosition, Quaternion.identity);

        }
    }
}
