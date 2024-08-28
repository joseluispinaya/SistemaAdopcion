using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaAdopcion.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class ImageNuevo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Pets",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(180)",
                oldMaxLength: 180);

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "https://firebasestorage.googleapis.com/v0/b/feriaemi-6e19d.appspot.com/o/pets%2Fimg_1.jpg?alt=media&token=1a971794-9bc1-4aca-a7ca-3315692b7875");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "https://firebasestorage.googleapis.com/v0/b/feriaemi-6e19d.appspot.com/o/pets%2Fimg_2.jpg?alt=media&token=0b95821c-3512-423d-9a4c-841f7088403a");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "https://firebasestorage.googleapis.com/v0/b/feriaemi-6e19d.appspot.com/o/pets%2Fimg_3.jpg?alt=media&token=49be1e88-1b4c-46ce-8a83-0710b0e81625");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "https://firebasestorage.googleapis.com/v0/b/feriaemi-6e19d.appspot.com/o/pets%2Fimg_4.jpg?alt=media&token=d9b8c38d-f808-46bf-83c4-ee301280cae6");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Image",
                value: "https://firebasestorage.googleapis.com/v0/b/feriaemi-6e19d.appspot.com/o/pets%2Fimg_5.jpg?alt=media&token=1401b97c-f684-4969-af98-a8a9614b0253");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 6,
                column: "Image",
                value: "https://firebasestorage.googleapis.com/v0/b/feriaemi-6e19d.appspot.com/o/pets%2Fimg_6.jpg?alt=media&token=47188d1f-dd7d-4474-b963-67ed6a47a471");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 7,
                column: "Image",
                value: "https://firebasestorage.googleapis.com/v0/b/feriaemi-6e19d.appspot.com/o/pets%2Fimg_7.jpg?alt=media&token=1dae9c1b-c35d-40ad-931d-e20df9d079a1");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 8,
                column: "Image",
                value: "https://firebasestorage.googleapis.com/v0/b/feriaemi-6e19d.appspot.com/o/pets%2Fimg_8.jpg?alt=media&token=0ab36e7b-0535-4766-8c7a-eb74450185e5");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 9,
                column: "Image",
                value: "https://firebasestorage.googleapis.com/v0/b/feriaemi-6e19d.appspot.com/o/pets%2Fimg_9.jpg?alt=media&token=bcd4982b-e50e-4782-8132-237d7c105f3d");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 10,
                column: "Image",
                value: "https://firebasestorage.googleapis.com/v0/b/feriaemi-6e19d.appspot.com/o/pets%2Fimg_10.jpg?alt=media&token=7444b974-1450-4b45-93a7-c9856b625f82");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 11,
                column: "Image",
                value: "https://firebasestorage.googleapis.com/v0/b/feriaemi-6e19d.appspot.com/o/pets%2Fimg_11.jpg?alt=media&token=4579f6db-2f2c-4732-92b8-c35cbde48ed6");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 12,
                column: "Image",
                value: "https://firebasestorage.googleapis.com/v0/b/feriaemi-6e19d.appspot.com/o/pets%2Fimg_12.jpg?alt=media&token=6b7180e2-a21d-4e64-831c-1978230fdb10");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 13,
                column: "Image",
                value: "https://firebasestorage.googleapis.com/v0/b/feriaemi-6e19d.appspot.com/o/pets%2Fimg_13.jpg?alt=media&token=c4da5454-1ff4-4b1e-b23b-0941ea700eaa");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 14,
                column: "Image",
                value: "https://firebasestorage.googleapis.com/v0/b/feriaemi-6e19d.appspot.com/o/pets%2Fimg_14.jpg?alt=media&token=79d33f30-bd7e-45ba-bb5d-9767f4dfd96d");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 15,
                column: "Image",
                value: "https://firebasestorage.googleapis.com/v0/b/feriaemi-6e19d.appspot.com/o/pets%2Fimg_15.jpg?alt=media&token=b2d539ee-9672-4e56-87f6-e83bdbb98deb");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 16,
                column: "Image",
                value: "https://firebasestorage.googleapis.com/v0/b/feriaemi-6e19d.appspot.com/o/pets%2Fimg_16.jpg?alt=media&token=5fd1c57b-0705-4afc-8344-1a826424d08a");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 17,
                column: "Image",
                value: "https://firebasestorage.googleapis.com/v0/b/feriaemi-6e19d.appspot.com/o/pets%2Fimg_17.jpg?alt=media&token=695f39b1-d537-4107-9c9a-6ffdc1dea673");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 18,
                column: "Image",
                value: "https://firebasestorage.googleapis.com/v0/b/feriaemi-6e19d.appspot.com/o/pets%2Fimg_18.jpg?alt=media&token=05957dee-3988-4815-b6b5-b32081019716");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 19,
                column: "Image",
                value: "https://firebasestorage.googleapis.com/v0/b/feriaemi-6e19d.appspot.com/o/pets%2Fimg_19.jpg?alt=media&token=22e65341-f7a5-44bc-9480-52909d201a45");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 20,
                column: "Image",
                value: "https://firebasestorage.googleapis.com/v0/b/feriaemi-6e19d.appspot.com/o/pets%2Fimg_20.jpg?alt=media&token=b350def7-3a0d-4e9d-8504-cebc5b345006");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 21,
                column: "Image",
                value: "https://firebasestorage.googleapis.com/v0/b/feriaemi-6e19d.appspot.com/o/pets%2Fimg_21.jpg?alt=media&token=ae2c75d4-f378-4de8-8f24-f4f0d92ac9a7");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 22,
                column: "Image",
                value: "https://firebasestorage.googleapis.com/v0/b/feriaemi-6e19d.appspot.com/o/pets%2Fimg_22.jpg?alt=media&token=bd0a8b29-b83d-4036-a10d-3564f6562a59");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 23,
                column: "Image",
                value: "https://firebasestorage.googleapis.com/v0/b/feriaemi-6e19d.appspot.com/o/pets%2Fimg_23.jpg?alt=media&token=0cb4c8f4-202e-4aa4-bf6d-946f18e6df93");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 24,
                column: "Image",
                value: "https://firebasestorage.googleapis.com/v0/b/feriaemi-6e19d.appspot.com/o/pets%2Fimg_24.jpg?alt=media&token=98202ce4-31ba-4917-9450-5ef9933f2dbb");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 25,
                column: "Image",
                value: "https://firebasestorage.googleapis.com/v0/b/feriaemi-6e19d.appspot.com/o/pets%2Fimg_25.jpg?alt=media&token=ab896ffb-277c-425f-9ee5-51954184244b");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 26,
                column: "Image",
                value: "https://firebasestorage.googleapis.com/v0/b/feriaemi-6e19d.appspot.com/o/pets%2Fimg_26.jpg?alt=media&token=ef12e9a1-7aee-4aa2-8d7e-69f7cef7aec0");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 27,
                column: "Image",
                value: "https://firebasestorage.googleapis.com/v0/b/feriaemi-6e19d.appspot.com/o/pets%2Fimg_27.jpg?alt=media&token=003e6533-4d0e-43f9-85ca-c0b5448e6d91");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 28,
                column: "Image",
                value: "https://firebasestorage.googleapis.com/v0/b/feriaemi-6e19d.appspot.com/o/pets%2Fimg_28.jpg?alt=media&token=324da5fa-d971-41e9-9477-f82c8681110e");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 29,
                column: "Image",
                value: "https://firebasestorage.googleapis.com/v0/b/feriaemi-6e19d.appspot.com/o/pets%2Fimg_29.jpg?alt=media&token=e25697be-8ba7-4f8d-a7c1-fe1f47b3975c");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 30,
                column: "Image",
                value: "https://firebasestorage.googleapis.com/v0/b/feriaemi-6e19d.appspot.com/o/pets%2Fimg_30.jpg?alt=media&token=708ee214-106b-4cfd-a508-294789b2c35e");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 31,
                column: "Image",
                value: "https://firebasestorage.googleapis.com/v0/b/feriaemi-6e19d.appspot.com/o/pets%2Fimg_30.jpg?alt=media&token=708ee214-106b-4cfd-a508-294789b2c35e");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 32,
                column: "Image",
                value: "https://firebasestorage.googleapis.com/v0/b/feriaemi-6e19d.appspot.com/o/pets%2Fimg_14.jpg?alt=media&token=79d33f30-bd7e-45ba-bb5d-9767f4dfd96d");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 33,
                column: "Image",
                value: "https://firebasestorage.googleapis.com/v0/b/feriaemi-6e19d.appspot.com/o/pets%2Fimg_15.jpg?alt=media&token=b2d539ee-9672-4e56-87f6-e83bdbb98deb");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 34,
                column: "Image",
                value: "https://firebasestorage.googleapis.com/v0/b/feriaemi-6e19d.appspot.com/o/pets%2Fimg_17.jpg?alt=media&token=695f39b1-d537-4107-9c9a-6ffdc1dea673");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 35,
                column: "Image",
                value: "https://firebasestorage.googleapis.com/v0/b/feriaemi-6e19d.appspot.com/o/pets%2Fimg_7.jpg?alt=media&token=1dae9c1b-c35d-40ad-931d-e20df9d079a1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Pets",
                type: "nvarchar(180)",
                maxLength: 180,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "img_1.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "img_2.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "img_3.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "img_4.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Image",
                value: "img_5.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 6,
                column: "Image",
                value: "img_6.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 7,
                column: "Image",
                value: "img_7.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 8,
                column: "Image",
                value: "img_8.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 9,
                column: "Image",
                value: "img_9.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 10,
                column: "Image",
                value: "img_10.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 11,
                column: "Image",
                value: "img_11.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 12,
                column: "Image",
                value: "img_12.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 13,
                column: "Image",
                value: "img_13.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 14,
                column: "Image",
                value: "img_14.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 15,
                column: "Image",
                value: "img_15.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 16,
                column: "Image",
                value: "img_16.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 17,
                column: "Image",
                value: "img_17.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 18,
                column: "Image",
                value: "img_18.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 19,
                column: "Image",
                value: "img_19.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 20,
                column: "Image",
                value: "img_20.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 21,
                column: "Image",
                value: "img_21.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 22,
                column: "Image",
                value: "img_22.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 23,
                column: "Image",
                value: "img_23.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 24,
                column: "Image",
                value: "img_24.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 25,
                column: "Image",
                value: "img_25.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 26,
                column: "Image",
                value: "img_26.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 27,
                column: "Image",
                value: "img_27.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 28,
                column: "Image",
                value: "img_28.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 29,
                column: "Image",
                value: "img_29.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 30,
                column: "Image",
                value: "img_30.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 31,
                column: "Image",
                value: "img_11.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 32,
                column: "Image",
                value: "img_22.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 33,
                column: "Image",
                value: "img_3.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 34,
                column: "Image",
                value: "img_14.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: 35,
                column: "Image",
                value: "img_25.jpg");
        }
    }
}
