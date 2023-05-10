using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    private int type;
    private GameObject target;
    private float bulletSpeed = 10f;
    private float bulletDamage = 10f;
    private bool pushBack = false;
    private Troop isTargetTroop;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject == target) {
            if (pushBack) {
                isTargetTroop.pushBack();
            }
            target.TakeDamage(bulletDamage);
            Destroy(gameObject);
        }

      
    }

    public void Initialize(GameObject target, int type)
    {
        this.type = type;
        this.target = target;
        isTargetTroop = target.GetComponent<Troop>();
    }

    private void Update()
    {
        if (!isTargetTroop) {
            switch (type) {
                case 0:
                break;
                case 1:
                break;
                case 2:
                break;
                case 3:
                break;
                default:
                break;
            }
        } else {
            switch (type) {
                case 0:
                break;
                case 1:
                bulletSpeed = 50f;
                transform.Rotate(new Vector3(0, 0, 1));
                pushBack = true;
                break;
                case 2:
                break;
                case 3:
                break;
                default:
                break;
            }
        }
        
        
        
        if (target != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.transform.position, bulletSpeed * Time.deltaTime);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
