using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float speed = 0;
    public int coinCount = 0;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;
    public GameObject restartBtn;
    public GameObject quitBtn;
    public GameObject winPanel;

    private Rigidbody rb;
    private int count;
    private float movementX;
    private float movementY;

    // Start is called before the first frame update
    void Start()
    {
        speed = DataManager.speed;
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText(); // Update text to current count
        WinUI(false); // set win UI to inactive until win occurs
    }
    void WinUI(bool setActive)
    {
        winTextObject.SetActive(setActive); 
        restartBtn.SetActive(setActive); 
        quitBtn.SetActive(setActive);
        winPanel.SetActive(setActive);
    }
    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    void SetCountText()
    {
        countText.text = "Coins: " + count.ToString() + "/" + coinCount.ToString();
        if(count >= coinCount) // if player collects enough items show restart and quit menu plus win text
        {
            WinUI(true); // set win UI active
        }
    }
    void FixedUpdate() // use fixed update for physics stuff
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count++;
            SetCountText(); // Update text to current count
        }
        
    }
}
