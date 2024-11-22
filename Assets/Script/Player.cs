using Unity.Mathematics;
using UnityEngine;

public class Script1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private float movementSpeed = 8f;
    private float maxDistance = 5f;
    public GameObject bullet;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputHorizontal = Input.GetAxisRaw("Horizontal");
        Vector3 movementDirection = new Vector3(0, 0, inputHorizontal);

        transform.position += movementDirection * movementSpeed * Time.deltaTime;

        Vector3 directionOutput = transform.position + (movementDirection * movementSpeed * Time.deltaTime);
        directionOutput.z = Mathf.Clamp(directionOutput.z, -maxDistance, maxDistance);
        transform.position = directionOutput;


        if (Input.GetMouseButtonDown(0)){
            Debug.Log("Tembak");
            GameObject newBullet = Instantiate(bullet, transform.position, quaternion.identity);
            Destroy(newBullet, 5f);
        }
    }
}
