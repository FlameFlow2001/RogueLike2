using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatToPlayer : MonoBehaviour
{
    private GameObject player;
    public float flightSpeed;
    public float gatheringDistance;

    public void Start()
    {
        player = GameObject.Find("Player");
    }

    private void Update()
    {

        if (player != null && Vector2.Distance(player.transform.position, transform.position) <= gatheringDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, flightSpeed * Time.deltaTime);
        }
    }
}
