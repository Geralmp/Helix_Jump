using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveController : MonoBehaviour
{
    public Vector3 rotationPercentage; // Porcentajes de rotación para cada eje
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Posición de " + this.name + " es " + this.transform.position);
        Debug.Log("Posición local de " + this.name + " es " + this.transform.localPosition);
        Debug.Log("Rotación de " + this.name + " es " + this.transform.eulerAngles);
        speed = 30f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            float rotationAmount = speed * Time.deltaTime * rotationPercentage.z; // Aplicar porcentaje de rotación en y
            this.transform.Rotate(0, 0, rotationAmount, Space.Self);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            float rotationAmount = -speed * Time.deltaTime * rotationPercentage.z; // Aplicar porcentaje de rotación en y
            this.transform.Rotate(0, 0, rotationAmount, Space.Self);
        }

            }
}
