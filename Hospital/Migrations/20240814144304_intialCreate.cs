using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace Hospital.Migrations
{
    public partial class intialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "doctor",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    surname = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    contact = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false),
                    username = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
                    password = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
                    theme = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    language = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_doctor", x => x.id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "item",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    item_name = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_item", x => x.id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "manager",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
                    surname = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
                    contact = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
                    username = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
                    password = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
                    theme = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    language = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_manager", x => x.id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "nurse",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
                    surname = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
                    contact = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
                    username = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
                    password = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
                    theme = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false),
                    language = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nurse", x => x.id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "patient",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    surname = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    contact = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false),
                    address = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    birth_date = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_patient", x => x.id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "admission",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    admission_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    discharge_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    Patient_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admission", x => x.id);
                    table.ForeignKey(
                        name: "fk_Admission_Patient1",
                        column: x => x.Patient_id,
                        principalTable: "patient",
                        principalColumn: "id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "appointment",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    date = table.Column<DateTime>(type: "datetime", nullable: false),
                    Doctor_idDoctor = table.Column<int>(type: "int", nullable: false),
                    Patient_idPatient = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_appointment", x => x.id);
                    table.ForeignKey(
                        name: "fk_Appointment_Doctor",
                        column: x => x.Doctor_idDoctor,
                        principalTable: "doctor",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_Appointment_Patient1",
                        column: x => x.Patient_idPatient,
                        principalTable: "patient",
                        principalColumn: "id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "record",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Doctor_idDoctor = table.Column<int>(type: "int", nullable: false),
                    Patient_idPatient = table.Column<int>(type: "int", nullable: false),
                    date = table.Column<DateTime>(type: "datetime", nullable: false),
                    diagnosis = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    prescription = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_record", x => x.id);
                    table.ForeignKey(
                        name: "fk_Record_Doctor1",
                        column: x => x.Doctor_idDoctor,
                        principalTable: "doctor",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_Record_Patient1",
                        column: x => x.Patient_idPatient,
                        principalTable: "patient",
                        principalColumn: "id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "surgery",
                columns: table => new
                {
                    idSurgery = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    date = table.Column<DateTime>(type: "datetime", nullable: false),
                    notes = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Doctor_id = table.Column<int>(type: "int", nullable: false),
                    Patient_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.idSurgery);
                    table.ForeignKey(
                        name: "fk_Surgery_Doctor1",
                        column: x => x.Doctor_id,
                        principalTable: "doctor",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_Surgery_Patient1",
                        column: x => x.Patient_id,
                        principalTable: "patient",
                        principalColumn: "id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "fk_Admission_Patient1_idx",
                table: "admission",
                column: "Patient_id");

            migrationBuilder.CreateIndex(
                name: "fk_Appointment_Doctor_idx",
                table: "appointment",
                column: "Doctor_idDoctor");

            migrationBuilder.CreateIndex(
                name: "fk_Appointment_Patient1_idx",
                table: "appointment",
                column: "Patient_idPatient");

            migrationBuilder.CreateIndex(
                name: "username_UNIQUE",
                table: "doctor",
                column: "username",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "username_UNIQUE1",
                table: "manager",
                column: "username",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_Record_Doctor1_idx",
                table: "record",
                column: "Doctor_idDoctor");

            migrationBuilder.CreateIndex(
                name: "fk_Record_Patient1_idx",
                table: "record",
                column: "Patient_idPatient");

            migrationBuilder.CreateIndex(
                name: "fk_Surgery_Doctor1_idx",
                table: "surgery",
                column: "Doctor_id");

            migrationBuilder.CreateIndex(
                name: "fk_Surgery_Patient1_idx",
                table: "surgery",
                column: "Patient_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admission");

            migrationBuilder.DropTable(
                name: "appointment");

            migrationBuilder.DropTable(
                name: "item");

            migrationBuilder.DropTable(
                name: "manager");

            migrationBuilder.DropTable(
                name: "nurse");

            migrationBuilder.DropTable(
                name: "record");

            migrationBuilder.DropTable(
                name: "surgery");

            migrationBuilder.DropTable(
                name: "doctor");

            migrationBuilder.DropTable(
                name: "patient");
        }
    }
}
