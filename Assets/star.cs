using UnityEngine;

public class star : MonoBehaviour
{
     public float velocidadeRotacao = 100f;
    public GameObject player; 

    void Update()
    {
        transform.Rotate(Vector3.up * velocidadeRotacao * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            Destroy(gameObject);
        }
    }
}
