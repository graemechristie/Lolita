using System.Linq;
using System.Reflection;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.EntityFrameworkCore.Storage;

namespace Pomelo.EntityFrameworkCore.Lolita
{
    internal static class ReflectionCommon
    {
        public static readonly FieldInfo QueryCompilerOfEntityQueryProvider = typeof(EntityQueryProvider).GetTypeInfo().DeclaredFields.SingleOrDefault(x => x.Name == "_queryCompiler");
        public static readonly PropertyInfo DatabaseOfQueryCompiler = typeof(QueryCompiler).GetTypeInfo().DeclaredProperties.SingleOrDefault(x => x.Name == "Database");
        public static readonly PropertyInfo DependenciesOfDatabase = typeof(Database).GetTypeInfo().DeclaredProperties.SingleOrDefault(x => x.Name == "Dependencies");
        public static readonly PropertyInfo DependenciesOfQueryCompilerContextFactory = typeof(QueryCompilationContextFactory).GetTypeInfo().DeclaredProperties.SingleOrDefault(x => x.Name == "Dependencies");
    }
}
