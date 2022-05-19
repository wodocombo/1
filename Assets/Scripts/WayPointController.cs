using UnityEngine;

public class WayPointController : MonoBehaviour
{
    private void Awake()
    {
        RandomPointSpawn();
    }

    private void RandomPointSpawn()
    {
        float x = Random.Range(-13, 13); 
        float z = Random.Range(-13, 13);

        transform.position = new Vector3(x, 2, z);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Wall" || other.gameObject.tag == "Enemy")
        {
            RandomPointSpawn();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Wall" || other.gameObject.tag == "Enemy")
        {
            RandomPointSpawn();
        }
    }
}
