using UnityEngine;

public class GameplayMusic : MonoBehaviour
{
    public AudioSource AS;
    public AudioClip Gameplay;
    public AudioClip YouWin;
    public AudioClip YouLose;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AS.PlayOneShot(Gameplay);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Goal"))
        {
            AS.PlayOneShot(YouWin);
        }
        if (other.gameObject.CompareTag("Hazard"))
        {
            AS.PlayOneShot(YouLose);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
