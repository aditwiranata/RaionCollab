using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float bulletSpeed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * bulletSpeed * Time.deltaTime;
    }
}
