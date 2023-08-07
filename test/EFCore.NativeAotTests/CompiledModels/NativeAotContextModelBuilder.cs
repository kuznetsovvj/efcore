// <auto-generated />
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Update.Internal;

#pragma warning disable 219, 612, 618
#nullable enable

namespace Microsoft.EntityFrameworkCore.NativeAotTests.CompiledModels
{
    public partial class NativeAotContextModel
    {
        partial void Initialize()
        {
            var user = UserEntityType.Create(this);

            UserEntityType.CreateAnnotations(user);

            AddAnnotation("ProductVersion", "8.0.0-dev");
            AddAnnotation("Relational:MaxIdentifierLength", 128);
            AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
            AddRuntimeAnnotation("Relational:RelationalModel", CreateRelationalModel());
        }

        private IRelationalModel CreateRelationalModel()
        {
            var relationalModel = new RelationalModel(this);

            var user = FindEntityType("Microsoft.EntityFrameworkCore.NativeAotTests.Models.User")!;

            var defaultTableMappings = new List<TableMappingBase<ColumnMappingBase>>();
            user.SetRuntimeAnnotation("Relational:DefaultMappings", defaultTableMappings);
            var microsoftEntityFrameworkCoreNativeAotTestsModelsUserTableBase = new TableBase("Microsoft.EntityFrameworkCore.NativeAotTests.Models.User", null, relationalModel);
            var idColumnBase = new ColumnBase<ColumnMappingBase>("Id", "int", microsoftEntityFrameworkCoreNativeAotTestsModelsUserTableBase);
            microsoftEntityFrameworkCoreNativeAotTestsModelsUserTableBase.Columns.Add("Id", idColumnBase);
            var nameColumnBase = new ColumnBase<ColumnMappingBase>("Name", "nvarchar(max)", microsoftEntityFrameworkCoreNativeAotTestsModelsUserTableBase);
            microsoftEntityFrameworkCoreNativeAotTestsModelsUserTableBase.Columns.Add("Name", nameColumnBase);
            relationalModel.DefaultTables.Add("Microsoft.EntityFrameworkCore.NativeAotTests.Models.User", microsoftEntityFrameworkCoreNativeAotTestsModelsUserTableBase);
            var microsoftEntityFrameworkCoreNativeAotTestsModelsUserMappingBase = new TableMappingBase<ColumnMappingBase>(user, microsoftEntityFrameworkCoreNativeAotTestsModelsUserTableBase, true);
            microsoftEntityFrameworkCoreNativeAotTestsModelsUserTableBase.AddTypeMapping(microsoftEntityFrameworkCoreNativeAotTestsModelsUserMappingBase, false);
            defaultTableMappings.Add(microsoftEntityFrameworkCoreNativeAotTestsModelsUserMappingBase);
            RelationalModel.CreateColumnMapping((ColumnBase<ColumnMappingBase>)microsoftEntityFrameworkCoreNativeAotTestsModelsUserTableBase.FindColumn("Id")!, user.FindProperty("Id")!, microsoftEntityFrameworkCoreNativeAotTestsModelsUserMappingBase);
            RelationalModel.CreateColumnMapping((ColumnBase<ColumnMappingBase>)microsoftEntityFrameworkCoreNativeAotTestsModelsUserTableBase.FindColumn("Name")!, user.FindProperty("Name")!, microsoftEntityFrameworkCoreNativeAotTestsModelsUserMappingBase);

            var tableMappings = new List<TableMapping>();
            user.SetRuntimeAnnotation("Relational:TableMappings", tableMappings);
            var usersTable = new Table("Users", null, relationalModel);
            var idColumn = new Column("Id", "int", usersTable);
            idColumn.Accessors = ColumnAccessorsFactory.CreateGeneric<int>(idColumn);
            usersTable.Columns.Add("Id", idColumn);
            var nameColumn = new Column("Name", "nvarchar(max)", usersTable);
            nameColumn.Accessors = ColumnAccessorsFactory.CreateGeneric<int>(nameColumn);
            usersTable.Columns.Add("Name", nameColumn);
            var pK_Users = new UniqueConstraint("PK_Users", usersTable, new[] { idColumn });
            usersTable.PrimaryKey = pK_Users;
            var pK_UsersUc = RelationalModel.GetKey(this,
                "Microsoft.EntityFrameworkCore.NativeAotTests.Models.User",
                new[] { "Id" });
            pK_Users.MappedKeys.Add(pK_UsersUc);
            RelationalModel.GetOrCreateUniqueConstraints(pK_UsersUc).Add(pK_Users);
            usersTable.UniqueConstraints.Add("PK_Users", pK_Users);
            relationalModel.Tables.Add(("Users", null), usersTable);
            var usersTableMapping = new TableMapping(user, usersTable, true);
            usersTable.AddTypeMapping(usersTableMapping, false);
            tableMappings.Add(usersTableMapping);
            RelationalModel.CreateColumnMapping(idColumn, user.FindProperty("Id")!, usersTableMapping);
            RelationalModel.CreateColumnMapping(nameColumn, user.FindProperty("Name")!, usersTableMapping);
            pK_Users.SetRowKeyValueFactory(new SimpleRowKeyValueFactory<int>(pK_Users));
            return relationalModel.MakeReadOnly();
        }
    }
}