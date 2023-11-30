
using UnityEngine;

public class SideScrollerPlayer : MonoBehaviour
{
	
    public float moveSpeed = 10.0f;

    public float jumpForce = 0f;

    Rigidbody2D rb;

    public bool isGrounded = false;

    public bool shouldJump = false;
	
	public WordThing wordThing;
	string word;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
		wordThing = GetComponent<WordThing>();
		word = wordThing.ChooseNewWord();
    }
	
	int iterator = 0;
	
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            shouldJump = true;
        }
		
		string temp = word[iterator].ToString();
		if(Input.GetKeyDown(temp))
		{
			moveSpeed = 10.0f;
			iterator++;
			transform.Translate(new Vector3(1, 0, 0) * moveSpeed * Time.deltaTime);
		}
		else
		{
			moveSpeed = 0f;
		}
		if(iterator >= word.Length)
		{
			word = wordThing.ChooseNewWord();
			iterator = 0;
		}
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