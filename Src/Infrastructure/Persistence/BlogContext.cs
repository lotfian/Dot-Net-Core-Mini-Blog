using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions options) : base(options) { }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Post> Posts { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //Add data to Category Entity
            builder.Entity<Categories>().HasData(new Categories
            {
                id = 1,
                ParentId = 0,
                CreateDate = DateTime.Now.Ticks,
                CategoryName = "Resaurant food",
            },
            new Categories
            {
                id = 2,
                ParentId = 0,
                CreateDate = DateTime.Now.Ticks,
                CategoryName = "Travel news ",
            },
            new Categories
            {
                id = 3,
                ParentId = 0,
                CreateDate = DateTime.Now.Ticks,
                CategoryName = "Modern technology",
            },
            new Categories
            {
                id = 4,
                ParentId = 0,
                CreateDate = DateTime.Now.Ticks,
                CategoryName = "Inspiration",
            },
            new Categories
            {
                id = 5,
                ParentId = 0,
                CreateDate = DateTime.Now.Ticks,
                CategoryName = "Health Care",
            });
            //Add data to Post Entity
            builder.Entity<Post>().HasData(
                new Post
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "Second divided from form fish beast made every of seas all gathered us saying he our",
                    Content = @"MCSE boot camps have its supporters and its detractors. Some people do not understand why you should have to spend money on boot camp when you can get the MCSE study materials yourself at a fraction of the camp price. However, who has the willpower
                                MCSE boot camps have its supporters and its detractors. Some people do not understand why you should have to spend money on boot camp when you can get the MCSE study materials yourself at a fraction of the camp price. However, who has the willpower to actually sit through a self-imposed MCSE training. who has the willpower to actually"
                },
                new Post
                {
                    Id = 2,
                    CategoryId = 2,
                    Title = "Google inks pact for new 35-storey office",
                    Content = @"When changing the text entered by the user, a request will be sent to the server in which we transfer the characters already printed. Then we get a response from the server with possible search query options and show them to the user.
                                Each time the user changes the text, an event handler is called, in which a request is send to the server.
                                To optimize the number of requests sent to the server, we use Debounce.
                                When the text is changed by the user, using Debounce allows us to create a timer, for example for 1 second. If 1 second passes and the user has not changed the text a second time, then the event handler is called and the request will be sent to the server. If the user changes the text for the second time in 1 second, then the 1st timer is reset and a new timer is created again for 1 second."
                },
                new Post
                {
                    Id = 3,
                    CategoryId = 3,
                    Title = "How old are you in programming ?",
                    Content = @"I've worked on a few noteworthy titles that people probably have heard of: Oregon Trail, Expression Blend, Visual Studio, Internet Explorer, Premiere Pro, and Photoshop.
                            I've had lots of brushes-with-fame with noteworthy developers who I've worked at the same company, and pestered in chat and email: Herb Sutter, Raymond Chen, Scott Meyers, Alexander Stepanov, Sean Parent, Gabriel Dos Reis, Arlo Belshee, Mads Torgersen, Anders Hejlsberg, Dave Abrahams."
                },
                new Post
                {
                    Id = 4,
                    CategoryId = 4,
                    Title = "Side Project Sunday! Hacking on anything?",
                    Content = @" If the user resizes the browser window and we need to change the content of the site.
                                Without optimization, the following happens. On each window resize event, the window resize event handler is called. So if the user, for example, resizes the window within 10 seconds, then 100, 200, and so on events that we need to process can happen.
                                Throttle allows us to set a time interval, more often than which the event handler will not be called. If we specify an interval of 1 second using Throttle, then the number of execution of window resize event handlers will be 10.
                                2) Showing the user the percentage of page scrolling. When the user scrolls the page, scroll events occur, which we need to handle. With throttle we can reduce the number of handled scroll events by setting a time interval."
                }
            );
        }
    }
}