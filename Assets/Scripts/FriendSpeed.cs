using UnityEngine;

public class FriendSpeed : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float moveSpeed = 3f;
    public float JumpForce = 5f;
    public float decisionTime = 2f;
    private Rigidbody2D rb;
    private float timer;
    private int direction;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        timer = decisionTime;
        direction = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0f)
        {
            int action = Random .Range(0, 4);
            if (action == 0) direction = 0;
            else if (action == 1) direction = 1;
            else if (action == 2) direction = 1;
            else if (action == 3 && Mathf.Abs(rb.linearVelocity.y) < 0.01f)
            {
                rb.AddForce(new Vector3(0f,JumpForce,0f),ForceMode2D.Impulse);

            }
            timer = decisionTime;
        }
        rb.linearVelocity = new Vector3(direction * moveSpeed, rb.linearVelocity.y);  
            }
}
