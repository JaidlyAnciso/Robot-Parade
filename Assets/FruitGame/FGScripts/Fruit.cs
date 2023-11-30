using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
   [SerializeField] GameObject [] friutPrefab;
   [SerializeField] float secondSpawn = 0.5f;
   [SerializeField] float minTras;
   [SerializeField] float maxTras;
    void Start()
    {
        StartCoroutine(FruitSpawn());
    }
IEnumerator FruitSpawn()
}
    while(true)
    {
        var wanted = Random.Range(minTras, maxTras);

        var position = new Vector3(wanted, transform.position.y);

        GameObject gameObject = Instantiate(friutPrefab[Random.Range(0, friutPrefab)],
        position, Quanternion.identity);

        yield return new WaitforSeconds(secondSpawn);
        Destroy(gameObject, 5f);

    }