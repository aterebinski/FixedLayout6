using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FixedLayout6.Data.Migrations
{
    public partial class RenameIdentitytables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                newName: "Identity.UserTokens");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newName: "Identity.User");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                newName: "Identity.UserRoles");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                newName: "Identity.UserLogins");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                newName: "Identity.UserClaims");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                newName: "Identity.Role");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                newName: "Identity.RoleClaims");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "Identity.UserRoles",
                newName: "IX_Identity.UserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "Identity.UserLogins",
                newName: "IX_Identity.UserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "Identity.UserClaims",
                newName: "IX_Identity.UserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "Identity.RoleClaims",
                newName: "IX_Identity.RoleClaims_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Identity.UserTokens",
                table: "Identity.UserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Identity.User",
                table: "Identity.User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Identity.UserRoles",
                table: "Identity.UserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Identity.UserLogins",
                table: "Identity.UserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Identity.UserClaims",
                table: "Identity.UserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Identity.Role",
                table: "Identity.Role",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Identity.RoleClaims",
                table: "Identity.RoleClaims",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Identity.RoleClaims_Identity.Role_RoleId",
                table: "Identity.RoleClaims",
                column: "RoleId",
                principalTable: "Identity.Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Identity.UserClaims_Identity.User_UserId",
                table: "Identity.UserClaims",
                column: "UserId",
                principalTable: "Identity.User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Identity.UserLogins_Identity.User_UserId",
                table: "Identity.UserLogins",
                column: "UserId",
                principalTable: "Identity.User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Identity.UserRoles_Identity.Role_RoleId",
                table: "Identity.UserRoles",
                column: "RoleId",
                principalTable: "Identity.Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Identity.UserRoles_Identity.User_UserId",
                table: "Identity.UserRoles",
                column: "UserId",
                principalTable: "Identity.User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Identity.UserTokens_Identity.User_UserId",
                table: "Identity.UserTokens",
                column: "UserId",
                principalTable: "Identity.User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Identity.RoleClaims_Identity.Role_RoleId",
                table: "Identity.RoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_Identity.UserClaims_Identity.User_UserId",
                table: "Identity.UserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_Identity.UserLogins_Identity.User_UserId",
                table: "Identity.UserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_Identity.UserRoles_Identity.Role_RoleId",
                table: "Identity.UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_Identity.UserRoles_Identity.User_UserId",
                table: "Identity.UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_Identity.UserTokens_Identity.User_UserId",
                table: "Identity.UserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Identity.UserTokens",
                table: "Identity.UserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Identity.UserRoles",
                table: "Identity.UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Identity.UserLogins",
                table: "Identity.UserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Identity.UserClaims",
                table: "Identity.UserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Identity.User",
                table: "Identity.User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Identity.RoleClaims",
                table: "Identity.RoleClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Identity.Role",
                table: "Identity.Role");

            migrationBuilder.RenameTable(
                name: "Identity.UserTokens",
                newName: "AspNetUserTokens");

            migrationBuilder.RenameTable(
                name: "Identity.UserRoles",
                newName: "AspNetUserRoles");

            migrationBuilder.RenameTable(
                name: "Identity.UserLogins",
                newName: "AspNetUserLogins");

            migrationBuilder.RenameTable(
                name: "Identity.UserClaims",
                newName: "AspNetUserClaims");

            migrationBuilder.RenameTable(
                name: "Identity.User",
                newName: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "Identity.RoleClaims",
                newName: "AspNetRoleClaims");

            migrationBuilder.RenameTable(
                name: "Identity.Role",
                newName: "AspNetRoles");

            migrationBuilder.RenameIndex(
                name: "IX_Identity.UserRoles_RoleId",
                table: "AspNetUserRoles",
                newName: "IX_AspNetUserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_Identity.UserLogins_UserId",
                table: "AspNetUserLogins",
                newName: "IX_AspNetUserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Identity.UserClaims_UserId",
                table: "AspNetUserClaims",
                newName: "IX_AspNetUserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Identity.RoleClaims_RoleId",
                table: "AspNetRoleClaims",
                newName: "IX_AspNetRoleClaims_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
