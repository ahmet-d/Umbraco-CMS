using NPoco;

namespace Umbraco.Cms.Infrastructure.Persistence.Dtos
{
    internal class ConstraintPerTableDto
    {
        [Column("TABLE_NAME")]
        public string TableName { get; set; } = null!;

        [Column("CONSTRAINT_NAME")]
        public string ConstraintName { get; set; } = null!;
    }
}
