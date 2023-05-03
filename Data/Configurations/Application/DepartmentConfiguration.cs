namespace Data.Configurations.Application;
public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
{
    public void Configure(EntityTypeBuilder<Department> builder)
    {
        builder.ToTable("usuario", "dbo");

        builder.HasKey(x => x.Id).HasName("pk_usuario");

        builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("id");
        builder.Property(x => x.Name).HasColumnName("nome");

        builder.HasMany(x => x.Usuarios).WithOne(x => x.Department);
    }
}