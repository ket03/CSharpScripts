private Rigidbody2D rb;
private float speed = 10, jump = 300;
private float Move;
private bool is_grounded = true;

void Start()
{
    rb = GetComponent<Rigidbody2D>();
}

void Update()
{
    Move = Input.GetAxisRaw("Horizontal");  // Считывает горизонтальные нажатия A/D или стрелки
    rb.velocity = new Vector2(Move * speed, rb.velocity.y); // Меняет расположение героя на

    // AddForce толкает героя вверх с указанной силой
    if (Input.GetButtonDown("Jump") && is_grounded)
    {
        rb.AddForce(new Vector2(rb.velocity.x, jump * 10));
    }
}

// Проверка соприкосновений коллизий героя и обьектов с указанным ТЕГОМ
private void OnCollisionEnter2D(Collision2D collision)
{
    if (collision.gameObject.CompareTag("Ground"))
    {
        is_grounded = true;
    }
}

// Проверка выхода коллизий героя и обьектов с указанным ТЕГОМ
private void OnCollisionExit2D(Collision2D collision)
{
    if (collision.gameObject.CompareTag("Ground"))
    {
        is_grounded = false;
    }
}