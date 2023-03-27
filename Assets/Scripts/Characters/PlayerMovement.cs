using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    [SerializeField] AudioSource walkingSfx;
    private float moveSpeed;
    Animator playerAnim;
    Rigidbody2D myRigidbody;
    Vector2 lastClickPos;
    Vector2 oldPos;
    bool isMoving = false;
    bool walkSoundPlaying = false;

    private void Awake()
    {
        playerAnim = GetComponent<Animator>();
        myRigidbody = GetComponent<Rigidbody2D>();
        moveSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (DialogueManager.GetInstance().dialogueIsPlaying)
        {
            return;
        }
        MovePlayer();
        FlipSprite();
    }

    public void StopPlayer(Component sender, object data)
    {
        speed = 0f;
    }

    public void RestorePlayer(Component sender, object data)
    {
        speed = moveSpeed;
    }

    void OnMove(InputValue value)
    {
        oldPos = (Vector2)transform.position;
        lastClickPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        isMoving = true;
    }

    void MovePlayer()
    {
        if (isMoving && (Vector2)transform.position != lastClickPos)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, lastClickPos, step);
            playerAnim.SetBool("isWalking", true);
            ToggleSound();

        }
        else
        {
            walkSoundPlaying = false;
            walkingSfx.Stop();
            isMoving = false;
            playerAnim.SetBool("isWalking", false);
        }
    }

    void ToggleSound()
    {
        if (walkSoundPlaying)
            return;
        else
        {
            walkSoundPlaying = true;
            walkingSfx.Play();
        }

    }

    public void PlayerStartTalking(){
        lastClickPos = (Vector2)transform.position;
        isMoving = false;
    }

    void FlipSprite()
    {
        transform.localScale = new Vector2(Mathf.Sign(transform.position.x - oldPos.x), 1f);
    }
}
