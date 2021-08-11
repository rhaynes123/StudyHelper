using Microsoft.EntityFrameworkCore.Migrations;

namespace StudyHelper.Migrations
{
    public partial class AddInitAzureQuestions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string sql = @" INSERT INTO Question(Text,Category) VALUES('New Azure users get Azure free for 2 years','Azure');
                            INSERT INTO Question(Text,Category) VALUES('VMs are examples of Platform as a Service or PASS','Azure');
                            INSERT INTO Question(Text,Category) VALUES('Azure is an OpEx model','Azure');
                        ";
            migrationBuilder.Sql(sql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
