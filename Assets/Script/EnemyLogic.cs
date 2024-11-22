using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class EnemyLogic : MonoBehaviour
{
    public float movementSpeed = 8f;
    public GameManager GM;
    float posX;
    public GameObject Player;
    private bool IsDead;

    [System.Obsolete]
    void Start()
    {
        GM = FindObjectOfType<GameManager>();
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        posX = transform.position.x;
        if (posX >= 0)
        {
            IsDead = true;
            GM.GameOver();
            Destroy(Player);
            return;
        }
        transform.position += Vector3.right * movementSpeed * Time.deltaTime;
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("Kena");
            Destroy(gameObject);
            Destroy(collision.gameObject);
            GM.KoinDiperoleh++;
        }

        if(collision.gameObject.CompareTag("Player") && !IsDead)
        {
            Debug.Log("Mati");
            Destroy(gameObject);
            Destroy(collision.gameObject);
            IsDead = true;
            GM.GameOver();
        }
    }
}
