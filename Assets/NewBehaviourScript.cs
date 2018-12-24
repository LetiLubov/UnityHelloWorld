using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    // void Start()
    // {
    //     rb.AddForce(10, 200, 200);
    // }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, 2000 * Time.deltaTime);
    }
}
