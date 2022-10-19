using WebApi.Models.Base;

namespace WebApi.Models;

public class Borrow : Model
{
    public int? UserId { get; set; }

    public int? EditorialId { get; set; }

    public DateTime loanDate { get; set; }

    public DateTime returnDate { get; set; }

    public bool WasReturn { get; set; }


    public virtual Book? Book { get; set; } = default!;

    public virtual User? User { get; set; } = default!;

}
