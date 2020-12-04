using Microsoft.EntityFrameworkCore.Migrations;

namespace FarVision.Mes.Migrations
{
    public partial class addcolumnId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_STUDENT_REFERENCE_MAJOR",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Major",
                table: "Major");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "yctl",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ychj",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "WH_INVENTORY_PART",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "WH_INVENTORY_BARCODE",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "WH_ENTRY_INFO",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "WH_ENTRY_BARCODE",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "TMP_TZZMXL",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "TMP_SZBDATA",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "TMP_SZB",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "TMP_MATERIALS",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "TMP_JJG_HGL",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "TMP_HJ_HGL",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "TMP_DPH_HGL",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "TF_VHID",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "TBL_PROCESSINFO",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "TBL_BARCODE",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "TB_XRAYHGL",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "TB_TZRB_MX_MONTH",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "TB_TZRB_MX",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "TB_TZRB_HZ",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "TB_SZDATA",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "TB_SZB_DAYSTATISTICLOG",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "TB_RB_MX_MONTH",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "TB_RB_MX",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "TB_RB_HZ",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "TB_PERF_TIMESERVICELOG",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "TB_CPMXRB",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "TB_BL",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "T1",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "T_DEVICEBINDLOG",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "T_BASEUSER_DEVICE",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "SYS_FORMNO_INFO",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "SYS_BILLNO_TEMP",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "SYS_BILLNO_INFO_DEL",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "SYS_BILLNO_INFO",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "SYS_BARCODE_RULE",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "StudentID",
                table: "Student",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Student",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ST_BARCODEMERGEINFO",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "SPRD1",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "PROCESSINFO",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "PRDT_CUS1",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "PRD_SPC",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "PIDS_TEMP",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "PHOTO_TEMP",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "MF_VHID",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "MES_JOB_DATA",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Major",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "FILEDSTABLE",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "FIFOINCLUDELIST",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "FIELDSTABLE",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "EQPT_INFO_EA211_3",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "DCRRESULT",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "COMBITABLE",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "BAT_REC1",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ACTUALPARA",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ACTUALDCR",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                table: "Student",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Major",
                table: "Major",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_STUDENT_REFERENCE_MAJOR",
                table: "Student",
                column: "MajorID",
                principalTable: "Major",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_STUDENT_REFERENCE_MAJOR",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Major",
                table: "Major");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "yctl");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ychj");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "WH_INVENTORY_PART");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "WH_INVENTORY_BARCODE");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "WH_ENTRY_INFO");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "WH_ENTRY_BARCODE");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "TMP_TZZMXL");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "TMP_SZBDATA");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "TMP_SZB");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "TMP_MATERIALS");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "TMP_JJG_HGL");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "TMP_HJ_HGL");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "TMP_DPH_HGL");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "TF_VHID");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "TBL_PROCESSINFO");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "TBL_BARCODE");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "TB_XRAYHGL");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "TB_TZRB_MX_MONTH");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "TB_TZRB_MX");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "TB_TZRB_HZ");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "TB_SZDATA");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "TB_SZB_DAYSTATISTICLOG");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "TB_RB_MX_MONTH");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "TB_RB_MX");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "TB_RB_HZ");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "TB_PERF_TIMESERVICELOG");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "TB_CPMXRB");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "TB_BL");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "T1");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "T_DEVICEBINDLOG");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "T_BASEUSER_DEVICE");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "SYS_FORMNO_INFO");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "SYS_BILLNO_TEMP");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "SYS_BILLNO_INFO_DEL");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "SYS_BILLNO_INFO");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "SYS_BARCODE_RULE");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ST_BARCODEMERGEINFO");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "SPRD1");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PROCESSINFO");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PRDT_CUS1");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PRD_SPC");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PIDS_TEMP");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PHOTO_TEMP");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MF_VHID");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MES_JOB_DATA");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Major");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "FILEDSTABLE");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "FIFOINCLUDELIST");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "FIELDSTABLE");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "EQPT_INFO_EA211_3");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "DCRRESULT");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "COMBITABLE");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "BAT_REC1");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ACTUALPARA");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ACTUALDCR");

            migrationBuilder.AlterColumn<string>(
                name: "StudentID",
                table: "Student",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                table: "Student",
                column: "StudentID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Major",
                table: "Major",
                column: "MajorID");

            migrationBuilder.AddForeignKey(
                name: "FK_STUDENT_REFERENCE_MAJOR",
                table: "Student",
                column: "MajorID",
                principalTable: "Major",
                principalColumn: "MajorID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
