using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Persistence.Migrations
{
    public partial class InitalDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<long>(type: "bigint", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brief = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    DepthInTree = table.Column<int>(type: "int", nullable: false),
                    OrderNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SendDate = table.Column<long>(type: "bigint", nullable: false),
                    Alias = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RepliedTo = table.Column<int>(type: "int", nullable: false),
                    Unread = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    OrderNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "id", "Brief", "CategoryName", "CreateDate", "DepthInTree", "OrderNo", "ParentId", "Status" },
                values: new object[,]
                {
                    { 1, null, "Resaurant food", 637894925246657391L, 0, 0, 0, false },
                    { 2, null, "Travel news ", 637894925246657423L, 0, 0, 0, false },
                    { 3, null, "Modern technology", 637894925246657425L, 0, 0, 0, false },
                    { 4, null, "Inspiration", 637894925246657428L, 0, 0, 0, false },
                    { 5, null, "Health Care", 637894925246657431L, 0, 0, 0, false }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CategoryId", "Content", "OrderNo", "Status", "Title" },
                values: new object[,]
                {
                    { 1, 1, "MCSE boot camps have its supporters and its detractors. Some people do not understand why you should have to spend money on boot camp when you can get the MCSE study materials yourself at a fraction of the camp price. However, who has the willpower\n                                MCSE boot camps have its supporters and its detractors. Some people do not understand why you should have to spend money on boot camp when you can get the MCSE study materials yourself at a fraction of the camp price. However, who has the willpower to actually sit through a self-imposed MCSE training. who has the willpower to actually", 0, false, "Second divided from form fish beast made every of seas all gathered us saying he our" },
                    { 2, 2, "When changing the text entered by the user, a request will be sent to the server in which we transfer the characters already printed. Then we get a response from the server with possible search query options and show them to the user.\n                                Each time the user changes the text, an event handler is called, in which a request is send to the server.\n                                To optimize the number of requests sent to the server, we use Debounce.\n                                When the text is changed by the user, using Debounce allows us to create a timer, for example for 1 second. If 1 second passes and the user has not changed the text a second time, then the event handler is called and the request will be sent to the server. If the user changes the text for the second time in 1 second, then the 1st timer is reset and a new timer is created again for 1 second.", 0, false, "Google inks pact for new 35-storey office" },
                    { 3, 3, "I've worked on a few noteworthy titles that people probably have heard of: Oregon Trail, Expression Blend, Visual Studio, Internet Explorer, Premiere Pro, and Photoshop.\n                            I've had lots of brushes-with-fame with noteworthy developers who I've worked at the same company, and pestered in chat and email: Herb Sutter, Raymond Chen, Scott Meyers, Alexander Stepanov, Sean Parent, Gabriel Dos Reis, Arlo Belshee, Mads Torgersen, Anders Hejlsberg, Dave Abrahams.", 0, false, "How old are you in programming ?" },
                    { 4, 4, " If the user resizes the browser window and we need to change the content of the site.\n                                Without optimization, the following happens. On each window resize event, the window resize event handler is called. So if the user, for example, resizes the window within 10 seconds, then 100, 200, and so on events that we need to process can happen.\n                                Throttle allows us to set a time interval, more often than which the event handler will not be called. If we specify an interval of 1 second using Throttle, then the number of execution of window resize event handlers will be 10.\n                                2) Showing the user the percentage of page scrolling. When the user scrolls the page, scroll events occur, which we need to handle. With throttle we can reduce the number of handled scroll events by setting a time interval.", 0, false, "Side Project Sunday! Hacking on anything?" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
