using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

    public static List<Ability> enemyAbilities = new List<Ability>();
    public GameObject player;
    float speed = 1.2f;
    int health = 2;
    Vector3 currentMove = new Vector3 (0, 0, 0);
    float timeToNextMove = 1.0f;
    float moveTimer = 1.0f;

    // Use this for initialization
    void Start () {
        enemyAbilities.Add(new BasicAttack());
    }

    // Update is called once per frame
    void Update () {
        bool justSetMove = false;

        transform.position += currentMove * speed * Time.deltaTime;

        foreach (Ability a in enemyAbilities)
        {
            print(a.currentCooldown);
            if (a.currentCooldown < 0) 
            { //TODO: add range condition            
                currentMove = new Vector3(0, 0, 0); //stop for a bit and shoot
                justSetMove = true;
                a.activate(transform.position, player.transform.position, gameObject);
                a.currentCooldown = a.cooldown;
                moveTimer = 0.4f;
            }
            a.currentCooldown -= Time.deltaTime;
        }

        if (moveTimer < 0) {
            if (!justSetMove) {
                currentMove = new Vector3(Random.Range(-1, 1), Random.Range(-1, 1), 0);
                currentMove = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), 0);
                currentMove = currentMove.normalized;
                moveTimer = Random.Range(0.3f, 0.7f);
            }

        } else {
            justSetMove = false;
        }
        moveTimer -= Time.deltaTime;
    }
}
