using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEvent : MonoBehaviour
{
    private GameManager gameManager;
    private ParticleSystem explosion;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager")
            .GetComponent<GameManager>();
        explosion = GameObject.Find("FX_Explosion_Smoke").GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Cube")
        {
            explosion.transform.position = transform.position;
            explosion.Play();
            Destroy(gameObject);
            Destroy(other.gameObject);
            gameManager.updateScore();
        }
    }
}
