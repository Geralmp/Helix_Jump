using UnityEngine;
using UnityEngine.SceneManagement;

public class Jugador : MonoBehaviour
{
    public float JumpSpeed;
    private bool isDead = false;
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

        if (collision.gameObject.CompareTag("Plataforma_perder") && !isDead) // Verificar si ya no está muerto
        {
            isDead = true;
            GameOver();
        }
    }

    private void GameOver()
    {
        // Añadir aquí cualquier acción adicional que necesites antes de cargar la escena de Game Over
        SceneManager.LoadScene("GameOverScene");
    }
}