using System;
using UnityEngine;

public class Collectibles : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int score;
    public GameManager manager;
    private BoxCollider collader;
    void Start()
    {
        collader = GetComponent<BoxCollider>();
        if (!AmIExisting())
        {
            Destroy(gameObject);
        }
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        AddScore();
        Destroy(gameObject);
    }

    void AddScore()
    {
        manager.CurrentScore += score;
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private bool AmIExisting()
    {
        int RandomNumber = UnityEngine.Random.Range(0,2);

        if (RandomNumber == 1)
        {
            return true;
        }
        else { return false; }
    }
}
