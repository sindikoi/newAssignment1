using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooter : MonoBehaviour
{
    [SerializeField] GameObject bullet; 
    [SerializeField] Transform bulletPosition;
    [SerializeField] int amoutOfEnemies = 200;

    // Update is called once per frame
    private void Start()
    {
        StartCoroutine(Shoot());
    }

    IEnumerator Shoot()
    {
        for(int i = 0; i<amoutOfEnemies;i++)
        {
            yield return new WaitForSeconds(0.3f);
            Instantiate(bullet, bulletPosition.position, Quaternion.identity);

        }
        

    }
}
