namespace WebApplication1.Models.Interfaces
{
    /// <summary>
    /// Interface to implment on any Request Model that you would like to have hydrated by an Id parameter
    /// </summary>
    public interface IModelIdentifier
    {
        int Id { get; set; }
    }
}
