using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crown : MonoBehaviour
{

    public GameObject explosionPrefab;

    void OnCollisionEnter(Collision other)
    {
        print("Collided with " + other.gameObject.name);
        if (other.gameObject.CompareTag("Ground"))
        {
            Score score = FindFirstObjectByType<Score>();
            if (score)
            {
                score.EndLevel();
            }
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
