using System.Collections;
using System.Collections.Generic;


using UnityEngine;

public class PacmanMovement : MonoBehaviour
{
    [SerializeField] private float m_MovePower = 4f;
    [SerializeField] private bool m_UseTorque = true;
    [SerializeField] private float m_MaxAngularVelocity = 25f;

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        MovePacman(movement);
    }

    void MovePacman(Vector3 movement)
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        if (rb != null)
        {
            if (m_UseTorque)
            {
                rb.AddTorque(new Vector3(movement.z, 0.0f, -movement.x) * m_MovePower);
            }
            else
            {
                rb.AddForce(movement * m_MovePower);
            }

            rb.angularVelocity = Vector3.ClampMagnitude(rb.angularVelocity, m_MaxAngularVelocity);
        }
        else
        {
            Debug.LogWarning("Rigidbody component not found on Pacman GameObject.");
        }
    }
}