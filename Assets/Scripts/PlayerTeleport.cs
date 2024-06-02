using UnityEngine;

public class PlayerTeleport : MonoBehaviour
{
    private GameObject currentTeleporter;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (currentTeleporter != null)
            {
                Teleporter teleporter = currentTeleporter.GetComponent<Teleporter>();
                if (teleporter != null)
                {
                    transform.position = teleporter.GetDestination().position;
                }
            }
        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            if (currentTeleporter != null)
            {
                Teleporter2 teleporter = currentTeleporter.GetComponent<Teleporter2>();
                if (teleporter != null)
                {
                    transform.position = teleporter.GetDestination().position;
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Teleporter"))
        {
            currentTeleporter = collision.gameObject;
        }
        // else if (collision.CompareTag("Teleporter2"))
        // {
        //     currentTeleporter = collision.gameObject;
        // }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject == currentTeleporter)
        {
            currentTeleporter = null;
        }
    }
}
