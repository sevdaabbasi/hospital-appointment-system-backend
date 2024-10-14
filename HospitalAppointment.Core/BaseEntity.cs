namespace HospitalAppointment.Core;

public  abstract class BaseEntity<TId>
{
    public TId Id { get; set; }

    protected BaseEntity()
    {
    }

    protected BaseEntity(TId id) : this()
    {
        Id = id;
    }
}