using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject SelectedZombie;
    public GameObject[] Zombies;
    public Vector3 selectedSize;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SelectZombie(2);
    }

    // Update is called once per frame

    void SelectZombie(int index)
    {
        SelectedZombie = Zombies[index];
        SelectedZombie.transform.localScale = selectedSize;
        Debug.Log("selected: " + SelectedZombie.name);
    }

    void Update()
    {
        
    }
}
