using UnityEngine;

public class Movement : MonoBehaviour

{
    void start()
    {

    }

    void Update()
    {
        transform.position += new Vector3(0, 10 * Time.deltaTime, 0);
    }
}