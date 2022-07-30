using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBullets : MonoBehaviour
{
    public GameObject munition;
    public float speed = 2f;
    public float liveTime = 4f;
    public Vector3 direction = new Vector3(3f, 0f, 0f);

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyDelay", liveTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.localScale = new Vector3(2f, 2f, 2f);
        }
        Move();
    }
    
    private void Move()
    {
        transform.position += direction * speed * Time.deltaTime;
    }
    private void DestroyDelay()
    {
        Destroy(gameObject);
    }
}
