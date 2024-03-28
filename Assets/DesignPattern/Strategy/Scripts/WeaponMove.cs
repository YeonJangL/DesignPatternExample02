using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 무기 객체 전체에 연결
public class WeaponMove : MonoBehaviour
{
    [SerializeField][Range(5, 10)] float speed = 10.0f; // 무기 공격 속도

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);

        if (transform.position.y > 10.0f)
        {
            Destroy(gameObject);
        }
    }
}
