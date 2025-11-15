using UnityEngine;

public class CubeBehaviour : MonoBehaviour
{
    int score;
    void SetScore() 
    {
    }
    private void Awake()
    {
        SetScore();
    }
    private void OnEnable()
    {
        
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            gameObject.SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
