using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl : MonoBehaviour
{
    ObjectPool bullets;

    Lifetime.Lifespan lifespan = new Lifetime.Lifespan();

    float timeCount = 0;
    float speed = 10;
    private void OnEnable()
    {
        timeCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * speed * Time.deltaTime;

        if (timeCount >= lifespan.span)
            bullets.removeObject(gameObject);

    }
}