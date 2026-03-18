using UnityEngine;

public class radian : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 5f;
        float angle = 30f;
        float radians = angle * Mathf.Deg2Rad;

        Vector3 direction = new Vector3(Mathf.Cos(radians),0, Mathf.Sin(radians));;
        transform.position += direction * speed * Time.deltaTime;
    }
}
