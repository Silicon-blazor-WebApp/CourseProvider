namespace CourseProvider.Infrastructure.Data.Entites
{
    public class ContentEntity
    {
        public string? Description { get; set; }
        public string[]? Includes { get; set; }
        public virtual List<ProgramDetailItemEntity>? ProgramDetails { get; set; }
    }

}
