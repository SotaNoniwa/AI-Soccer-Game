using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentController : MonoBehaviour
{
    public float speed = 2.0f;
    private float interval = 2.0f;
    Vector3 randomDirection;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ChangeDirection", 2.0f, interval);
    }

    // Update is called once per frame
    private void ChangeDirection()
    {
        randomDirection = new Vector3(Random.Range(-1f, 1f), 0f, Random.Range(-1f, 1f)).normalized;
    }

    void Update()
    {
        transform.Translate(randomDirection * speed * Time.deltaTime);
    }
}
