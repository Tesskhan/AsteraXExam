using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class JumpsGT : MonoBehaviour
{
    public TextMeshProUGUI jumpsText;
    private int jumps = 3;
    // Start is called before the first frame update
    void Start()
    {
        jumpsText.text = "Jumps: " + jumps;
    }

    public void UpdateJumps(int jumps)
    {
        jumpsText.text = "Jumps: " + jumps;
        Debug.Log("Jumps updated to: " + jumps);

        if (jumps <= 0)
        {
            jumpsText.text = "Jumps: 0";

            if (jumps < 0)
            {
                FindObjectOfType<GameOver>().GameOverScreen(true);
            }
        } 
        else if (jumps >= 0)
        {
            FindObjectOfType<GameOver>().GameOverScreen(false);
        }
    }

    public void RemoveJumps()
    {
        jumps -= 1;
        UpdateJumps(jumps);
        FindObjectOfType<PlayerShip>().gameObject.SetActive(true);
    }
}
