using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemieController : MonoBehaviour
{
    private Rigidbody2D _smallRatRigidbody2D;
    public float _smallRatSpeed;
    private Vector2 _smallRatDirection;
    public DetectionController _detectionArea;
    private SpriteRenderer _spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        _smallRatRigidbody2D = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        _smallRatDirection = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

    void FixedUpdate()
    {
        if (_detectionArea.detectedObjs.Count > 0)
        {
            _smallRatDirection = (_detectionArea.detectedObjs[0].transform.position - transform.position).normalized;
            _smallRatRigidbody2D.MovePosition(_smallRatRigidbody2D.position + _smallRatDirection * _smallRatSpeed * Time.fixedDeltaTime);
            
            if (_smallRatDirection.x > 0)
            {
                _spriteRenderer.flipX = true;
            }
            else if (_smallRatDirection.x < 0)
            {
                _spriteRenderer.flipX = false;
            }

        }
    }
}