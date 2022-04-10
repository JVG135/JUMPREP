using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercoords : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    { player.transform.position = new Vector2(PlayerPrefs.GetFloat("X"), PlayerPrefs.GetFloat("Y")); }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnApplicationQuit()
    {
        var xPos = player.transform.position.x;
        var yPos = player.transform.position.y;
        PlayerPrefs.SetFloat("X", xPos);
        PlayerPrefs.SetFloat("Y", yPos);
        PlayerPrefs.Save();
    }

    public void LoadPosition()
    {}
}
