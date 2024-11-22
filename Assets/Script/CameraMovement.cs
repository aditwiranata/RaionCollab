using Unity.VisualScripting;
using UnityEngine;

public class Camera : MonoBehaviour
{

    public GameObject Player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( Player != null)
        {
        transform.position = Player.transform.position;
        }
    }
}
