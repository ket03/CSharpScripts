public float speed = 10f;
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }