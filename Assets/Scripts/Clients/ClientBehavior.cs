using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientBehavior : MonoBehaviour
{
    public GameObject[] clients;
    public GameObject[] startButtons;
    private float minTime = 5.0f;
    private float maxTime = 15.0f;

    void Start()
    {
        StartCoroutine(RandomSpawn(minTime, maxTime));
    }

    IEnumerator RandomSpawn(float _min, float _max){
        while (true)
        {
            int _index = Random.Range(0, clients.Length);
            yield return new WaitForSeconds(Random.Range(_min, _max));
            clients[_index].SetActive(true);
            startButtons[_index].SetActive(true);
            Debug.Log("Client and Button activated at index: " + _index);
        }
    }
}
