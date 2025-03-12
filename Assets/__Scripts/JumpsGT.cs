using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class JumpsGT : MonoBehaviour
{
    public TextMeshProUGUI jumpsText;
    private int jumps = 3;
    private float time = 0;
    private PlayerShip playerShip;
    // Start is called before the first frame update
    void Start()
    {
        playerShip = FindObjectOfType<PlayerShip>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerShip.gameObject.activeSelf == false)
        {
            time += Time.deltaTime;
        }
    }

    public void UpdateJumps(int jumps)
    {
        jumpsText.text = "Jumps: " + jumps;
        Debug.Log("Jumps updated to: " + jumps);

        if (jumps <= 0)
        {
            jumpsText.text = "Jumps: 0";
        } 
        if (jumps >= 0 && time > 2)
        {
            playerShip.gameObject.SetActive(true);
            time = 0;
        }
    }

    public void RemoveJumps()
    {
        jumps -= 1;
        UpdateJumps(jumps);
    }
}
