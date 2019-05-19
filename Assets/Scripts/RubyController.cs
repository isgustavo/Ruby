using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using odt.util;

public class RubyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = CustomInput.InputBy.GetAxis(Axis.HORIZONTAL);
        float vertical = CustomInput.InputBy.GetAxis(Axis.VERTICAL);
        Vector2 position = transform.position;
        position.x = position.x + 3f * horizontal * Time.deltaTime;
        position.y = position.y + 3f * vertical * Time.deltaTime;
        transform.position = position;
    }
}
