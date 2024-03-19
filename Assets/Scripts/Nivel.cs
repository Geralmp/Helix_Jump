using System.Collections;
using UnityEngine;

public class Nivel : MonoBehaviour
{
    public GameObject PlatformPrefab;
    private int PlatformAmount = 10;
    private float PlatformHeight = 1;
    private float RotationSpeed = 30f; // Ajusta la velocidad de rotación

    private void Start()
    {
        GeneradorDeNivel();
    }

    public void GeneradorDeNivel()
    {
        float angleStep = 360f / PlatformAmount;

        for (int i = 0; i < PlatformAmount; i++)
        {
            GameObject platformInstance = Instantiate(PlatformPrefab, Vector3.up * -PlatformHeight * i, Quaternion.Euler(0, angleStep * i, 0), transform);

            // Agregar rotación continua a las plataformas
            StartCoroutine(RotatePlatform(platformInstance.transform));
        }
    }

    IEnumerator RotatePlatform(Transform platformTransform)
    {
        while (true)
        {
            platformTransform.Rotate(Vector3.up, RotationSpeed * Time.deltaTime);
            yield return null;
        }
    }

    public void Clean()
    {
        int childCount = transform.childCount;
        for (int i = childCount - 1; i >= 0; i--)
        {
            DestroyImmediate(transform.GetChild(i).gameObject);
        }
    }
}