
using UnityEngine;

public class SideScrollerPlayer : MonoBehaviour
{
	
    public float moveSpeed = 500.0f;

    public float jumpForce = 0f;

    Rigidbody2D rb;

    public bool isGrounded = false;

    public bool shouldJump = false;
	
	
	string word;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
		
    }
	
	int iterator = 0;
	
	public void MovePlayer(){
	
		moveSpeed = 500.0f;
		transform.Translate(new Vector3(1, 0, 0) * moveSpeed * Time.deltaTime);
	}
	
    // Update is called once per frame
    void Update()
    {
        
	}

    void OnTriggerEnter2D(Collider2D other)
    {
            isGrounded = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
            isGrounded = false;
    }
}