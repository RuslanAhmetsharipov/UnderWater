using UnityEngine;
using System.Collections;

public class PlatformMove : MonoBehaviour
{

    public Transform[] part;
    public Transform player;
    private Vector3 playercurrentposition;
    // Use this for initialization
    void Start()
    {
        playercurrentposition = player.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        for (int i = 0; i < part.Length; i++)
        {
            Vector3 temp = player.transform.position - playercurrentposition + part[i].transform.position;
            part[i].transform.position = new Vector3(temp.x,part[i].transform.position.y,temp.z);
            playercurrentposition = player.transform.position;
        }
    }
}
