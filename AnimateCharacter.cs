public Animator animator;

void Update()
{
    animator.SetFloat("Speed", Mathf.Abs(Move)); // Параметр Speed находящийся в аниматоре присваивает текущее значение Move
    animator.SetFloat("Height", Mathf.Abs(rb.velocity.y)); // Параметр Height находящийся в аниматоре присваивает текущее значение Move rb.velocity.y
}