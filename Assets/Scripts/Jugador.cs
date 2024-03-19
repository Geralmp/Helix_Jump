using UnityEngine;
using UnityEngine.SceneManagement;

public class Jugador : MonoBehaviour
{
    public float JumpSpeed;
    private bool isDead = false;
    private bool isWinner = false;

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
        }

        if (collision.gameObject.CompareTag("Plataforma_perder") && !isDead) 
        {
            isDead = true;
            GameOver();
        }

        if (collision.gameObject.CompareTag("winnerr") && !isDead) 
        {
            isWinner = false;
            winner();
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