// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

namespace ExpressionLab.DB
{

    // RoleAndAccountMapping
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class RoleAndAccountMappingConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<RoleAndAccountMapping>
    {
        public RoleAndAccountMappingConfiguration()
            : this("dbo")
        {
        }

        public RoleAndAccountMappingConfiguration(string schema)
        {
            ToTable("RoleAndAccountMapping", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.RoleId).HasColumnName(@"RoleId").IsRequired().HasColumnType("int");
            Property(x => x.Account).HasColumnName(@"Account").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Reasons).HasColumnName(@"Reasons").IsRequired().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.Valid).HasColumnName(@"Valid").IsRequired().HasColumnType("bit");
            Property(x => x.CreatorId).HasColumnName(@"CreatorId").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.CreatedAt).HasColumnName(@"CreatedAt").IsRequired().HasColumnType("datetime");
            Property(x => x.ModifierId).HasColumnName(@"ModifierId").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.ModifiedAt).HasColumnName(@"ModifiedAt").IsOptional().HasColumnType("datetime");
            Property(x => x.CreateBy).HasColumnName(@"CreateBy").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.CreatTime).HasColumnName(@"CreatTime").IsOptional().HasColumnType("datetime");
            Property(x => x.UpdateBy).HasColumnName(@"UpdateBy").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.UpdateTime).HasColumnName(@"UpdateTime").IsOptional().HasColumnType("datetime");
        }
    }

}
// </auto-generated>
