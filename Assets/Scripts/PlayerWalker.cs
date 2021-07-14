using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalker : MonoBehaviour
{
    public float velocidade;
    public Animator anin_Player;
    public Rigidbody2D player;

    void Update()
    {

        Vector3 movimento = new Vector3(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"),0f);
        anin_Player.SetFloat("Horizontal", movimento.x);
        anin_Player.SetFloat("Vertical", movimento.y);
        anin_Player.SetFloat("Velocidade", movimento.magnitude);

        player.MovePosition(transform.position + movimento * velocidade * Time.deltaTime);
    }

}
