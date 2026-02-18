using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Death : MonoBehaviour
{
    public GameObject loseUI;
    private BoxCollider colladur;
    public GameManager gameManager;

    void Start()
    {
        colladur = GetComponent<BoxCollider>();

        loseUI.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
      loseUI.SetActive(true);
        Time.timeScale = 0f;
        gameManager.StopTimer = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1f;
    }
}
