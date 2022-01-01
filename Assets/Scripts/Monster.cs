using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{

    [SerializeField] Sprite _deadSprite;
    [SerializeField] ParticleSystem _particleSystem;

    bool _hasDied = false;

    void OnCollisionEnter2D(Collision2D collision) {
        if(ShouldDieFromCollision(collision)) {
            Die();
        }
    }

    bool ShouldDieFromCollision(Collision2D collision)
    {
        if(_hasDied)
            return false;

        Bird bird = collision.gameObject.GetComponent<Bird>();
        if(bird != null) {
            return true;
        }

        if (collision.contacts[0].normal.y < -0.5) {
            return true;            
        }

        return false;
    }

    void Die() {
        _hasDied = true;
        GetComponent<SpriteRenderer>().sprite = _deadSprite;
        _particleSystem.Play();
        //gameObject.SetActive(false);
    }
}
