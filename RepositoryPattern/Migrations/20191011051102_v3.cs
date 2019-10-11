using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.IO;

namespace RepositoryPattern.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            string filePath = @"D:\Tutorials\Design Patterns\RepositoryPattern\RepositoryPattern\Migrations\Sql\InsertToStudents.sql";
            migrationBuilder.Sql(File.ReadAllText(filePath));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
