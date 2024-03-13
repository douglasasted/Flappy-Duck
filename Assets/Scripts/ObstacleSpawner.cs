using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] obstacleInstances;
    [SerializeField] float obstacleCooldown;

    float currentObstacleCooldown;

    // Start is called before the first frame update
    void Start()
    {
        currentObstacleCooldown = obstacleCooldown;   
    }

    // Update is called once per frame
    void Update()
    {
        currentObstacleCooldown -= Time.deltaTime;

        if (currentObstacleCooldown < 0)
        {
            int obstacleIndex = Random.Range(0, obstacleInstances.Length);
            GameObject _obstacleInstance = Instantiate(obstacleInstances[obstacleIndex]);

            _obstacleInstance.transform.position = new Vector2(12, 0);

            currentObstacleCooldown = obstacleCooldown;
        }
    }
}
