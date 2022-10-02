using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{

    // Class Variables
    private readonly Random rand = new Random();
    public GameObject Penny;
    public AudioSource Bing;

    // Methods
    private void executeTrigger(string trigger) {

        if (Penny != null) {

            var animator = Penny.GetComponent<Animator>();

            if (animator != null) {

                animator.SetTrigger(trigger);
                Bing.Play();

            }

        }

    }

    public void flip() {

        int randNum = rand.Next(2);

        if (randNum == 0)
        {

            heads();

        }
        else {

            tails();

        }

    }

    private void heads() {

        executeTrigger("heads");

    }

    private void tails() {

        executeTrigger("tails");

    }
}
