// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

#pragma warning disable 219, 612, 618
#nullable disable

namespace TestNamespace
{
    public partial class DbContextModel
    {
        private DbContextModel()
            : base(skipDetectChanges: false, modelId: new Guid("00000000-0000-0000-0000-000000000000"), entityTypeCount: 2)
        {
        }

        partial void Initialize()
        {
            var blog = BlogEntityType.Create(this);
            var post = PostEntityType.Create(this);

            PostEntityType.CreateForeignKey1(post, blog);

            BlogEntityType.CreateAnnotations(blog);
            PostEntityType.CreateAnnotations(post);

            AddAnnotation("Proxies:ChangeTracking", false);
            AddAnnotation("Proxies:CheckEquality", false);
            AddAnnotation("Proxies:LazyLoading", true);
        }
    }
}