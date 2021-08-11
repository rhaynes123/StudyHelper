using Microsoft.EntityFrameworkCore.Migrations;

namespace StudyHelper.Migrations
{
    public partial class InitCorrectAnswers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string sql = @"
                    INSERT INTO CorrectAnswer(QuestionId, AnswerOption) VALUES(1,'No');
                    INSERT INTO CorrectAnswer(QuestionId, AnswerOption) VALUES(2,'Yes');
                    INSERT INTO CorrectAnswer(QuestionId, AnswerOption) VALUES(3,'Yes');
                    ";
            migrationBuilder.Sql(sql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
