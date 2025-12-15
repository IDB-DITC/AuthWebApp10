using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuthWebApplication.Migrations
{
    /// <inheritdoc />
    public partial class Sp_AuthorDetailsData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
      string qry = @"create or alter proc sp_GetAuthorDetails 
@authorid int
as
select *
from dbo.Authors as a
left join dbo.books as b
on a.id=b.AuthorId
where a.id = @authorid";

      migrationBuilder.Sql(qry);

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

      migrationBuilder.Sql("drop proc sp_GetAuthorDetails ");

    }
  }
}
