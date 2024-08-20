using UnityEngine;

public class DualButtonTrigger : MonoBehaviour
{
    public GameObject wall; 

    private bool isButton1Pressed = false;
    private bool isButton2Pressed = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Button2"))
        {
            isButton1Pressed = true;
        }
        else if (other.CompareTag("Button3"))
        {
            isButton2Pressed = true;
        }

        if (isButton1Pressed && isButton2Pressed)
        {
            OpenWall();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Button2"))
        {
            isButton1Pressed = false;
        }
        else if (other.CompareTag("Button3"))
        {
            isButton2Pressed = false;
        }

        if (!isButton1Pressed || !isButton2Pressed)
        {
            CloseWall();
        }
    }

    private void OpenWall()
    {
        Debug.Log("Both buttons pressed! Wall opens.");
        wall.SetActive(false); 
    }

    private void CloseWall()
    {
        Debug.Log("One or both buttons released. Wall closes.");
        wall.SetActive(true); 
    }
}
