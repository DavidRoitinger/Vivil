using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleRain : MonoBehaviour
{

    public GameObject drop;
    IEnumerator Start()
    {
        FindObjectOfType<AudioManager>().Play("Theme");

        while (true)
        {
            Instantiate(drop, new Vector3(Random.Range(-10, 10), 15, 0), Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
            Instantiate(drop, new Vector3(Random.Range(-10, 10), 15, 0), Quaternion.identity);
            yield return new WaitForSeconds(1);
            Instantiate(drop, new Vector3(Random.Range(-10, 10), 15, 0), Quaternion.identity);
            yield return new WaitForSeconds(0.75f);
        }
    }

    
}