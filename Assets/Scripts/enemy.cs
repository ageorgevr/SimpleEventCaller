using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    [SerializeField] ParticleSystem ps;

    void Start()
    {
        GameManager.instance.gameLost += SelfDestruct;
    }

    private void OnCollisionEnter(Collision collision)
    {
        SelfDestruct();
    }

    void SelfDestruct()
    {
        GameManager.instance.gameLost -= SelfDestruct;
        Destroy(gameObject);
        Instantiate(ps, transform.position, Quaternion.identity);
    }


}
