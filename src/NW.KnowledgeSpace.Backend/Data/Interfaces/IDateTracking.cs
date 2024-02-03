namespace NW.KnowledgeSpace.Backend.Data.Interfaces
{
    public interface IDateTracking
    {
        DateTime CreateDate { get; set; }

        DateTime? LastModifiedDate { get; set; }
    }
}
