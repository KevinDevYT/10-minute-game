using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikespawner : MonoBehaviour
{
    public GameObject spikepre;
    public float maxtime, mintime;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spaen());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator spaen()
    {
        while (true)
        {
            float time = Random.Range(mintime, maxtime);
            yield return new WaitForSeconds(time);
            spawnspike();
        }
    }
    void spawnspike()
    {
        Instantiate(spikepre, transform.position, transform.rotation);
    }
}
