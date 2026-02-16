using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject SelectedZombie;
    public GameObject[] Zombies;
    public Vector3 selectedSize;
    InputAction left, right, vverh;
    private int selectedIndex = 0;
    public Vector3 pushForce;
    public TMP_Text Timer;
    private float time = 0 ;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        left = InputSystem.actions.FindAction("PrevZombie");
        right = InputSystem.actions.FindAction("NextZombie");
        vverh = InputSystem.actions.FindAction("Jump");
        SelectZombie(0);
    }

    // Update is called once per frame

    void SelectZombie(int index)
    {
        SelectedZombie.transform.localScale = Vector3.one;
        SelectedZombie = Zombies[index];
        SelectedZombie.transform.localScale = selectedSize;
        Debug.Log("selected: " + SelectedZombie.name);
    }

    void Update()
    {
        if (left.triggered)
        {
            selectedIndex--;
            if(selectedIndex < 0)
                selectedIndex = 3;
            SelectZombie(selectedIndex);
            Debug.Log("Left is pressed");
        }
        if (right.triggered)
        {
            selectedIndex++;
            if(selectedIndex >= Zombies.Length)
                selectedIndex = 0;
            SelectZombie(selectedIndex);
            Debug.Log("Right is pressed");
        }

        if (vverh.triggered)
        {
            Rigidbody rb= SelectedZombie.GetComponent<Rigidbody>();
            rb.AddForce(pushForce);
            Debug.Log("vverh is pressed");
        }
        time = time + Time.deltaTime;
        Timer.text = "Time: " + time.ToString("F0") + " s";
    }
}
