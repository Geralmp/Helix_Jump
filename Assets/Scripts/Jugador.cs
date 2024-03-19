using UnityEngine;
using UnityEngine.SceneManagement;

public class Jugador : MonoBehaviour
{
    public float JumpSpeed;
    private bool isDead = false;
    private bool isWinner = false;
    public AudioClip Sound;
    public AudioClip Sound2;
    public AudioClip GameoverSound;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Plataforma"))
        {
            rb.AddForce(Vector3.up * JumpSpeed, ForceMode.Impulse);
            Camera.main.GetComponent<AudioSource>().PlayOneShot(Sound);
        }

        if (collision.gameObject.CompareTag("Plataforma_perder") && !isDead) 
        {
            isDead = true;
            GameOver();
            Camera.main.GetComponent<AudioSource>().PlayOneShot(GameoverSound);
        }

        if (collision.gameObject.CompareTag("winnerr") && !isDead) 
        {
            isWinner = false;
            winner();
            Camera.main.GetComponent<AudioSource>().PlayOneShot(Sound2);
        }
    }

    private void GameOver()
    {
        SceneManager.LoadScene("GameOverScene");
    }

    private void winner()
    {
        SceneManager.LoadScene("winner");
    }
}